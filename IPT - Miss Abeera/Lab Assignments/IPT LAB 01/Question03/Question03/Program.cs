namespace Question03
{
    internal class Program
    {
        private int[,] AddMatrices(int[,] Array1, int[,] Array2)
        {
            int[,] answer = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    answer[i, j] = Array1[i, j] + Array2[i, j];   
                }

            }


            return answer;
        }
        private void Question03()
        {
            int[,] Array1 = new int[3, 3];
            int[,] Array2 = new int[3, 3];
            int[,] answer = new int[3, 3];
            int temp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp = 0;
                    Console.WriteLine("Enter the value of Array1[{0}][{1}]", i, j);
                    temp = Convert.ToInt32(Console.ReadLine());
                    Array1[i,j] = temp;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp = 0;
                    Console.WriteLine("Enter the value of Array2[{0}][{1}]", i, j);
                    temp = Convert.ToInt32(Console.ReadLine());
                    Array2[i, j] = temp;
                }
            }


            answer = AddMatrices(Array1, Array2);
            Console.WriteLine("The sum of two matrices is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(answer[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program q = new Program();
            q.Question03();
        }
    }
}