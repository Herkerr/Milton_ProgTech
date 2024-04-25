using System;

// Egyszerű számolás változóihoz alkalmazott interface-ünk
public interface ISzamologep
{
    int Szamitas(int a, int b);
}

// Összeadás
public class Osszead : ISzamologep
{
    public int Szamitas(int a, int b)
    {
        return a + b;
    }
}
// Kivonás
public class Kivon : ISzamologep
{
    public int Szamitas(int a, int b)
    {
        return a - b;
    }
}
// Szorzás
public class Szoroz : ISzamologep
{
    public int Szamitas(int a, int b)
    {
        return a * b;
    }
}
// Osztás
// Töltsük ki



// Naplózás Decorator
public class LogDecorator : ISzamologep
{
    private readonly ISzamologep _szamitas;

    public LogDecorator(ISzamologep szamitas)
    {
        _szamitas = szamitas;
    }

    public int Szamitas(int a, int b)
    {
        Console.WriteLine($"Log: A számológép {_szamitas.GetType().Name} az alábbi értékekkel: {a} és {b}");
        var result = _szamitas.Szamitas(a, b);
        Console.WriteLine($"Log: {_szamitas.GetType().Name} számítás eredménye {result}");
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Számítások példányosítása
        ISzamologep Osszead = new Osszead();
        ISzamologep Kivon = new Kivon();
        ISzamologep Szoroz = new Szoroz();
        // Osztást is példányosítsuk

        // Decorator-ok
        Osszead = new LogDecorator(Osszead);
        Kivon = new LogDecorator(Kivon);
        Szoroz = new LogDecorator(Szoroz);
        // Osztást is vegyük fel

        // Számítások elvégzése
        int resultOsszead = Osszead.Szamitas(5, 3);
        int resultKivon = Kivon.Szamitas(10, 4);
        int resultSzoroz = Szoroz.Szamitas(7, 2);
        // Osztásra is írjunk példát
    }
}

// Logjaink így fognak kinézni:
    // Log: A számológép Osszead az alábbi értékekkel: 5 és 3
    // Log: Osszead számítás eredménye: 8
















/*
    if (b == 0)
    throw new ArgumentException("Divisor cannot be zero.");
    return a / b;
*/