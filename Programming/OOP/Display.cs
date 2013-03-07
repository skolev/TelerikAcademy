using System;

public class Display
{
    private float? displaySize;
    private ulong? numberOfColors;


    public float? DisplaySize
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

    public Display(float displaySize)
        : this()
    {
        this.DisplaySize = displaySize;
    }
    public Display(float displaySize, ulong numberOfColors)
        : this(displaySize)
    {
        this.NumberOfColors = numberOfColors;
    }


}
