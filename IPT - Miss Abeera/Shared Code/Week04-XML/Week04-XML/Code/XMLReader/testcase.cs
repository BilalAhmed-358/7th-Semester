using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace XMLReader
{
    public class TestCase
    {
        public string id { get; set; }
        public string kind;
        public string arg1;
        public string arg2;
        public string expected;

        public override string ToString()
        {
            return id + " - " + kind + " - " + arg1 + " - " + arg2 + " - " + expected;
        }
    }

}
