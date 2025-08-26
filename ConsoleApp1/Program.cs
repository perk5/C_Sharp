using System;
using System.Collections.Generic;
public class MainClass
{
    private static void Main()
    {
        //Calculator.Add(4, 5);




        //List<int> numLIst = new List<int> { 4, 5, 15, 20, 30};
        int Add = Calculator.Add(new List<int> { 4, 5, 15, 20, 30 });

        Console.WriteLine(Add);

    }
}

public class Calculator
{
    [ObsoleteAttribute("Use Add(List<int> Numbers) Method")]
    public static int Add(int Fn, int Sn)
    {
        return Fn + Sn;
    }
    public static int Add(List<int> Numbers)
    {
        int Add = 0;
        foreach(int n in Numbers)
        {
            Add += n;
        }
        return Add;
    }
}