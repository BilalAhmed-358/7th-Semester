namespace Question02
{
    internal class Program
        {
            private string reverseAndCapitalize(string inputByUser)
            {

                string returnString = "";
                for (int i = inputByUser.Length - 1; i >= 0; i--)
                {
                    returnString += char.ToUpper(inputByUser[i]);
                }
                //Console.WriteLine(returnString);
                return returnString;
            }
            private void Question02()
            {
                Console.WriteLine("Enter a string");
                string inputByUser = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("The output string is {0}", reverseAndCapitalize(inputByUser));
            }
            public static void Main(string[] args)
            {
                Program Q2 = new Program();
                Q2.Question02();
            }
        }
    }