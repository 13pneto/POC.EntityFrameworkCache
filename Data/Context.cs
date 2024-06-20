using AutoFixture;
using Ef_Cache.Entities;
using EFCoreSecondLevelCacheInterceptor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ef_Cache.Data;

public class Context : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<OptionGroup> OptionGroups { get; set; }
    public DbSet<Category> Categories { get; set; }

    private Fixture fixture = new();

    private readonly IServiceProvider _serviceProvider;

    // public Context(IServiceProvider serviceProvider)
    // {
    //     _serviceProvider = serviceProvider;
    // }

    private int quantityComplexity = 5;


    public Context(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public Context(DbContextOptions<Context> options, IServiceProvider serviceProvider) : base(options)
    {
        _serviceProvider = serviceProvider;
        
        if (Categories.Any() == false)
        {
            for (int i = 0; i < 1; i++)
            {
                var category = fixture
                    .Build<Category>()
                    .With(x => x.Stores, new List<Store>())
                    .With(x => x.Products, new List<Product>())
                    .Create();
    
                category.Stores = fixture
                    .Build<Store>()
                    .Without(x => x.Categories)
                    .CreateMany(quantityComplexity).ToList();
                
    
                for (int j = 0; j < quantityComplexity; j++)
                {
                    category.Products.Add(CreateLargeProduct(category));
                }
    
                Categories.Add(category);
            }
        }
    
        SaveChanges();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder
            .UseSqlite(@"Data Source=C:\Users\13pne\RiderProjects\Ef-Cache\Ef-Cache\xxxxx.db")
            .AddInterceptors(_serviceProvider.GetService<SecondLevelCacheInterceptor>())
            ;
    }
    
    
    
    private Product CreateLargeProduct(Category category)
    {
        var optionGroups = fixture.CreateMany<OptionGroup>(quantityComplexity).ToList();

        optionGroups.ForEach(x => { x.Options = fixture.CreateMany<Option>(quantityComplexity).ToList(); });

        var product = fixture
            .Build<Product>()
            .Without(x => x.OptionGroups)
            .Without(x => x.Category)
            .Create();

        product.OptionGroups = optionGroups;
        product.Category = category;

        return product;
    }
}