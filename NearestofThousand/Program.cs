using System;
class NearestOfThousand {
    static void Main()
    {
        Console.WriteLine("enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int nearestThousand = (int)(Math.Round(number / 1000.0) * 1000);
        Console.WriteLine("Nearest Thousand:" +nearestThousand );
    }

}

