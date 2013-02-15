using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Enter company website: ");
        string companyWebSite = @Console.ReadLine();
        Console.Write("Enter company manager firstname: ");
        string managerFN = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string managerLN = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager's number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();


        Console.WriteLine("{5} {6} is {7}. He works as a manager @ {0}.\n" +
                          "Company details:\nAddress: {1}\nTel: {2}\nFax: {3}\n" +
                          "Website: {4}\n" +
                          "You can always find {5} on this number: {8}",
        companyName, companyAddress, companyPhone, companyFax, companyWebSite, managerFN, managerLN, managerAge, managerPhone);
    }
}    

