// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public abstract class Laptop
{
    public string Model { get; set; }
    public abstract void DisplayInfo();
}

public class GamingLaptop : Laptop
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Model: {0} - Gaming Laptop", Model);
    }
}

public class BusinessLaptop : Laptop
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Model: {0} - Business Laptop", Model);
    }
}

public abstract class LaptopAssembly
{
    public abstract Laptop AssembleLaptop(string model);
}

public class GamingLaptopAssembly : LaptopAssembly
{
    public override Laptop AssembleLaptop(string model)
    {
        return new GamingLaptop { Model = model };
    }
}

public class BusinessLaptopAssembly : LaptopAssembly
{
    public override Laptop AssembleLaptop(string model)
    {
        return new BusinessLaptop { Model = model };
    }
}

class Program
{
    static void Main(string[] args)
    {
        LaptopAssembly gamingAssembly = new GamingLaptopAssembly();
        Laptop gamingLaptop = gamingAssembly.AssembleLaptop("GamingX");
        gamingLaptop.DisplayInfo();

        LaptopAssembly businessAssembly = new BusinessLaptopAssembly();
        Laptop businessLaptop = businessAssembly.AssembleLaptop("BusinessY");
        businessLaptop.DisplayInfo();
    }
}
