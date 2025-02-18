using System;

class MagicPotion
{
    static string IsMagicalPotion(long power)
    {
        long cubeRoot = (long)Math.Round(Math.Pow(power, 1.0 / 3.0));
        if (cubeRoot * cubeRoot * cubeRoot == power)
            return "YES";
        else
            return "NO";
    }

    static void Main()
    {
        long power = 132651201231;
        Console.WriteLine(IsMagicalPotion(power));
    }
}