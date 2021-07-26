using System;
using System.Diagnostics;

namespace PackAndUnpackTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int i1 = 1;
            object o;
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch1.Start();
            o = i1;             //упаковка типа int в object
            stopwatch1.Stop();
            Console.WriteLine("Время упаковки = " + stopwatch1.ElapsedTicks + " тактов");


            stopwatch2.Start();
            int i2 = (int)o;    //распаковка из object  с явным приведением в тип int
            stopwatch2.Stop();
            Console.WriteLine("Время распаковки = " + stopwatch2.ElapsedTicks + " тактов");
        }
    }
}
