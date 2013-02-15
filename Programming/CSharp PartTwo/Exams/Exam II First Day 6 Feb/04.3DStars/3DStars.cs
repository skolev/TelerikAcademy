using System;

class Program
{
    static void Main()
    {
        char[] separators = new char[]{' '};
        string size = Console.ReadLine();
        string[] dimensions = size.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int width = int.Parse(dimensions[0]);
        int height = int.Parse(dimensions[1]);
        int depth = int.Parse(dimensions[2]);
        char[,,] star = new char[height, width, depth];
        int[] letters = new int[91];
        int stars = 0;
        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine();
            string[] sybmols = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    star[h, w, d] = sybmols[d][w];
                }
            }
            
        }
        for (int h = 1; h < height - 1; h++)
        {
            for (int d = 1; d < depth - 1; d++)
            {
                for (int w = 1; w < width - 1; w++)
                {
                    if (star[h, w, d] == star[h + 1, w, d] && star[h, w, d] == star[h - 1, w, d] && star[h, w, d] == star[h, w + 1, d] &&
                        star[h, w, d] == star[h, w - 1, d] && star[h, w, d] == star[h, w, d + 1] && star[h, w, d] == star[h, w, d - 1])
                    {
                        letters[star[h, w, d]]++;
                    }
                }
            }

        }
        for (int index = 65; index < letters.Length; index++)
        {
            stars += letters[index];
        }
        Console.WriteLine(stars);
        if (stars != 0)
        {
            for (int i = 65; i < letters.Length; i++)
            {
                if (letters[i] != 0)
                {
                    Console.WriteLine((char)i + " " + letters[i]);
                }
            }
        }

    }
}
