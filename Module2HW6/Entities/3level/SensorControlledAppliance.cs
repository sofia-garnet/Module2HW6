using Module2HW6.Entities._2level;
using Module2HW6.Enums;

namespace Module2HW6.Entities._3level
{
    public abstract class SensorControlledAppliance : PhysicalObject
    {
        public SensorType SensorType { get; set; }
    }
}