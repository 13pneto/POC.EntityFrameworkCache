using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Threading.Channels;
using Ef_Cache;
using Ef_Cache.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

var serviceProvider = IoC.RegisterDependencies();
var utils = serviceProvider.GetRequiredService<Utils>();
var logger = serviceProvider.GetRequiredService<ILogger<Utils>>();
// var dbContext = serviceProvider.GetRequiredService<Context>();

while (true)
{
    Console.WriteLine("Tecle algo para iniciar: ");
    Console.ReadKey();
    Run();
    // await RunAsync();

    Console.WriteLine("\n\n================================\n\n");
}


void Run()
{ 
    utils.RunQueries(false, 3);
    utils.RunQueries(true, 3);
    
    logger.LogWarning("\n\n***Starting update to invalidate cache...***\n");
    
    utils.PersistNewCategory();
    
    for (var i = 0; i < 3; i++)
    {
        var elapsed =  utils.LogActionDuration(() => utils.GetCategoriesWithoutCache(), "Tempo sem cache DEPOIS DE ATUALIZAR");
        ResultDto.AddElapsedInMilisecondsByCacheState(false, elapsed);
    }
    
    for (var i = 0; i < 3; i++)
    {
        var elapsed = utils.LogActionDuration(() => utils.GetCategoriesWithCache(), "Tempo com cache DEPOIS DE ATUALIZAR");
        ResultDto.AddElapsedInMilisecondsByCacheState(true, elapsed);
    }


    Console.WriteLine("--------------------------------------------------");
    foreach (var cacheState in Enum.GetValues<ResultDto.CacheState>().ToList())
    {
        Console.Write($"|{cacheState.GetType().GetMember(cacheState.ToString())[0].GetCustomAttribute<DisplayAttribute>().Name}|");
        
        var elapses = ResultDto.ElapsedInMilisecondsByCacheState[cacheState];
        
        var elapsesJoined = string.Join("ms | ", elapses);
        Console.WriteLine($"{elapsesJoined}");
    }
    Console.WriteLine("--------------------------------------------------");
}

// async Task RunAsync()
// {
//     var sw = Stopwatch.StartNew();
//     var runQueries = new List<Task>();
//     
//     for (var i = 0; i < 5; i++)
//     { 
//         var runQuery = Task.Run(() => utils.RunQueries(true, 30));
//         runQueries.Add(runQuery);
//     }
//
//     await Task.WhenAll(runQueries);
//     sw.Stop();
//
//     Console.WriteLine($"Total RUNS {StaticData.TotalGet} - TEMPO: {sw.ElapsedMilliseconds} ms");
// }