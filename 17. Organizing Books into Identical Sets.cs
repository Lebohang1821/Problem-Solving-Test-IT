using System;
using System.Collections.Generic;

class OrganizeBooks
{
    static string CanOrganizeBooks(int[] shelf)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int book in shelf)
        {
            if (count.ContainsKey(book))
                count[book]++;
            else
                count[book] = 1;
        }

        foreach (var key in count.Keys)
        {
            if (count[key] < 2)
                return "NO";
        }

        return "YES";
    }

    static void Main()
    {
        int[] shelf = { 1234567, 1234567, 2345678, 2345678, 3456789, 3456789, 1234567, 2345678, 3456789, 4567890, 5678901, 5678901, 6789012, 6789012, 1234567, 2345678, 3456789, 4567890, 5678901, 4567890, 5678901 };
        string result = CanOrganizeBooks(shelf);
        Console.WriteLine(result); // Output: YES
    }
}