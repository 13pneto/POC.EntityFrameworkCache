using Ef_Cache.Data;
using EFCoreSecondLevelCacheInterceptor;
using MessagePack;
using MessagePack.Formatters;
using MessagePack.Resolvers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace Ef_Cache;

public class IoC
{
    public static ServiceProvider RegisterDependencies()
    {
        var services = new ServiceCollection();

        AddLogging(services);
        AddDatabase(services);

        services.AddSingleton<Utils>();

        return services.BuildServiceProvider();
    }

    private static void AddDatabase(ServiceCollection services)
    {
        services.AddDbContext<Context>();
        // services.AddDbContextPool<Context>();
    
        // services.AddDbContextPool<Context>((sp, ob) => 
        //     ob.UseSqlite(@"Data Source=xxxxx.sqlite")
        //         .AddInterceptors(sp.GetRequiredService<SecondLevelCacheInterceptor>()));

        
        const string providerName1 = "Redis1";

        services.AddEasyCaching(o =>
        {
            o.UseRedis(cfg =>
            {
                cfg.DBConfig.Endpoints.Add(
                    new EasyCaching.Core.Configurations.ServerEndPoint("192.168.3.18", 6379));
                cfg.SerializerName = "Pack";
            }, providerName1);
            
            o.WithMessagePack(so =>
            {
                so.EnableCustomResolver = true;

                so.CustomResolvers = CompositeResolver.Create(new IMessagePackFormatter[]
                {
                    DBNullFormatter.Instance // This is necessary for the null values
                }, new IFormatterResolver[]
                {
                    NativeDateTimeResolver.Instance, ContractlessStandardResolver.Instance,
                    StandardResolverAllowPrivate.Instance, TypelessContractlessStandardResolver.Instance,
                    DynamicGenericResolver.Instance
                });
            }, "Pack");
            
        });
        
        services.AddEFSecondLevelCache(options =>
        {
            options
                .UseEasyCachingCoreProvider(providerName1)
                .ConfigureLogging(true)
                .UseCacheKeyPrefix("EF_")
                .UseDbCallsIfCachingProviderIsDown(TimeSpan.FromMinutes(1))
                .CacheAllQueries(CacheExpirationMode.Sliding, TimeSpan.FromMinutes(2)); // Cache com expiração de 5 minutos
                ;
        });
        
        services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect("192.168.3.18"));


        //TO USE IN MEMORY
        // services.AddEFSecondLevelCache(options =>
        // {
        //     options
        //         .UseMemoryCacheProvider(CacheExpirationMode.Absolute, TimeSpan.FromMinutes(10))
        //         .
        //         .ConfigureLogging(true)
        //         .UseCacheKeyPrefix("EF_")
        //         // .CacheAllQueries(CacheExpirationMode.Absolute, TimeSpan.FromMinutes(5)); // Cache com expiração de 5 minutos
        //         ;
        // });
    }

    private static void AddLogging(ServiceCollection services)
    {
        services.AddLogging(x => x
            .AddConsole()
            .SetMinimumLevel(LogLevel.Warning));
    }
    
    public class DBNullFormatter : IMessagePackFormatter<DBNull>
    {
        public static DBNullFormatter Instance = new();

        private DBNullFormatter()
        {
        }

        public void Serialize(ref MessagePackWriter writer, DBNull value, MessagePackSerializerOptions options)
            => writer.WriteNil();

        public DBNull Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
            => DBNull.Value;
    }
}