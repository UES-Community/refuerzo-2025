using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
    static void Main(string[] args)
    {
        int underAgeCount = 0; //menores a 18
        int age;

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"---------------------{i + 1}----------------------");
            Console.WriteLine("Por favor ingresa tu edad: ");
            age = Validations.ValidateInteger(Console.ReadLine());
            
            if (age < 18)
            {
                underAgeCount++;
            }
            
            Console.Clear();

        }
        
        Console.WriteLine($"El conteo total de menores a 18 es: {underAgeCount}");

    }
}