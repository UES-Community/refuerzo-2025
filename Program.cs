using System;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{
		
		double firstEntry, secondEntry, thirdEntry;
		double numValidated1, numValidated2, numValidated3;

		Console.Write("Ingrese el primer número: ");
		numValidated1 = Validations.ValidateNumber(Console.ReadLine());
		firstEntry = Convert.ToDouble(numValidated1);
		
		Console.Write("Ingrese el segundo numero: ");
		numValidated2 = Validations.ValidateNumber(Console.ReadLine());
		secondEntry = Convert.ToDouble(numValidated2);

		Console.Clear();
		Console.Write("Ingrese el tipo de operacion desea realizar: ");
		Console.Write("\n1 - Resta\n2 - Multiplicacion\n3 - Potencia\n");
		numValidated3 = Validations.ValidateNumber(Console.ReadLine());
		thirdEntry = Convert.ToDouble(numValidated3);
		
		//Condicionales

		switch (thirdEntry)
		{
			case 1:	
				Operations.Substract(firstEntry, secondEntry);
				break;
			case 2:
				Operations.Multiply(firstEntry, secondEntry);
				break;
			case 3:
				Operations.Power(firstEntry, secondEntry);
				break;
			default:
				Console.WriteLine("Por favor ingrese una opcion valida");
				break;
		}
	}
}