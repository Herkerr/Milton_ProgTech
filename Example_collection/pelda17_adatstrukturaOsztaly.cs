public class Ember
{
    public string Nev { get; }
    public int Kor { get; }

    public Person(string neve, int kora)
    {
        Nev = neve;
        Kor = kora;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ember ember1 = new Ember("János", 30);
        Console.WriteLine($"Név: {ember1.Nev}, Kor: {ember1.Kor}");
    }
}