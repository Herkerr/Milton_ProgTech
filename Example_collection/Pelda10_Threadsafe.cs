using System;

namespace SingletonThreadSafe
{
    public sealed class Singleton
    {
        // A statikus konstruktor akkor fut le, amikor az osztályt példányosítjuk,
        // vagy statikus tagra hivatkozunk ÉS egy Application Domain alatt
        // (értsd: adott program futásakor) maximum egyszer futhat le.
        private static readonly Singleton instance = new Singleton();
        // privát konstruktor külső 'new' példányosítás ellen
        private Singleton() { }
        // statikus konstruktor
        // Azon osztályok, melyek nem rendelkeznek statikus
        // konstruktorral beforefieldinit attribútumot
        // kapnak az IL kódban. A statikus tagok inicializációja
        // a program kezdetén azonnal megtörténik.
        // Az olyan osztályok, amelyeknek van statikus konstruktora
        // ezt nem kapják meg,
        // ezért a statikus tagok akkor példányosulnak,
        // amikor először hivatkozunk az osztályra,
        // vagyis jelen esetben amikor elkérjük a példányt.
        static Singleton() { }
        public static Singleton Instance { get{ return instance; } }
    }
    class Program
    {
        static void Main(string[] args)
            {
                Singleton s1 = Singleton.Instance;
                Singleton s2 = Singleton.Instance;
                if (s1 == s2) { Console.WriteLine("OK"); }
                Console.ReadKey();
            }
    }
}