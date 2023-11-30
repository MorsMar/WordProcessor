using Microsoft.Extensions.DependencyInjection;
using WordProcessor.DataLayer;
using WordProcessor.ApplicationLayer;
using WordProcessor.InfrastructureLayer.Services;
using WordProcessor.InfrastructureLayer.DataClasses;

namespace WordProcessor.InfrastructureLayer
{
    public static class DictionaryCollection
    {
        public static IServiceCollection ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<IInputService, InputService>();
            services.AddSingleton<IDatabaseDictionary, DatabaseDictionary>();
            services.AddScoped<IDictionaryFile, DictionaryFile>();
            services.AddScoped<IDictionaryService, DictionaryService>();
            return services;
        }
    }
}
