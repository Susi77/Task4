using Microsoft.VisualBasic.CompilerServices;
using Mobile_Hierarchy;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;

namespace AppleIphonee
{
   public class AppleIphone:Mobile
    {
        private string Chip = "It has no chip.";

        protected string RAM()
        {
            return ("It has 2GB,4GB,8GB RAM.");
        }
        public override string Camera()
        {
            return ("It has one and more camera");
        }

        public override string Memory()
        {
            return("It has 16GB,32GB,64GB,128GB,256GB internal memory");
        }

        public override string OperationSystem()
        {
            return ("It works with IOS");
        }

        public override String Sim()
        {
            return ("Iphones have a sim but they also have e-sim. ");
        }
        public class Iphone9 : AppleIphone
        {
            public override string Camera()
            {
                return ("It has 2 cameras. ");

            }

            public override string Memory()
            {
                return ("It has 64GB,128GB,256GB internal memory");
            }

            public override string OperationSystem()
            {
                return ("It works with IOS 12 and more.");
            }
            public string UsePrivateMember() 
            {
                return this.Chip;
            }

            public override string Sim()
            {
                return ("It has a sim .");
            }
            
            public string useRAM()
            {
                return this.RAM();

            }
        }
    }
}
