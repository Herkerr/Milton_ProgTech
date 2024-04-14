using System;

// Telefonunk felülete
interface IPhone
{
    string GetDescription();
}

// Alap Telefon osztály
class BasicPhone : IPhone
{
    public string GetDescription()
    {
        return "Mobiltelefon";
    }
}

// Tartozékok felülete
interface IAccessory
{
    string GetDescription();
}

// Decoratorok
class Tok : IAccessory
{
    private readonly IPhone phone;

    public Tok(IPhone phone)
    {
        this.phone = phone;
    }

    public string GetDescription()
    {
        return $"{phone.GetDescription()}, szilikon tokkal";
    }
}

class Folia : IAccessory
{
    private readonly IPhone phone;

    public Folia(IPhone phone)
    {
        this.phone = phone;
    }

    public string GetDescription()
    {
        return $"{phone.GetDescription()}, kijelzővédő fóliával";
    }
}

// Használat
class Program
{
    static void Main(string[] args)
    {
        IPhone phone = new BasicPhone();
        // Kiegészítők
        IAccessory telefonTokkal = new Tok(phone);
        IAccessory telefonFoliaval = new Folia(phone);
        IAccessory telefonTokkalFoliaval = new Folia(new Tok(phone)); // Mindkettőt is kombinálhatjuk

        Console.WriteLine(telefonTokkal.GetDescription());
        Console.WriteLine(telefonFoliaval.GetDescription());
        Console.WriteLine(telefonTokkalFoliaval.GetDescription());
    }
}