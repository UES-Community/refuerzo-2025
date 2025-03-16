using System;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		// Declaracion e inicializacion de variables
		double num1, num2; //entradas
		
		double numValidated1, numValidated2; //procesos
		Operations sum; //procesos
		
		double result = 0; // salida
		
		// Entrada de datos
		Console.Write("Ingresa el primer número: ");  // impresion del mensaje
		numValidated1 = Validations.ValidateNumber(Console.ReadLine());	// validacion de la entrada
		num1 = Convert.ToDouble(numValidated1); // conversion de la entrada
		
		Console.Write("Ingresa el segundo número: ");
		numValidated2 = Validations.ValidateNumber(Console.ReadLine());	// validacion de la entrada
		num2 = Convert.ToDouble(numValidated2);
		
		// Operaciones
		
		// Restar
		sum = new Operations();
		sum.Substract(num1, num2);
		
		// Multiplicar
		Operations.Multiply(num1, num2); 
	}
}