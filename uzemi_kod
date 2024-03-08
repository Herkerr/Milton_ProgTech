using System;
 
namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Alakzat // angolul: Shape
    {
        public const int HÁROMSZÁG = 0;
        public const int NÉGYZET = 2;
        public const int TÉGLALAP = 3;
        public const int KÖR = 4;
        int alakzat;
        double a, b, c; // oldalhosszak, a körnél az az r
        public Alakzat(int alakzat, int a)
        {
            this.alakzat = alakzat;
            this.a = a;
        }
        public Alakzat(int alakzat, int a, int b) : this(alakzat, a)
        {
            this.b = b;
        }
        public Alakzat(int alakzat, int a, int b, int c) : this(alakzat,a,b)
        {
            this.c = c;
        }
        public double Kerület()
        {
            double k;
            if (alakzat == HÁROMSZÁG) k = a + b + c;
            else if (alakzat == NÉGYZET) k = 4 * a;
            else if (alakzat == TÉGLALAP) k = 2 * (a + b);
            else if (alakzat == KÖR) k = 2 * a * Math.PI;
            else k = -1.0;
            return k;
        }
    }
 
    public abstract class AbsAlakzat
    {
        public abstract double Kerület();
    }
    public class Háromszög : AbsAlakzat
    {
        double a, b, c;
        public Háromszög(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public override double Kerület()
        {
            return a + b + c;
        }
    }
    public class Négyzet : AbsAlakzat
    {
        double a;
        public Négyzet(double a)
        {
            this.a = a;
        }
        public override double Kerület()
        {
            return 4*a;
        }
    }
}
 
