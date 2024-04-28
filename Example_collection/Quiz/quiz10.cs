// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public interface IDiscount
{
    double CalculateDiscount(double totalPrice);
}

public class RegularCustomerDiscount : IDiscount
{
    public double CalculateDiscount(double totalPrice)
    {
        return totalPrice * 0.05;
    }
}

public class PrimeCustomerDiscount : IDiscount
{
    public double CalculateDiscount(double totalPrice)
    {
        return totalPrice * 0.10;
    }
}

public class ShoppingCart
{
    private readonly IDiscount discountType;

    public ShoppingCart(IDiscount discountType)
    {
        this.discountType = discountType;
    }

    public double CalculateTotalPrice(double totalPrice)
    {
        double discountAmount = discountType.CalculateDiscount(totalPrice);
        return totalPrice - discountAmount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart regularCustomerCart = new ShoppingCart(new RegularCustomerDiscount());
        double regularCustomerTotalPrice = 100.0;
        double regularCustomerTotalPriceAfterDiscount = regularCustomerCart.CalculateTotalPrice(regularCustomerTotalPrice);
        Console.WriteLine("Total price for regular customer: $" + regularCustomerTotalPriceAfterDiscount);

        ShoppingCart primeCustomerCart = new ShoppingCart(new PrimeCustomerDiscount());
        double primeCustomerTotalPrice = 100.0;
        double primeCustomerTotalPriceAfterDiscount = primeCustomerCart.CalculateTotalPrice(primeCustomerTotalPrice);
        Console.WriteLine("Total price for prime customer: $" + primeCustomerTotalPriceAfterDiscount);
    }
}
