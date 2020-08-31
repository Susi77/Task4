using Mobile_Hierarchy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nokiaa
{
    public class Nokia : Mobile
    {
        protected string RAM() 
        {
            return ("It has 2GB,4GB,6GB RAM.");
        }
        public virtual string Chip()
        {
            return ("It has a chip.");
        }
        public override string Camera()
        {
            return ("It has cameras");
        }

        public override string Memory()
        {
            return ("It has 8GB,16GB,64GB,128GB internal memory.");
        }

        public override string OperationSystem()
        {
            return("It works with Android operation system.");
        }

        public override string Sim()
        {
            return ("It has one and more SIM cards.");
        }
       
        
        public class NokiaX6 : Nokia
        {

            public override string Chip()
            {
                return base.Chip();
            }

            public override string Camera()
            {
                return ("It has 2 cameras.");
            }

            public override string Memory()
            {
                return ("It has 32GB and 64GB internal memory.");
            }

            public override string OperationSystem()
            {
                return ("It works with Android 10.");
            }

            public override string Sim()
            {
                return ("It has hybrid Dual SIM.");
            }

            public string UseProtecedRAM() 
            {
                return this.RAM();
            }
        }
    }
}
