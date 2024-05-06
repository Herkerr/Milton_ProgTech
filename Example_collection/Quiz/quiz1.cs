// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

public class AdatBazisKapcsolat
{
    private static AdatBazisKapcsolat instance;

    private AdatBazisKapcsolat()
    {
        ConnectToSAP();
    }

    public static AdatBazisKapcsolat GetInstance()
    {
        if (instance == null)
        {
            instance = new AdatBazisKapcsolat();
        }
        return instance;
    }

    private void ConnectToSAP()
    {
        Console.WriteLine("Connecting to SAP system...");
        Console.WriteLine("Connection to SAP established.");
    }
}