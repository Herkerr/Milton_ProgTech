using System;

namespace ConsoleApp1
{
    class Program
    {
        //Kompozitt tervezési minta, legismertebb kompozitt az a bináris fa. 
        static void Main(string[] args)
        {
            Binfa f1 = new Ag(3, new Level(1), new Level(2));
            Binfa f2 = new Ag(3, new Level(1), new Ag(2, new Level(4), new Level(5)));
            Binfa f3 = new Ag(3, new Level(1), new Ag(2, new Level(4), new Nullfa()));
            Console.WriteLine(f1.Szum());
            Console.WriteLine(f2.Szum());
            Console.WriteLine(f1.Max());
            Console.WriteLine(f2.Max());
            Console.WriteLine(f3.Szum());
            Console.ReadLine();
        }
    }

    abstract class Binfa
    {
        public abstract int Szum();
        public abstract int Max();

        public abstract int Count();
        public abstract int Maxdebth();
        public abstract int parosCount();
    }

    class Level : Binfa
    {
        int szam;
        public Level(int szam)
        {
            this.szam = szam;
        }
        public override int Szum()
        {
            return szam;
        }
        public override int Max()
        {
            return szam;
        }
        public override int Count()
        {
            return 1;
        }
        public override int Maxdebth()
        {
            return 1;
        }
        public override int parosCount()
        {
            if(szam % 2 ==0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    class Ag : Binfa
    {
        int szam;
        Binfa bal, jobb;
        public Ag(int szam, Binfa bal, Binfa jobb)
        {
            this.szam = szam;
            this.bal = bal;
            this.jobb = jobb;
            
        }
        public override int Szum()
        {
            return szam + bal.Szum() + jobb.Szum();
        }

        public override int Max()
        {
            //return Math.Max(Math.Max(szam, bal.Max()), jobb.Max()); 
            int a, b, c;
            a = szam;
            b = bal.Max();
            c = jobb.Max();
            if(a >= b && a >= c)
            {
                return a;
            }
            else if(b>=a && b>= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public override int Count()
        {
            return 1 + bal.Count() + jobb.Count();
        }
        public override int Maxdebth()
        {
            if(bal.Max() > jobb.Max())
            {
                return bal.Maxdebth() + 1;
            }
            else
            {
                return jobb.Maxdebth() + 1;
            }
        }
        public override int parosCount()
        {
            //Feldolgozom a számot, feldolgozom a bal oldalt és feldolgozom a jobb oldalt.
            if(szam % 2 ==0)
            {
                return 1 + bal.parosCount() + jobb.parosCount();
            }
            else
            {
                return 0 + bal.parosCount() + jobb.parosCount();
            }
        }
    }
    class Nullfa : Binfa
    {
        public override int Count()
        {
            return 0;
        }

        public override int Max()
        {
            return int.MinValue;
        }

        public override int Maxdebth()
        {
            return 0;
        }

        public override int parosCount()
        {
            return 0;
        }

        public override int Szum()
        {
            return 0;
        }
    }

}
