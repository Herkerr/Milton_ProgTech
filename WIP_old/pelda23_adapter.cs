// Interface for a generic payment gateway
public interface IPaymentGateway
{
    void ProcessPayment(double amount);
}

// Adapter for PayPal payment gateway
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

// Adapter for Stripe payment gateway
public class StripeAdapter : IPaymentGateway
{
    private StripeGateway stripeGateway;

    public StripeAdapter(StripeGateway stripeGateway)
    {
        this.stripeGateway = stripeGateway;
    }

    public void ProcessPayment(double amount)
    {
        // Call the corresponding method in the StripeGateway API
        stripeGateway.Charge(amount);
    }
}

// Adapter for Square payment gateway
public class SquareAdapter : IPaymentGateway
{
    private SquareGateway squareGateway;

    public SquareAdapter(SquareGateway squareGateway)
    {
        this.squareGateway = squareGateway;
    }

    public void ProcessPayment(double amount)
    {
        // Call the corresponding method in the SquareGateway API
        squareGateway.CreatePayment(amount);
    }
}

// Mock classes for PayPal, Stripe, and Square gateways
public class PayPalGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }
}

public class StripeGateway
{
    public void Charge(double amount)
    {
        Console.WriteLine($"Charging ${amount} using Stripe");
    }
}

public class SquareGateway
{
    public void CreatePayment(double amount)
    {
        Console.WriteLine($"Creating payment of ${amount} using Square");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Initialize adapters for different payment gateways
        var paypalAdapter = new PayPalAdapter(new PayPalGateway());
        var stripeAdapter = new StripeAdapter(new StripeGateway());
        var squareAdapter = new SquareAdapter(new SquareGateway());

        // Process payments using the adapters
        paypalAdapter.ProcessPayment(100.00);
        stripeAdapter.ProcessPayment(150.00);
        squareAdapter.ProcessPayment(200.00);
    }
}


// Diffi:
    // MakePayment
    // Charge
    // CreatePayment