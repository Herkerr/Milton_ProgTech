// Általános payment Gateway-ünk interfésze
public interface IPaymentGateway
{
    void ProcessPayment(double amount);
}

// PayPal adapter
public class PayPalAdapter : IPaymentGateway
{
    private PayPalGateway paypalGateway;

    public PayPalAdapter(PayPalGateway paypalGateway)
    {
        this.paypalGateway = paypalGateway;
    }

    public void ProcessPayment(double amount)
    {
        // Call the corresponding method in the PayPalGateway API
        paypalGateway.MakePayment(amount);
    }
}

// Barion Adapter
public class BarionAdapter : IPaymentGateway
{
    private BarionGateway barionGateway;

    public BarionAdapter(BarionGateway barionGateway)
    {
        this.barionGateway = barionGateway;
    }

    public void ProcessPayment(double amount)
    {
        // Barion API metódushívása
        barionGateway.Charge(amount);
    }
}

// Simple Adapter
public class SimpleAdapter : IPaymentGateway
{
    private SimpleGateway simpleGateway;

    public SimpleAdapter(SimpleGateway simpleGateway)
    {
        this.simpleGateway = simpleGateway;
    }

    public void ProcessPayment(double amount)
    {
        // Simple API metódushívása
        simpleGateway.CreatePayment(amount);
    }
}

// Mock osztályok a PayPal, Barion és Simple gateway-ekhez
public class PayPalGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"PayPal fizetés feldolgozása ${amount} összegben.");
    }
}

public class BarionGateway
{
    public void Charge(double amount)
    {
        Console.WriteLine($"Barion terhelés ${amount} összegben.");
    }
}

public class SimpleGateway
{
    public void CreatePayment(double amount)
    {
        Console.WriteLine($"Simple fizetés ${amount} összegben.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Adapterek példányosítása a különböző gateway-ekhez
        var paypalAdapter = new PayPalAdapter(new PayPalGateway());
        var barionAdapter = new BarionAdapter(new BarionGateway());
        var simpleAdapter = new SimpleAdapter(new SimpleGateway());

        // Tranzakciók feldolgozása adaptereken keresztül
        paypalAdapter.ProcessPayment(100.00);
        barionAdapter.ProcessPayment(100.00);
        simpleAdapter.ProcessPayment(100.00);
    }
}


// Diffi:
    // MakePayment
    // Charge
    // CreatePayment