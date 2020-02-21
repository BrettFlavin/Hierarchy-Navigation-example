using System;
using System.Collections.Generic;
using System.Text;

namespace HW3_Heirarchy
{
    public class MalawiFact
    {
        public string Fact { get; set; }

        // override ToString method to return the Fact property
        public override string ToString()
        {
            return Fact;
        }
    }    
}
