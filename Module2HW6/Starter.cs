using System;
using Module2HW6.Entities._4level;
using Module2HW6.Extentions;
using Module2HW6.Services.Abstraction;

namespace Module2HW6
{
    public class Starter
    {
        private readonly IPlugInService _iPlugInService;
        private readonly ICountPowerService _iCountPowerService;
        private readonly ISortService _iSortService;
        private readonly Provider.Provider _provider;

        public Starter(
            IPlugInService iPlugInService, 
            ICountPowerService iCountPowerService, 
            ISortService iSortService,
            Provider.Provider provider)
        {
            _iPlugInService = iPlugInService;
            _iCountPowerService = iCountPowerService;
            _iSortService = iSortService;
            _provider = provider;
        }
        public void Run()
        {
            var appl= _provider.Appliences;
            _iPlugInService.PlugInSomeDiveices(appl);
            for (var i = 0; i < appl.Length; i++)
            {
                Console.WriteLine($"{appl[i].Name} {appl[i].IsPlugedIn}");
            }
            var power= _iCountPowerService.CountPower(appl);
            Console.WriteLine(power);
            _iSortService.SortByName(appl);
            Console.WriteLine("After sort");
            for (var i = 0; i < appl.Length; i++)
            {
                Console.WriteLine($"{appl[i].Name} {appl[i].IsPlugedIn}");
            }

            var obj = (SmartPhone) appl.FindByMpX(17.5);
            Console.WriteLine("Found phone is:");
            Console.WriteLine($"{obj.Name} {obj.CameraNumberOfMegapixels}");
        }
    }
}