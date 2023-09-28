using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace XMLParser3
{
    public class TestCase
    {
        public string id;
        public string kind;
        public string arg1;
        public string arg2;
        public string expected;

        public override string ToString()
        {
            return id + " - " + kind + " - " + arg1 + " - " + arg2 + " - " + expected;
        }
    }

    //public class Suite
    //{
    //    public ArrayList items = new ArrayList();
    //    public void Display()
    //    {
    //        foreach (TestCase tc in items)
    //        {
    //            Console.Write(tc.id + " " + tc.kind + " " + tc.arg1 + " ");
    //            Console.WriteLine(tc.arg2 + " " + tc.expected);
    //        }
    //    }
    //}
}
