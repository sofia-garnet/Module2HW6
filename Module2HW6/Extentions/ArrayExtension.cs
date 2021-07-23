using Module2HW6.Entities._1level;
using Module2HW6.Entities._4level;

namespace Module2HW6.Extentions
{
    public static class ArrayExtension
    {
        public static Object FindByMpX(this Object[] appliances, double mpx)
        {
            for (var i = 0; i < appliances.Length; i++)
            {
                if (appliances[i] is SmartPhone sp)
                {
                    if (sp.CameraNumberOfMegapixels == mpx)
                    {
                        return sp;
                    }
                }
            }

            return null;
        } 
    }
}