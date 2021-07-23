using System;
using System.Collections;
using Module2HW6.Services.Abstraction;
using Object = Module2HW6.Entities._1level.Object;

namespace Module2HW6.Services
{
    public class SortService : ISortService
    {
        public void SortByName(Object[] appliances)
        {
            var nc = new NameComparer();
            Array.Sort(appliances, nc);
        }
    }

    public class NameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var firstVal = x as Object;
            var secondVal = y as Object;
            return firstVal.Name.CompareTo(secondVal.Name);
        }
    }
}