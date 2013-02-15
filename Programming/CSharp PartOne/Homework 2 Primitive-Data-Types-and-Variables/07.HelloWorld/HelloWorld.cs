using System;

class HelloWorld
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object someObject = (firstString + " " + secondString);
        string thirdString = (string)someObject;
        Console.WriteLine(thirdString);
    }
}    


