using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		const int DAYS = 6;
		int[] daylyProd = new int[DAYS];
		string[] days = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado"};

		for (int i = 0; i < DAYS; i++)
		{
			Console.WriteLine($"Ingrese la produccion del dia {days[i]}"); //days[0] = "Lunes"
			daylyProd[i] = Validations.ValidateNumber(Console.ReadLine());
		}
		
		Console.Clear();
		Conditionals.ProductionStats(daylyProd);
		
	}
}