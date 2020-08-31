using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile_Hierarchy
{
    abstract public class Mobile
    {
        public abstract string OperationSystem();
        public abstract string Camera();
        public virtual string Memory()
        {

            return ("It has 8GB,16GB,32GB,64GB,128GB,256GB");
                
        }

        public virtual string Sim()
        {
            return ("All phones have at least one SIM card!");
        }
       
        

    }
}
