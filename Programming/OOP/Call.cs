using System;

public class Call
{
    private DateTime? callDate;
    private string dialedNums;
    public ulong? callDuration;

    public DateTime? CallDate
    {
        get { return callDate; }
        set { this.callDate = value; }
    }

    public string DialedNums
    {
        get { return dialedNums; }
        set { dialedNums = value; }
    }

    public ulong? CallDuration
    {
        get { return callDuration; }
        set { callDuration = value; }
    }

    public Call()
    {
        this.dialedNums = null;
        this.callDuration = null;
        this.callDate = DateTime.Now;
    }
    public Call(ulong callDuration)
        : this()
    {
        this.CallDuration = callDuration;
    }

    public Call(ulong callDuration, string dialedNums)
        : this(callDuration)
    {
        this.DialedNums = dialedNums;
    }

    public override string ToString()
    {
        return string.Format("Duration of call: {0} s, Dialed number: {1}, Date and Time of calling: {2} ",
                      this.callDuration, this.dialedNums, this.callDate);
    }
}
