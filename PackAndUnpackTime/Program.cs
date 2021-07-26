using System;
using System.Diagnostics;

namespace PackAndUnpackTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 1;
            long l1 = 2;
            bool b1 = true;
            double d1 = 3.14159;

            object o1;
            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            


            stopwatch1.Reset();
            stopwatch1.Start();
            o1 = l1;             //упаковка типа long в object
            stopwatch1.Stop();
            Console.WriteLine("Время упаковки типа long в object = " + stopwatch1.ElapsedTicks + " тактов");

            stopwatch2.Reset();
            stopwatch2.Start();
            long l2 = (long)o1;    //распаковка из object с явным приведением в тип long
            stopwatch2.Stop();
            Console.WriteLine("Время распаковки типа object в long = " + stopwatch2.ElapsedTicks + " тактов");


            stopwatch1.Reset();
            stopwatch1.Start();
            o1 = b1;             //упаковка типа bool в object
            stopwatch1.Stop();
            Console.WriteLine("Время упаковки типа bool в object = " + stopwatch1.ElapsedTicks + " тактов");

            stopwatch2.Reset();
            stopwatch2.Start();
            bool b2 = (bool)o1;    //распаковка из object с явным приведением в тип bool
            stopwatch2.Stop();
            Console.WriteLine("Время распаковки типа object в bool = " + stopwatch2.ElapsedTicks + " тактов");

            stopwatch1.Reset();
            stopwatch1.Start();
            o1 = d1;             //упаковка типа double в object
            stopwatch1.Stop();
            Console.WriteLine("Время упаковки типа double в object = " + stopwatch1.ElapsedTicks + " тактов");

            stopwatch2.Reset();
            stopwatch2.Start();
            double d2 = (double)o1;    //распаковка из object с явным приведением в тип double
            stopwatch2.Stop();
            Console.WriteLine("Время распаковки типа object в double = " + stopwatch2.ElapsedTicks + " тактов");

            stopwatch1.Reset();
            stopwatch1.Start();
            o1 = i1;             //упаковка типа int в object
            stopwatch1.Stop();
            Console.WriteLine("Время упаковки типа int в object = " + stopwatch1.ElapsedTicks + " тактов");

            stopwatch2.Reset();
            stopwatch2.Start();
            int i2 = (int)o1;    //распаковка из object  с явным приведением в тип int
            stopwatch2.Stop();
            Console.WriteLine("Время распаковки типа object в int = " + stopwatch2.ElapsedTicks + " тактов");

        }
    }
}
