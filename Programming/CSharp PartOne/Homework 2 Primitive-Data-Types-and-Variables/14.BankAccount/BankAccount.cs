using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Svetoslav";
        string midlleName = "Aleksandrov";
        string lastName = "Kolev";
        string holderName = firstName + midlleName + lastName;
        Console.WriteLine(holderName);
        decimal accountBalance = 825.40M;
        Console.WriteLine("Account balance: {0:C} ",accountBalance);
        string bankName = "ProcreditBank";
        Console.WriteLine("The name of the bank: " + bankName);
        string iban = "BG08PRCB12345678912345";
        Console.WriteLine("IBAN of the account:" + iban);
        string bic = "PRCBBGSF";
        Console.WriteLine("BIC: " + bic);
        ulong creditCard1 = 1234567812345678;
        ulong creditCard2 = 1234567890123456;
        ulong creditCard3 = 8765432187654321;
        Console.WriteLine("Three credit card numbers: {0}, {1}, {2}",creditCard1, creditCard2, creditCard3);
    }
}    

