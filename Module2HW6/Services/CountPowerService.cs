using Module2HW6.Entities._1level;
using Module2HW6.Services.Abstraction;

namespace Module2HW6.Services
{
    public class CountPowerService : ICountPowerService
    {
        public double CountPower(Object[] appliances)
        {
            var sum = 0.0;
            for (var i = 0; i < appliances.Length; i++)
            {
                if (appliances[i].IsPlugedIn)
                {
                    sum += appliances[i].Power;
                }
            }

            return sum;
        }
    }
}