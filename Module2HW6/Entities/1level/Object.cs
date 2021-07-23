using System;

namespace Module2HW6.Entities._1level
{
    public abstract class Object
    {
        public String Name { get; set; }
        public bool IsPlugedIn { get; private set; }
        
        public double Power { get; set; }
        public abstract double MyMethod();  
        
        public void PlugIn()
        {
            IsPlugedIn = true;
        }

    }
}