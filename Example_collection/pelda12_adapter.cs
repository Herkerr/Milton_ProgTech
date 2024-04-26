using System;

abstract class Ember // Ember osztály
{
    public abstract string GetNév();
    public abstract int GetIQ();
}

// ADAPTEE
class Robot // Robot osztály
{
    string ID;
    int memory; //memoria MB-ban megadva
    public Robot(string ID, int memory)
    {
        this.ID = ID;
        this.memory = memory;
    }
    public string GetID() { return ID; }
    public int GetMemory() { return memory; }
}

// ADAPTER
class Robot2Ember : Ember // Ember osztályhierarchiába illesztés
// X to Y elnevezési konvenció!
{
    Robot robi;
    public Robot2Ember(Robot robi) { this.robi = robi; }
    public override string GetNév()
    {
        return robi.GetID();
    }
    public override int GetIQ()
    {
        return robi.GetMemory() / 1024; // 1GB memória = 1 IQ
    }
}

// Program példa
class Program
{
    static void Main(string[] args)
    {
        Robot R2D2 = new Robot("R2D2", 80000); // 80000 MB memóriát adtunk neki
        Ember R2D2wrapper = new Robot2Ember(R2D2); // R2D2 becsomaglása
        Console.WriteLine("Neve: {0}", R2D2wrapper.GetNév()); // Adapter metódusait meghívjuk
        Console.WriteLine("IQ-ja: {0}", R2D2wrapper.GetIQ()); // Ember "IQ-t" számítunk memória alapján, ezáltal az IQ kérdésnél robotot is tudunk "emberként" használni
        Console.ReadLine();
    }
}