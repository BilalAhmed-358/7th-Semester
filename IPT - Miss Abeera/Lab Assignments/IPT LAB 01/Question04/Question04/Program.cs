using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Question04
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num = 0;
            string personName=null;
            int AreaCode=0;
            int TelePhoneNumber=0;
            Console.WriteLine("How many telephone records do you want?");
            num = Convert.ToInt32(Console.ReadLine());     

            TelephoneRecord[] records = new TelephoneRecord[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the name of person number {0}", i + 1);
                personName = Console.ReadLine()??string.Empty;
                Console.WriteLine("Enter the Area Code of person number {0}", i + 1);
                AreaCode=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Telephone number of the person number {0}", i + 1);
                TelePhoneNumber= Convert.ToInt32(Console.ReadLine());
                records[i]=new TelephoneRecord(personName, AreaCode, TelePhoneNumber);

            }

        }
    }

}