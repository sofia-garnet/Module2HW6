using Module2HW6.Entities._1level;
using Module2HW6.Entities._4level;
using Module2HW6.Services.Abstraction;

namespace Module2HW6.Services
{
    public class PlugInService : IPlugInService
    {
        public void PlugInSomeDiveices(Object[] aplliences)
        {
            for (var i = 0; i < aplliences.Length; i++)
            {
                if (aplliences[i] is SmartPhone)
                {
                    aplliences[i].PlugIn();
                }
            }
        }
    }
}