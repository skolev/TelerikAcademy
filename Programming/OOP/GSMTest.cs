using System;

class GSMTest
{
    static void Main()
    {
        //Task 7 Display info and test
        Battery batt = new Battery("Samsung", 8, 42, BatteryType.LiIon);

        GSM[] phones = new GSM[2];

        phones[0] = new GSM("One", "HTC");
        phones[1] = new GSM("Galaxy S3", "Samsung", 1000, "Svetlio", batt, new Display(4.8f, 16000000));

        foreach (var tel in phones)
        {
            Console.WriteLine(tel);
        }

        Console.WriteLine(GSM.iPhone4S);

        //Task 12
        GSMCallHistoryTest test = new GSMCallHistoryTest();

        test.Test();

    }
}
