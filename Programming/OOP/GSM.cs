using System;
using System.Collections.Generic;

public class GSM
{
    private string model;
    private string manufacturer;
    private decimal? price;
    private string owner;
    private Battery myBattery = new Battery();
    private Display myDisplay = new Display();
    private List<Call> calls = new List<Call>();
    const decimal PricePerMinute = 0.37m;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }
    public decimal? Price
    {
        get { return price; }
        set { price = value; }
    }
    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    public Battery MyBattery
    {
        get { return myBattery; }
        set { myBattery = value; }
    }

    public Display MyDisplay
    {
        get { return myDisplay; }
        set { myDisplay = value; }
    }

    public GSM(string model, string manufacturer)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
    }

    public GSM(string model, string manufacturer, decimal price)
        : this(model, manufacturer)
    {
        this.Price = price;
    }

    public GSM(string model, string manufacturer, decimal price, string owner)
        : this(model, manufacturer, price)
    {
        this.Owner = owner;
    }

    public GSM(string model, string manufacturer, decimal price, string owner, Battery myBattery)
        : this(model, manufacturer, price, owner)
    {
        this.MyBattery= myBattery;
    }
    public GSM(string model, string manufacturer, decimal price, string owner, Battery myBattery, Display myDisplay)
        : this(model, manufacturer, price, owner, myBattery)
    {
        this.MyDisplay = myDisplay;
    }

    //Displays all info, override ToString()
    public override string ToString()
    {
        return string.Format("Model: {0}, Manufacturer: {1}, Price: {2}, Owner: {3}" + 
                             "Battery type: {4}, Battery standby: {5}, Battery hours to talk: {6} " + 
                             "Screen size: {7}, Number of colors:{8} ",
                      this.Model, this.Manufacturer, this.Price, this.Owner, this.MyBattery.Type, 
                      this.MyBattery.HoursStandBy, this.MyBattery.HoursTalk, this.MyDisplay.DisplaySize, this.MyDisplay.NumberOfColors);
    }

    // Static field and property for iPhone4S
    public static GSM iPhone4S = new GSM("Iphone4S", "Apple", 1500, "Svetlio", new Battery("Apple", 0, 0, BatteryType.LiIon), new Display(3.5f, 16000000));

    public GSM IPhone4S
    {
        get { return GSM.iPhone4S; }
        private set { }
    }

    public List<Call> CallHistory
    {
        get { return calls; }
        set { this.calls = value; }
    }

    //Add call to history & and set the index of the longest call.
    public void AddCall(Call call)
    {
        this.calls.Add(call);

        ulong? longestCall = ulong.MinValue;

        for (int index = 0; index < calls.Count; index++)
        {
            if (calls[index].callDuration > longestCall)
            {
                longestCall = calls[index].callDuration;
            }
        }

    }
    //Remove call from history
    public void RemoveCall(Call call)
    {
        this.calls.Remove(call);
    }
    public void ClearCalls()
    {
        this.calls.Clear();
    }

    //Calculate price of all calls
    public decimal CallsPrice()
    {
        decimal minutes = 0;
        decimal price = 0m;

        foreach (var seconds in calls)
        {
            minutes += Math.Ceiling((decimal)(seconds.CallDuration) / 60);
        }

        return price = minutes * PricePerMinute;
    }
}

