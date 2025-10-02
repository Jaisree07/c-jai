using System;

public class Payment
{
    public void Pay(string cardNumber, string expiry, string cvv)
    {
        Console.WriteLine("Credit Card Payment");
    }
    public void Pay(string upiId)
    {
        Console.WriteLine("UPI Payment");
    }
    public void Pay(decimal amount, bool cash)
    {
        Console.WriteLine("Cash Payment");
    }
}

public class App
{
    public static void Main()
    {
        Payment payment = new Payment();
        payment.Pay("1234-5678", "09/25", "1234");
        payment.Pay("jai@upi");
        payment.Pay(1000.00m, true);
    }
}
