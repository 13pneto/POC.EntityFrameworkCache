using System.ComponentModel.DataAnnotations;

namespace Ef_Cache;

public static class ResultDto
{
    public static Dictionary<CacheState, List<long>> ElapsedInMilisecondsByCacheState { get; set; } = new()
    {
        { CacheState.With, [] },
        { CacheState.Without, [] },
    };
    
    public static void AddElapsedInMilisecondsByCacheState(CacheState cacheState, long elapsedInMiliseconds)
    {
        ElapsedInMilisecondsByCacheState[cacheState]
            .Add(elapsedInMiliseconds);
    }  
    
    public static void AddElapsedInMilisecondsByCacheState(bool isCached, long elapsedInMiliseconds)
    {
        ElapsedInMilisecondsByCacheState[isCached ? CacheState.With : CacheState.Without]
            .Add(elapsedInMiliseconds);
    }  
    


    public enum CacheState
    {
        [Display(Name = "Com cache")] With,

        [Display(Name = "Sem cache")] Without
    }
}