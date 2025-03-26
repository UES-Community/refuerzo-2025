using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		int number;
		
		Console.Write("Ingrese el año que desea verificar: ");
		number = Validations.ValidateNumber(Console.ReadLine());
		
		Conditionals.IsLeapYear(number); //Aca estoy llamando a mi modulo de condicionales en mi flujo principal
	}
}