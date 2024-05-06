// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public abstract class OrderProcessor
{
    public void ProcessOrder()
    {
        SelectItems();
        ApplyDiscount();
        CalculateTotal();
        ConfirmOrder();
    }

    protected abstract void SelectItems();
    protected abstract void ApplyDiscount();
    protected abstract void CalculateTotal();

    protected virtual void ConfirmOrder()
    {
        Console.WriteLine("Order confirmed. Thank you for shopping with us!");
    }
}

public class OnlineOrderProcessor : OrderProcessor
{
    protected override void SelectItems()
    {
        Console.WriteLine("Selecting items for online order...");
    }

    protected override void ApplyDiscount()
    {
        Console.WriteLine("Applying online discount...");
    }

    protected override void CalculateTotal()
    {
        Console.WriteLine("Calculating total for online order...");
    }

    protected override void ConfirmOrder()
    {
        Console.WriteLine("Online order confirmed. Check your email for order details.");
    }
}

public class InStoreOrderProcessor : OrderProcessor
{
    protected override void SelectItems()
    {
        Console.WriteLine("Selecting items for in-store order...");
    }

    protected override void ApplyDiscount()
    {
        Console.WriteLine("Applying in-store discount...");
    }

    protected override void CalculateTotal()
    {
        Console.WriteLine("Calculating total for in-store order...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Processing online order:");
        OrderProcessor onlineOrderProcessor = new OnlineOrderProcessor();
        onlineOrderProcessor.ProcessOrder();

        Console.WriteLine();

        Console.WriteLine("Processing in-store order:");
        OrderProcessor inStoreOrderProcessor = new InStoreOrderProcessor();
        inStoreOrderProcessor.ProcessOrder();
    }
}
