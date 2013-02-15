using System;

class StringArraySort
{
    //Sorts the given array.
    static void ArraySort(string[] str)
    {
        string temp = string.Empty;
        for (int index = 0; index < str.Length; index++)
        {
            //Puts the shortest array at given index.
            temp = str[index];
            for (int i = index + 1; i < str.Length; i++)
            {
                if (temp.Length > str[i].Length)
                {
                    str[index] = str[i];
                    str[i] = temp;
                    temp = str[index];
                }
            }
        }
        foreach (var word in str)
        {
            Console.WriteLine(word);
        }
    }
    static void Main()
        {
            //Some example.
            string[] words = { "aa", "aAaaa", "aaasAaa", "A" };
            //Another example
            //string[] words = {"Sofia", "Varna", "Plovdiv",
            //                  "Pleven", "Bourgas", "Rousse", "Yambol"};
            ArraySort(words);

        }
}
