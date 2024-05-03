public void AdatFeldolgozo(int ertek)
{
    if (ertek > 10)
    {
        if (ertek < 100)
        {
            Console.WriteLine("Az érték valid.");
        }
        else
        {
            Console.WriteLine("A megadott érték túl magas.");
        }
    }
    else
    {
        Console.WriteLine("A megadott érték túl alacsony.");
    }
}