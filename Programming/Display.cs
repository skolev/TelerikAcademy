using System;

public class Display
{
    private decimal? displaySize;
    private ulong? numberOfColors;


    public decimal? DisplaySize
    {
        get { return displaySize; }
        set { displaySize = value; }
    }

    public ulong? NumberOfColors
    {
        get { return numberOfColors; }
        set { numberOfColors = value; }
    }

    public Display()
    {
        this.DisplaySize = null;
        this.NumberOfColors = null;
    }


}
