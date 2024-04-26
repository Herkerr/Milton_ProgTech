using System;
public abstract class KávéStratégia
{
    public abstract void KávéFőzés(); // Abstract Method
}
public class GyengeKávé : KávéStratégia // Inheritance
{
    public override void KávéFőzés() // Abstract Methodot felülírhatunk
    {
        Console.WriteLine("Gyenge kávét főztél. Ha csak kicsit vagy fáradt.");
    }
}
public class NormalKávé : KávéStratégia
{
    public override void KávéFőzés()
    {
        Console.WriteLine("Normál kávét főztél. Egy átlagos napra.");
    }
}
public class ErősKávé : KávéStratégia
{
    public override void KávéFőzés()
    {
        Console.WriteLine("Egy erős kávé. A hosszú és fárasztó napokra.");
    }
}

public class KávéGép
{
    private KávéStratégia kávéStratégia;
    // Felelősség beinjektálása
    public void KávéValasztás(KávéStratégia k)
    {
        kávéStratégia = k; // Objektum-összetétel
    }
    public void KávéFőzés()
    {
        kávéStratégia.KávéFőzés();
    }
}
class Program
{
    static void Main(string[] args)
    {
        KávéGép automata = new KávéGép();
        automata.KávéValasztás(new GyengeKávé());   // Mi történik, ha ezeket megcseréljük?
        automata.KávéFőzés();                       // Mi történik, ha ezeket megcseréljük?
        automata.KávéValasztás(new ErősKávé());
        automata.KávéFőzés();
        automata.KávéValasztás(new NormalKávé());
        automata.KávéFőzés();
        Console.ReadLine();
    }
}









/* Válasz:
    automata.KávéFőzés();: Ez hívja meg a KávéFőzés() metódusát az automata KávéGép objectnek.
    Ezen a ponton a kávéStratégia még mindig null, mert a KávéValasztás() még nem lett meghívva.
    Ezáltal egy runtime errort: NullReferenceException-t fogunk kapni, mert nincs még stratégia.
*/