using System;
using System.Text.RegularExpressions;

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
    class Task2
    {
        private static int FibonachiNumber(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonachiNumber(n - 1) + FibonachiNumber(n - 2);
            }
        }
        public void SolutionTask2()
        {
            int n;
            Console.WriteLine("Введите N");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write(FibonachiNumber(i).ToString() + " ");
            }
            Console.WriteLine();
        }
    }
    class Task4
    {
        private static int NOD(int n1, int n2)
        {
            int n = n1 % n2;
            n1 = n2;
            n2 = n;
            if (n > 0)
                return NOD(n1, n2);
            else
                return n1;
        }
        private static int NOK(int n1, int n2)
        {
            return n1 * n2 / NOD(n1, n2);
        }
        public void SolutionTask4()
        {
            int n1;
            int n2;
            Console.WriteLine("Введите первое число");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("NOD: " + NOD(n1, n2).ToString());
            Console.WriteLine("NOK: " + NOK(n1, n2).ToString());
        }
    }
    class Task5
    {
        public static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static string Palindrome(string input)
        {
            string reverseInput = Reverse(input);
            if (Equals(input, reverseInput))
                return "Палиндром";
            else
                return "Не палиндром";
        }
        public void SolutionTask5()
        {
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();


            Console.WriteLine(input + " - " + Palindrome(input));
            Console.WriteLine();
        }
    }
    class Task6
    {

        public static string DeleteNumbers(string input)
        {
            return Regex.Replace(input, "[0-9]", "", RegexOptions.IgnoreCase);

        }
        public void SolutionTask6()
        {
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            Console.WriteLine(DeleteNumbers(input));
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

            Console.WriteLine("Task2");
            Task2 n2 = new Task2();
            n2.SolutionTask2();

            Console.WriteLine("Task4");
            Task4 n4 = new Task4();
            n4.SolutionTask4();

            Console.WriteLine("Task5");
            Task5 n5 = new Task5();
            n5.SolutionTask5();

            Console.WriteLine("Task6");
            Task6 n6 = new Task6();
            n6.SolutionTask6();
        }
    }
}
