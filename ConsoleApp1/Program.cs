using System;
class Program
{
    static int total = 0;
    public static void Main()
    {

        Thread T1 = new Thread(AddOneMillion);
        Thread T2 = new Thread(AddOneMillion);
        Thread T3 = new Thread(AddOneMillion);
        T1.Start(); T2.Start(); T3.Start();
        T1.Join(); T2.Join(); T3.Join();

   
        Console.WriteLine("Total: " + total);

    }

    static object _lock = new object();
    public static void AddOneMillion()
    {
        for (int i = 0; i < 1000000; i++)
        {
            Monitor.Enter(_lock);
            try
            {
                total++;
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
    }
}