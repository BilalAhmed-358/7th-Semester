using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question04
{
    
    internal class TelephoneRecord
    {
        public string personName;
        public int AreaCode;
        public int TelePhoneNumber;

        public TelephoneRecord(string personName,int areaCode, int TelePhoneNumber)
        {
            this.personName = personName;
            this.AreaCode= areaCode;
            this.TelePhoneNumber = TelePhoneNumber;
            Console.WriteLine(personName+" "+ areaCode + " " + TelePhoneNumber);    

        }
    }
}
