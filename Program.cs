using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		int periodInput;
		double salaryInput, ISRCalculated;

		// Solicitud de frecuencia de pago
		Console.WriteLine("Por favor ingrese el periodo de pago con el que quiere trabajar: ");
		Console.WriteLine("---------------------------------------------------------------- ");
		Console.WriteLine(" 1) Semanal");
		Console.WriteLine(" 2) Quincenal");
		Console.WriteLine(" 3) Mensual");
		Console.WriteLine("---------------------------------------------------------------- ");
		
		periodInput = Validations.ValidateInteger(Console.ReadLine());
		Console.Clear();
		
		// Solcitud de salario
		Console.WriteLine("Por favor ingrese el salario gravable: ");
		salaryInput = Validations.ValidateDouble(Console.ReadLine());

		// Seleccion de tabla con base a la frecuencia de pago
		switch (periodInput)
		{
			case 1:
				ISRCalculated = ISR.WeeklyTable(salaryInput);
				break;
			case 2:
				ISRCalculated = ISR.BiweeklyTable(salaryInput);
				break;
			case 3:
				ISRCalculated = ISR.MonthlyTable(salaryInput);
				break;
			default:
				ISRCalculated = 0;
				break;
		}
		
		Console.WriteLine($"El ISR calculado es: {ISRCalculated}");

	}
}