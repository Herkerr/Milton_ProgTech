using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya();
            String s = k1.GyorsanFut();
            Console.WriteLine(s);
            Kutya2 k2 = new Kutya2();
            s = k2.GyorsanFut();
            Console.WriteLine(s);
 
            k2.SetGerinc(new AcélGerinces());
            
            Console.ReadLine();
        }
    }
    // IS-A kapcsolattal
    class Gerinces
    {
        public String Fut() { return "fut"; }
    }
    class AcélGerinces : Gerinces { }
    class Kutya : Gerinces
    {
        public String GyorsanFut() { return "gyorsan " + Fut();  }
    }
    // HAS-A kapcsolattal
    class Kutya2
    {
        private Gerinces gerinc = new Gerinces();
        public void SetGerinc(Gerinces gerinc) { this.gerinc = gerinc; }
        public String GyorsanFut() { return "gyorsan " + gerinc.Fut(); }
    }
    // Tétel mondat: amit lehet csinálni IS-A kapcsolatal, azt megcsinálható HAS-A kapcsolattal is
    // De: nem mindig érdemes, mert HAS-A kapcsolatnál nincs polimorfizmus
    //                              IS-A kapcsolatnál van polimorfizmus
    // Tervezési alapelvek
    // GOF1, GOF2
    // Gang of Four, Négyek bandája
    // GOF1: Programozz felületre megvalósítás helyett.
    //       Program to an interface, not an implementation. 
    // Praktikusan azt jelenti, hogy használd legősibb/legabsztraktabb típust típusként!
    //       VadászKutya k1 = new VadászKutya();
    //             Kutya k1 = new VadászKutya();        Ez felel meg a GOF1-nek.
    // GOF2: Öröklődés helyett használj objektum összetételt, hacsak lehet.
    //       Favor object composition over class inheritance.
    //       IS-A kapcsolat helyett használj HAS-A kapcsolatot, hacsak lehet.
    //       A Kutya és a gerince példát
    // SOLID - Az 5 legfontosabb alapelv Uncle Bob szerint
    // Agilis Programozás Kiáltványa - Agile Manifesto
    //  - Több kommunikáció a megrendelő
    //  - Elfogadjuk azt a tényt, hogy az igények álandóan változnak
    //  -> Legalább 2 oldalas esszé
    // Uncle Bob = Robert C. Martin
    //  - Tiszta Kód = Clean Code
    //  - Túlélőkönyv programozóknak = The Clean Coder
    // SRP    = Single Respansibility Principle = Egy felekősség elve
    //  OCP   = Open / Closed P.                = Nyitva-Zárt Alapelv
    //   LSP  = Liskov Substitution P.          = Liskov-féle Behelyettesítési Alapelv
    //    ISP = Interface Segregation P.        = Interfész Szegregációs Alapelv
    //     DIP= Dependency Injection P.         = Felelősség beinjektálásának elve
    // néhány kisebb
    // Az OCP praktikusan azt jelenti, hogy letesztelt, kiforott metódust ne írj felül,
    // ne változtass meg, mert a program többi része ezt használja!
    // Praktikusan ne használd az override kulcsszót, 
    //                     kivéve absztrakt és hook metódusok felülírására
    //             ne használ if - else if vagy switch szerkezeteket!
    // Alakzat példa:
    class Alakzat
    {
        const int HÁROMSZÖG = 1;  // a, b, c
        const int TÉGLALAP = 2;   // a, b
        const int NÉGYZET = 3;    // a
        const int NÉGYSZÖG = 4;   // a, b, c, d
        double a, b, c, d;
        int típus;
        public Alakzat(int típus) { this.típus = típus; }
        public void SetA(double a) { this.a = a; }
        public void SetB(double b) { this.b = b; }
        public void SetC(double c) { this.c = c; }
        public void SetD(double d) { this.d = d; }
        public double Kerület()
        {
            if (típus == HÁROMSZÖG) { return a + b + c; }
            else if (típus == TÉGLALAP) { return (a + b) * 2; }
            else if (típus == NÉGYZET) { return 4 * a; }
            else if (típus == NÉGYSZÖG) { return a + b + c + d; }
            else throw new Exception("Rossz típus érték!");
        }
    }
}
