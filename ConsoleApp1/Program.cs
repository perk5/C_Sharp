using System;

namespace ThreadingExample
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Main Thread Started");
            Thread T1 = new Thread(Thread1Function);
            T1.Start();

            Thread T2 = new Thread(Thread2Function);
            T2.Start();

            if (T1.Join(1000))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("It will take a little bit more time to complete..");
            }

                T2.Join();

            Console.WriteLine("Still Running..");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started...");
            Thread.Sleep(5000);
            Console.WriteLine("Thread one is about to return");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started...");
        }
    }
}