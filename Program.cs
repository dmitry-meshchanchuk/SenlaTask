using System;

namespace SenlaTask
{
    class Task1
    {
        private static bool PrimeNumber(int N)
        {
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
        public void SolutionTask1()
        {
            int n;
            Console.WriteLine("Введите N");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (PrimeNumber(i))
                {
                    Console.Write(i.ToString() + " ");
                }
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Task1 n1 = new Task1();
            n1.SolutionTask1();
        }
    }
}
