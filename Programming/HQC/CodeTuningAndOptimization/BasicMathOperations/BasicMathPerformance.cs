using System;
using System.Diagnostics;

namespace BasicMathOperations
{
    public class BasicMathPerformance
    {
        public static void TestAddOperationPerfomance()
        {
            Console.Write("int:\t\t");
            DisplayExecutionTime(() =>
            {
                int number = 0;
                for (int i = 1; i < 20000000; i++)
                {
                    number += 5;
                }
            });

            Console.Write("long:\t\t");
            DisplayExecutionTime(() =>
            {
                long number = 0L;
                for (int i = 1; i < 20000000; i++)
                {
                    number += 5L;
                }
            });

            Console.Write("float:\t\t");
            DisplayExecutionTime(() =>
            {
                float number = 0f;
                for (int i = 1; i < 20000000; i++)
                {
                    number += 5f;
                }
            });

            Console.Write("double:\t\t");
            DisplayExecutionTime(() =>
            {
                double number = 0d;
                for (int i = 1; i < 20000000; i++)
                {
                    number += 5d;
                }
            });

            Console.Write("decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 0m;
                for (int i = 1; i < 20000000; i++)
                {
                    number += 5m;
                }
            });
        }

        public static void TestSubstractOperationPerfomance()
        {
            Console.Write("int:\t\t");
            DisplayExecutionTime(() =>
            {
                int number = 100000000;
                for (int i = 1; i < 20000000; i++)
                {
                    number -= 5;
                }
            });

            Console.Write("long:\t\t");
            DisplayExecutionTime(() =>
            {
                long number = 100000000L;
                for (int i = 1; i < 20000000; i++)
                {
                    number -= 5L;
                }
            });

            Console.Write("float:\t\t");
            DisplayExecutionTime(() =>
            {
                float number = 100000000f;
                for (int i = 1; i < 20000000; i++)
                {
                    number -= 5f;
                }
            });

            Console.Write("double:\t\t");
            DisplayExecutionTime(() =>
            {
                double number = 100000000d;
                for (int i = 1; i < 20000000; i++)
                {
                    number -= 5d;
                }
            });

            Console.Write("decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 100000000m;
                for (int i = 1; i < 20000000; i++)
                {
                    number -= 5m;
                }
            });
        }

        public static void TestIncrementOperationPerfomance()
        {
            Console.Write("int:\t\t");
            DisplayExecutionTime(() =>
            {
                int number = 0;
                for (int i = 1; i < 20000000; i++)
                {
                    number++;
                }
            });

            Console.Write("long:\t\t");
            DisplayExecutionTime(() =>
            {
                long number = 0L;
                for (int i = 1; i < 20000000; i++)
                {
                    number++;
                }
            });

            Console.Write("float:\t\t");
            DisplayExecutionTime(() =>
            {
                float number = 0f;
                for (int i = 1; i < 20000000; i++)
                {
                    number++;
                }
            });

            Console.Write("double:\t\t");
            DisplayExecutionTime(() =>
            {
                double number = 0d;
                for (int i = 1; i < 20000000; i++)
                {
                    number++;
                }
            });

            Console.Write("decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 0m;
                for (int i = 1; i < 20000000; i++)
                {
                    number++;
                }
            });
        }

        public static void TestMultiplyOperationPerfomance()
        {
            Console.Write("int:\t\t");
            DisplayExecutionTime(() =>
            {
                int number = 7;
                for (int i = 1; i < 20000000; i++)
                {
                    number *= 1;
                }
            });

            Console.Write("long:\t\t");
            DisplayExecutionTime(() =>
            {
                long number = 7L;
                for (int i = 1; i < 20000000; i++)
                {
                    number *= 1L;
                }
            });

            Console.Write("float:\t\t");
            DisplayExecutionTime(() =>
            {
                float number = 7f;
                for (int i = 1; i < 20000000; i++)
                {
                    number *= 1f;
                }
            });

            Console.Write("double:\t\t");
            DisplayExecutionTime(() =>
            {
                double number = 7d;
                for (int i = 1; i < 20000000; i++)
                {
                    number *= 1d;
                }
            });

            Console.Write("decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 7m;
                for (int i = 1; i < 20000000; i++)
                {
                    number *= 1m;
                }
            });
        }

        public static void TestDivideOperationPerfomance()
        {
            Console.Write("int:\t\t");
            DisplayExecutionTime(() =>
            {
                int number = 7;
                for (int i = 1; i < 20000000; i++)
                {
                    number /= 1;
                }
            });

            Console.Write("long:\t\t");
            DisplayExecutionTime(() =>
            {
                long number = 7L;
                for (int i = 1; i < 20000000; i++)
                {
                    number /= 1L;
                }
            });

            Console.Write("float:\t\t");
            DisplayExecutionTime(() =>
            {
                float number = 7f;
                for (int i = 1; i < 20000000; i++)
                {
                    number /= 1f;
                }
            });

            Console.Write("double:\t\t");
            DisplayExecutionTime(() =>
            {
                double number = 7d;
                for (int i = 1; i < 20000000; i++)
                {
                    number /= 1d;
                }
            });

            Console.Write("decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 7m;
                for (int i = 1; i < 20000000; i++)
                {
                    number /= 1m;
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
            Console.WriteLine("Testing addition of different value types:");
            TestAddOperationPerfomance();
            Console.WriteLine("Testing substraction of different value types:");
            TestSubstractOperationPerfomance();
            Console.WriteLine("Testing incrementation of different value types:");
            TestIncrementOperationPerfomance();
            Console.WriteLine("Testing multiplication of different value types:");
            TestMultiplyOperationPerfomance();
            Console.WriteLine("Testing division of different value types:");
            TestDivideOperationPerfomance();
        }
    }
}
