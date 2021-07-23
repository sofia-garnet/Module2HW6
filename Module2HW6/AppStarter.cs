using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Services;
using Module2HW6.Services.Abstraction;

namespace Module2HW6
{
    public class AppStarter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IPlugInService, PlugInService>()
                .AddTransient<ICountPowerService, CountPowerService>()
                .AddTransient<ISortService, SortService>()
                .AddTransient<Provider.Provider>()
                .AddTransient<Starter>().BuildServiceProvider();

            serviceProvider.GetService<Starter>().Run();
        }
    }
}