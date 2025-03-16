using System;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		double baseNum;
		List<int> potencias = new List<int> { 2, 3, 4, 5 };
		
		double numValidated1, numValidated2; 
		
		// Entrada de datos
		Console.Write("Ingrese la base del numero: ");
		numValidated1 = Validations.ValidateNumber(Console.ReadLine());
		baseNum = Convert.ToDouble(numValidated1); 
		
		// Potencia
		foreach (int cuarto in potencias)
		{
			Operations.Power(baseNum, cuarto);
		}
		
	}
}