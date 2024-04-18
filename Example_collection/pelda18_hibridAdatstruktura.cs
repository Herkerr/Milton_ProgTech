using System;

public class Auto
{
    // Attribútumok
    public string Model { get; }
    public string Szin { get; }
    public int Evjarat { get; }

    // Konstruktor
    public Car(string model, string color, int year)
    {
        Model = model;
        Szin = color;
        Evjarat = year;
    }

    // Viselkedés
    public void Start()
    {
        Console.WriteLine($"Indítjuk a {Model} {Szin} {Evjarat} autónkat.");
    }

    public void Gaz()
    {
        Console.WriteLine($"Felgyorsítjuk a {Model} {Szin} {Evjarat} autónkat.");
    }

    public void Fek()
    {
        Console.WriteLine($"Lefékezzük a {Model} {Szin} {Evjarat} autónkat.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Auto myAuto = new Car("Ford Mustang", "Blue", 2022);
        myAuto.Start();
        myAuto.Gaz();
        myAuto.Fek();
    }
}