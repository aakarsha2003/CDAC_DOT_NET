using System;
class TypeConversion
{
    static void Main()
    {
        Console.WriteLine("===Type Conversion Demo===");

        int num = 10;
        double doublevalue = num;
        Console.WriteLine("Implicit Conversion (int->double):" + doublevalue);

        double price = 99.75;
        int intPrice = (int)price;
        Console.WriteLine("explicit Conversion(double->int):" + intPrice);

        string strNumber = "123";
        int convertedNumber = Convert.ToInt32(strNumber);
        Console.WriteLine("Convert.ToInt32(string->int):" + convertedNumber);

        int value = 50;
        string stringValue = value.ToString();
        Console.WriteLine("ToString())int->string:" + stringValue);

        char letter = 'A';
        int ascii = (int)letter;
        Console.WriteLine("char->ASCII int:" + ascii);

        bool isActive = true;
        string boolString = isActive.ToString();
        Console.WriteLine("bool->string" + boolString);


    }
}

