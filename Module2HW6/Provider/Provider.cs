using Module2HW6.Entities._1level;
using Module2HW6.Entities._4level;
using Module2HW6.Enums;

namespace Module2HW6.Provider
{
    public class Provider
    {
        public Object[] Appliences { get;}

        public Provider()
        {
            Appliences = new Object[]
            {
                new Tamagotchi()
                {
                    ButtonsQuantity = 3,
                    InterfaceType = InterfaceType.Buttons,
                    Name = "KittenTamagochi",
                    PetType = TamagochiPetType.Cat,
                    Power = 15
                },
                new SmartPhone()
                {
                    CameraNumberOfMegapixels = 15.5,
                    InterfaceType = InterfaceType.Sensor,
                    Name = "Samsung X8",
                    SensorType = SensorType.Tactile,
                    Power = 66
                },
                new SmartPhone()
                {
                    CameraNumberOfMegapixels = 17.5,
                    InterfaceType = InterfaceType.Sensor,
                    Name = "iPhone XS",
                    SensorType = SensorType.Tactile,
                    Power = 55
                }
            };
        }
    }
}