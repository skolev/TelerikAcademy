using System;

class EmployeeInformation
{
    static void Main()
    {
        string firstName = "Svetoslav";
        string lastName = "Kolev";
        byte employeeAge = 25;
        char employeeSex = 'M';
        int idNumber = 2751914;
        Console.WriteLine("Employee information:");
        Console.WriteLine("Name: {0} {1}",firstName, lastName);
        Console.WriteLine("Age: {0}\nSex: {1}\nID Number: {2}", employeeAge, employeeSex, idNumber);
    }
}    

