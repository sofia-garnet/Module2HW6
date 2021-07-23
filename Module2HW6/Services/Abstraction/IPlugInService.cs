using System;
using Module2HW6.Entities._4level;
using Object = Module2HW6.Entities._1level.Object;

namespace Module2HW6.Services.Abstraction
{
    public interface IPlugInService
    {
        void PlugInSomeDiveices(Object[] aplliences);
    }
}