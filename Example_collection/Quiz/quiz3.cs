// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public class Csoki
{
    public string Type { get; set; }
    public int Weight { get; set; }

    private Csoki(string type, int weight)
    {
        Type = type;
        Weight = weight;
    }

    public static Csoki CreateCsoki(string type, int weight)
    {
        return new Csoki(type, weight);
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Csoki csoki1 = Csoki.CreateCsoki("Fehércsoki", 100);
            Csoki csoki2 = Csoki.CreateCsoki("Tejcsoki", 200);

            Console.WriteLine("Csoki 1: Type = {0}, Weight = {1}g", chocolate1.Type, chocolate1.Weight);
            Console.WriteLine("Csoki 2: Type = {0}, Weight = {1}g", chocolate2.Type, chocolate2.Weight);
        }
    }
}