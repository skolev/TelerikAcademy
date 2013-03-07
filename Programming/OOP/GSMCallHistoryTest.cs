using System;
using System.Collections.Generic;

public class GSMCallHistoryTest
{
    public void Test()
    {
        GSM myPhone = new GSM("Galaxy S3", "Samsung");

        Call call1 = new Call(60, "*88");
        Call call2 = new Call(360, "+359887123456");
        Call call3 = new Call(20, "+35921234567");

        myPhone.CallHistory.Add(call1);
        myPhone.CallHistory.Add(call2);
        myPhone.CallHistory.Add(call3);

        ulong? longestCall = ulong.MinValue;
        int callIndex = 0;

        for (int index = 0; index < myPhone.CallHistory.Count; index++)
        {
            if (myPhone.CallHistory[index].callDuration > longestCall)
            {
                callIndex = index;
                longestCall = myPhone.CallHistory[index].callDuration;
            }
        }
        foreach (var call in myPhone.CallHistory)
        {
            Console.WriteLine(call);
        }

        Console.WriteLine(myPhone.CallsPrice());

        myPhone.CallHistory.RemoveAt(callIndex);

        Console.WriteLine(myPhone.CallsPrice());

        myPhone.ClearCalls();

        Console.WriteLine(myPhone.CallsPrice());



    }
}

