using System;

class Bank{
	private int balance;
	//get is used inside a property
    public int Balance
	{
		//readonly access
		get { return balance; }
	}

	public void deposit(int amount)
	{
		if (amount > 0)
		{
			balance = balance + amount;
			Console.WriteLine($"Deposit:{amount} and balance {balance}");
		}
		else
		{
			Console.WriteLine("Enter valid amount");
		}
	}

	public void withdraw(int amount)
	{
		if(amount>=0 && amount <= balance)
		{
			balance = balance - amount;
			Console.WriteLine($"Withdraw:{amount} and balance {balance}");
		}
		else
		{
			Console.WriteLine("Insufficient balance");
		}
	}
}


class Program
{
	static void Main()
	{
		Bank account = new Bank();
		account.deposit(10000);
		account.withdraw(2000);
		account.withdraw(200);
		Console.WriteLine($"balance {account.Balance}");

	}
}