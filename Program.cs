using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		int years;
		double monthlySalary, percentage, bonusAmount;
		
		Console.WriteLine("Ingresa la cantidad de años trabajados: ");
		years = Validations.ValidateInteger(Console.ReadLine());
		
		percentage = Conditionals.AntiquityBonus(years);
		
		Console.WriteLine("Ingresa salario mensual recibido: ");
		monthlySalary = Validations.ValidateDouble(Console.ReadLine());
		
		bonusAmount = monthlySalary * percentage;
		
		Console.WriteLine($"El bono por antiguedad es de: {bonusAmount}");
		
	}
}