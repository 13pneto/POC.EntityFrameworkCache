using System.Diagnostics;
using AutoFixture;
using Ef_Cache.Data;
using Ef_Cache.Entities;
using EFCoreSecondLevelCacheInterceptor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ef_Cache;

public class Utils
{
    private readonly Context _dbContext;
    private readonly ILogger<Utils> _logger;

    public Utils(Context dbContext, ILogger<Utils> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public void RunQueries(bool withCache, int quantity = 3)
    {
        for (var i = 0; i < quantity; i++)
        {
            StaticData.TotalGet += 1;

            var elapsed = LogActionDuration(async () =>
                {
                    if (withCache)
                    {
                        GetCategoriesWithCache();
                    }
                    else
                    {
                        GetCategoriesWithoutCache();
                    }
                    
                   
                },
                $"Tempo {(withCache ? "com" : "sem")} cache {i}");
            
            ResultDto.AddElapsedInMilisecondsByCacheState(withCache, elapsed);
        }
    }

    public long LogActionDuration(Action action, string log)
    {
        var stopwatch = Stopwatch.StartNew();
        action.Invoke();
        stopwatch.Stop();
        _logger.LogWarning($"{log}: {stopwatch.ElapsedMilliseconds} ms");

        return stopwatch.ElapsedMilliseconds;
    }

    public List<Category> GetCategoriesWithCache()
    {
        return _dbContext.Categories
            .Include(x => x.Products)
            .ThenInclude(x => x.OptionGroups)
            .ThenInclude(x => x.Options)
            .Include(x => x.Stores)
            .Cacheable()
            .ToList();
    }

    public List<Category> GetCategoriesWithoutCache()
    {
        return _dbContext.Categories
            .Include(x => x.Products)
            .ThenInclude(x => x.OptionGroups)
            .ThenInclude(x => x.Options)
            .Include(x => x.Stores)
            .ToList();
    }

    public void PersistNewCategory()
    {
        var fixture = new Fixture();

        _dbContext.Categories.Add(fixture
            .Build<Category>()
            .Without(x => x.Products)
            .Without(x => x.Stores)
            .Create()
        );

        _dbContext.SaveChanges();
    }
}