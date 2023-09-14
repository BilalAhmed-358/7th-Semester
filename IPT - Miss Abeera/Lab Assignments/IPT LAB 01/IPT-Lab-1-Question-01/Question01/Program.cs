using System;

namespace IPTLAB01
{
    class LabQuestions { 

        public static void Question01()
        {
            Console.WriteLine("This is Question01");
            Console.WriteLine("Enter the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int third = Convert.ToInt32(Console.ReadLine());
            int result=first+ second + third;
            Console.WriteLine("{0}+{1}+{2}={3}", first, second, third, result);
        }
    
        static void Main(string[] args)
        {
            Question01();
            
        }
    }

}