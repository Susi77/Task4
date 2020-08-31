using Mobile_Hierarchy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xiaomii
{
    public class Xiaomi : Mobile
    {
        private string RAM() 
        {

            return ("It has 4GB and 6GB RAM."); 
        }

        public virtual string Chip()
        {
            return ("It has a chip.");
        }

        public override string Camera()
        {
            return("It has one and more cameras.");
        }

        public override string OperationSystem()
        {
            return("It works with Android operation system.");
        }

        public override string Memory()
        {
            return base.Memory();
        }

        public override string Sim()
        {
            return ("It has one and more SIM cards ");
        }



        public class XiaomiNote9s : Xiaomi
        {
            public override string Camera()
            {
                return ("It has 4 cameras.");
            }

            public override string OperationSystem()
            {
                return ("It works with Android 10.");
            }

            public override string Memory()
            {
                return ("It has 64GB and 128GB internal memory.");
            }

            public override string Sim()
            {
                return ("It has dual SIM card. ");
            }

            public string useRAM()
            {
                return this.RAM();
            }

            public override string Chip()
            {
                return base.Chip();
            }


        }


    }
}
