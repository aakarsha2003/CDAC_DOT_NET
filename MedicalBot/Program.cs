using System;

class MedicalBot
{
    static void Main()
    {
        Console.WriteLine("Welcome to Medical Bot - Bob");

        // Get patient details
        Console.Write("Enter patient's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter patient's age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter symptom (fever/cold/headache/cough): ");
        string symptom = Console.ReadLine().ToLower();

        Console.WriteLine("\n--- Medical Bot Bob's Prescription ---");

        // Decision based on symptom and age
        if (symptom == "fever")
        {
            if (age < 12)
                Console.WriteLine("Prescription: KidsFeverRelief Syrup - 5ml twice a day (Fictional)");
            else
                Console.WriteLine("Prescription: FeverAway Tablet - 1 tablet twice a day (Fictional)");
        }
        else if (symptom == "cold")
        {
            if (age < 12)
                Console.WriteLine("Prescription: ColdCare Junior Drops - 3 drops thrice a day (Fictional)");
            else
                Console.WriteLine("Prescription: ColdCure Capsule - 1 capsule daily (Fictional)");
        }
        else if (symptom == "headache")
        {
            if (age < 12)
                Console.WriteLine("Prescription: MildHeadEase Syrup - 5ml (Fictional)");
            else
                Console.WriteLine("Prescription: PainRelief Plus - 1 tablet after food (Fictional)");
        }
        else if (symptom == "cough")
        {
            if (age < 12)
                Console.WriteLine("Prescription: CoughShield Kids Syrup - 1 spoon twice a day (Fictional)");
            else
                Console.WriteLine("Prescription: CoughStop Syrup - 10ml twice a day (Fictional)");
        }
        else
        {
            Console.WriteLine("Symptom not recognized. Please consult a real doctor.");
        }

        Console.WriteLine("\n(Note: This is a fictional medical bot created for educational purposes.)");
    }
}
