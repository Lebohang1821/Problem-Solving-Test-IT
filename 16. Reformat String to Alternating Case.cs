using System;
using System.Text;

class ReformatString
{
    static string AlternateCase(string s)
    {
        StringBuilder result = new StringBuilder();
        bool toggle = true;

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                if (toggle)
                    result.Append(char.ToUpper(c));
                else
                    result.Append(char.ToLower(c));
                toggle = !toggle;
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        string input = "Za^B8g@E2jH*kW!!MopqXr7YvT1c5Fs3Ud9TwZ8yXOpLkV6sHqN^tB4rA+oZ%gFj";
        string output = AlternateCase(input);
        Console.WriteLine(output);
    }
}