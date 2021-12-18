using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<double> ranarr = new List<double>();
        Random r = new Random();
        double min = -100;
        double max = 100;
        for (int i = 1; i <= 10; i++)
        {
            double d =r.NextDouble()*(max - min)+min;
            ranarr.Add(d);
        }
        ranarr.Sort();
        foreach (double i in ranarr.OrderBy(i => Math.Abs(i) - Math.Floor(Math.Abs(i))))
        {
            Console.WriteLine(i);
        }


    }
}