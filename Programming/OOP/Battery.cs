using System;

public enum BatteryType
{
    LiIon, NiMH, NiCd, LiPoly
}

public class Battery
{


    private BatteryType type;
    private string model;
    private int? hoursTalk;
    private int? hoursStandBy;

    public BatteryType Type
    {
        get { return type; }
        set { type = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int? HoursTalk
    {
        get { return hoursTalk; }
        set { hoursTalk = value; }
    }

    public int? HoursStandBy
    {
        get { return hoursStandBy; }
        set { hoursStandBy = value; }
    }

    public Battery()
    {
        this.Model = null;
        this.HoursStandBy = null;
        this.HoursTalk = null;
    }

    public Battery(string model, int hoursTalk, int hoursStandBy, BatteryType type)
        : this()
    {

        this.Model = model;
        this.HoursStandBy = hoursStandBy;
        this.HoursTalk = hoursTalk;
        this.Type = type;
    }



}
