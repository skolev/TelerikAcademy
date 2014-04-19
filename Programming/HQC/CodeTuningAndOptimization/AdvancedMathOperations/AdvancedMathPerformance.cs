using System;
using System.Diagnostics;

namespace AdvancedMathOperations
{
    public class AdvancedMathPerformance
    {
        public static void TestSqrtOperationPerformance()
        {
            Console.Write("float:\t\t");
            DisplayExecutionTime(() =>
            {
                float number = 7f;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Sqrt(number);
                }
            });

            Console.Write("double:\t\t");
            DisplayExecutionTime(() =>
            {
                double number = 0d;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Sqrt(number);
                }
            });

            Console.Write("decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 7m;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Sqrt((double)number);
                }
            });
        }

        public static void TestLnOperationPerformance()
        {
            Console.Write("float:\t\t");
            DisplayExecutionTime(() =>
            {
                float number = 7f;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Log(number);
                }
            });

            Console.Write("double:\t\t");
            DisplayExecutionTime(() =>
            {
                double number = 0d;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Log(number);
                }
            });

            Console.Write("decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 7m;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Log((double)number);
                }
            });
        }

        public static void TestSinOperationPerformance()
        {
            Console.Write("float:\t\t");
            DisplayExecutionTime(() =>
            {
                float number = 7f;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Sin(number);
                }
            });

            Console.Write("double:\t\t");
            DisplayExecutionTime(() =>
            {
                double number = 0d;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Sin(number);
                }
            });

            Console.Write("decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 7m;
                for (int i = 1; i < 20000000; i++)
                {
                    Math.Sin((double)number);
                }
            });
        }

        public static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Main()
        {
            Console.WriteLine("Testing sqrt of different value types:");
            TestSqrtOperationPerformance();
            Console.WriteLine("Testing ln of different value types:");
            TestLnOperationPerformance();
            Console.WriteLine("Testing incrementation of different value types:");
            TestSinOperationPerformance();
        }
    }
}
