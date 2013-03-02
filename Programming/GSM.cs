using System;

public class GSM
{
    private string model;
    private string manufacturer;
    private decimal price;
    private string owner;
    private static Battery myBattery = new Battery();
    private static Display myDisplay = new Display();

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
    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }
    public string Owner
    {
        get { return owner; }
        set { owner = value; }
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
}

