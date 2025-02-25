// Task 3: Bank Account
// Task: Create a BankAccount class with:
// AccountNumber, HolderName, Balance.
// Methods Deposit(amount) and Withdraw(amount), ensuring balance never goes negative.
// In Main(), allow the user to create an account and perform deposits/withdrawals.
// Prevent withdrawal if insufficient funds and show an error message.

using System;
class BankAccount {
    public int AccountNumber {get; set;}
    public string HolderName {get; set;}
    public int Balance {get; set;}

    static int ID = 1;

    public BankAccount (string holdername) {
        AccountNumber = ID++;
        HolderName = holdername;
        Balance = 0;
    }
    public void Deposit (int amount) {
        Balance += amount;
    }
    public void withdrow (int amount) {
        if (amount < 0) {
            Console.WriteLine ("Invalide argument");
            return;
        }
        else if (amount > Balance) {
            Console.WriteLine ("Insufficient funds");
            return;
        }

        Balance -= amount;
    }

} 
class Program {
    static void Main(string[] args) {

    Console.Write ("Please Enter Your Holder Number ");
    string Name = Console.ReadLine ();
    BankAccount Custumer1 = new BankAccount(Name);
    Console.Write ("Please Enter Your Holder Number ");
    Name = Console.ReadLine ();
    BankAccount Custumer2 = new BankAccount (Name);
    
    Custumer1.Deposit (100);
    Custumer2.Deposit (100);
    Custumer1.withdrow (50);
    Console.WriteLine ($"The  Balance is {Custumer1.Balance} \nAccount number is {Custumer1.AccountNumber}");



    
    

    }
}