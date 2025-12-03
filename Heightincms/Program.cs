using System;
class Height
{
    static void Main()
    {
        Console.WriteLine("enter heights in inches:");
        double heightinInches = Convert.ToDouble(Console.ReadLine());
        double heightincm = heightinInches * 2.54;
        Console.WriteLine("Your height in cm:" + heightincm);
        if (heightincm < 150)
        {
            Console.WriteLine("Category Short");
        }
        else if (heightincm >= 150 && heightincm <= 170)
        {
            Console.WriteLine("Category Average");
        }
        else
            Console.WriteLine("Category Tall");

    
}
}
