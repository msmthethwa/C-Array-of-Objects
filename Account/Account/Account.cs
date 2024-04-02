using System;

/*Design a C# program for a bank account management system. 
 * Create a class Account with properties AccountNumber (string) and Balance (double).*/

class Account {
    private string AccountNumber;
    private double Balance;

    public Account(string number, double balance)
    {
        AccountNumber = number;
        Balance = balance;
    }

    public string getAccountNumber() { 
        return AccountNumber;
    }
    public double getBalance() { 
        return Balance;
    }

    public void setAccountNumber(string accountNumber)
    {
       AccountNumber = accountNumber;
    }
    public void setBalance(double balance) { 
        Balance = balance;
    }

    public string toString()
    {
        return "Account number: " + AccountNumber + "\nBalance: R" + Balance;
    }
}