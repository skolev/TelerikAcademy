using System;



public class Battery
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, LiPoly
    }

    public BatteryType type;
    private int? hoursTalk;
    private int? hoursStandBy;

    public BatteryType Type
    {
        get { return type; }
        set { type = value; }
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
        this.HoursStandBy = null;
        this.HoursTalk = null;
    }
    public Battery(int hoursTalk, int hoursStandBy)
        : this()
    {
        this.Type = type;
        this.HoursStandBy = hoursStandBy;
        this.HoursTalk = hoursTalk;
    }



}
