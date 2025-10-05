using System;
public interface IPayment
{
    void Pay(double amount);
}
public class CreditCardPayment:IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card");
    }
}
public class UPIPayment:IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using UPI");
    }
}
public class NetBankingPayment:IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using NetBanking");
    }
}
public static class PaymentFactory
{
    public static IPayment GetPaymentMethod(string type)
    {
        return type.ToLower() switch
        {
            "creditcard" => new CreditCardPayment(),
            "upi" => new UPIPayment(),
            "netbanking" => new NetBankingPayment(),
            _ => throw new ArgumentException("Invalid Payment Method")
        };
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter payment method (CreditCard/UPI/NetBanking):");
        string method = Console.ReadLine();
        IPayment payment = PaymentFactory.GetPaymentMethod(method);
        payment.Pay(500.00); 
    }
}
