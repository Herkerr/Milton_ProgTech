using System;
abstract class Kacsa
{
    public abstract void Hápog();
    public abstract void Repül();
}
class SzépKacsa : Kacsa // Öröklődés
{
    HápogásiStratégia hs; // Objektum-összetétel
    RepülésiStratégia rs; // Objektum-összetétel
    public SzépKacsa(HápogásiStratégia hs, RepülésiStratégia rs)
    {
        this.hs = hs; // Felelőség beinjektálása
        this.rs = rs; // Felelőség beinjektálása
    }
    public override void Hápog()
    {
        hs.Hápog(); // Felelőség átadása a stratégiának, azaz delegáció
    }
    public override void Repül()
    {
        rs.Repül(); // Delegáció
    }
}

// Metódus kiemelése - Hápog
abstract class HápogásiStratégia
{
    public abstract void Hápog();
}
// Metódus kiemelése - Repül
abstract class RepülésiStratégia
{
    public abstract void Repül();
}
// Itt jönnek a konkrét repülési és hápogási stratégiák
class NormálHápogás : HápogásiStratégia // Öröklődés
{
    public override void Hápog()
    {
        Console.WriteLine("HápHáp");
    }
}
class RekedtHápogás : HápogásiStratégia // Öröklődés
{
    public override void Hápog()
    {
        Console.WriteLine("HákrrHákrrr");
    }
}
class NemRepül : RepülésiStratégia // Öröklődés
{
    public override void Repül()
    {
        Console.WriteLine("Nem tud repülni");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Kacsa donald =
        new SzépKacsa(
            new RekedtHápogás(), // felelőség beinjektálása
            new NemRepül() // felelőség beinjektálása
        );
        donald.Hápog(); // késői kötés miatt a RekedtHápogás-ból hívja
        donald.Repül(); // késői kötés miatt a NemRepül-ből hívja
        Console.ReadLine();
    }
}