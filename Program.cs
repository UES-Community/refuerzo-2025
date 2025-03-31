using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		int carwashCount = 0;
		
		Console.WriteLine("Indiqueme la cantidad lavadas en el  carwash: ");	
		carwashCount = Validations.ValidateInteger(Console.ReadLine());
		
		if (carwashCount > 0)
		{
			ECommerce.PriceToPay(carwashCount);
		}
		else
		{
			Console.WriteLine($"Total a pagar: $0");
			Console.WriteLine($"Actualmente su cuota de pago por cada cita es de: $5 ");
		}
		
	}
}