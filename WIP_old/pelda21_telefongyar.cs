using System;
using System.Collections.Generic;

// Telefon osztály
public class Telefon
{
    // Funkcionalitás és egyedi tulajdonságok
    private string szin;
    // Egyedi tulajdonságok, pl. szín
    public string Szin { get { return szin; } }

    // Konstruktor
    public Telefon(string szin)
    {
        this.szin = szin;
    }

    // SetSzín metódus
    public void SetSzin(string szin)
    {
        this.szin = szin;
    }

    // Clone metódus
    public Telefon Clone()
    {
        // Mélységi klónozás (deep copy)
        return new Telefon(this.szin);
    }
}

// TelefonGyár osztály
public class TelefonGyar
{
    private Telefon prototipus;

    // SetPrototipus metódus
    public void SetPrototipus(Telefon prototipus)
    {
        this.prototipus = prototipus;
    }

    // Gyárt metódus
    public List<Telefon> Gyart(string szin, int mennyiseg)
    {
        List<Telefon> gyartottTelefonok = new List<Telefon>();
        for (int i = 0; i < mennyiseg; i++)
        {
            // Prototípus klónozása
            Telefon telefon = prototipus.Clone();
            // Szín beállítása
            telefon.SetSzin(szin);
            gyartottTelefonok.Add(telefon);
        }
        return gyartottTelefonok;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Telefon létrehozása
        Telefon telefonMinta = new Telefon("Fekete");

        // TelefonGyár létrehozása
        TelefonGyar gyar = new TelefonGyar();
        gyar.SetPrototipus(telefonMinta);

        // Gyártás a prototípus alapján
        List<Telefon> kekTelefonok = gyar.Gyart("Kék", 10);
        List<Telefon> pirosTelefonok = gyar.Gyart("Piros", 5);

        // Ellenőrzés
        Console.WriteLine("Kék telefonok:");
        foreach (var telefon in kekTelefonok)
        {
            Console.WriteLine($"Szin: {telefon.Szin}");
        }

        Console.WriteLine("\nPiros telefonok:");
        foreach (var telefon in pirosTelefonok)
        {
            Console.WriteLine($"Szin: {telefon.Szin}");
        }
    }
}
