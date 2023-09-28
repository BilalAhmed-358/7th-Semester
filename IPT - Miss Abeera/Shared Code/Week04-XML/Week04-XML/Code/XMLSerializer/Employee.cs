using System;
using System.Collections.Generic;
using System.Text;

namespace XMLSerializer
{
    [Serializable]
    public class Employee
    {
        
        public string Name { get; set; }
        public string Location { get; set; }
        public string Division { get; set; }

        [NonSerialized]
        int count;
    }
}
