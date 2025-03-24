using System;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		double numValidated1, numValidated2, numValidated3, numValidated4, productPrice;
		String productName; 
		
		double pricePerSecond, pricePerByte, secondsConsumed, bytesConsumed;
		
		// Entrada de datos
		// Console.Write("Ingrese el nombre del producto: ");
		// productName = Validations.NotEmpty(Console.ReadLine());
		Console.Write("Ingrese el precio unitario por segundo de llamada: ");
		numValidated1 = Validations.ValidateNumber(Console.ReadLine());
		pricePerSecond = Convert.ToDouble(numValidated1);
		
		Console.Write("Ingrese el precio unitario por byte: ");
		numValidated2 = Validations.ValidateNumber(Console.ReadLine());
		pricePerByte = Convert.ToDouble(numValidated2);
		
		//
		// Console.Write("Ingrese el costo del producto: ");
		// numValidated2 = Validations.ValidateNumber(Console.ReadLine());
		// productPrice = Convert.ToDouble(numValidated2);
		Console.Write("Ingrese el monto en segundo consumidos: ");
		numValidated3 = Validations.ValidateNumber(Console.ReadLine());
		secondsConsumed = Convert.ToDouble(numValidated2);
		
		Console.Write("Ingrese el monto en bytes consumidos: ");
		numValidated4 = Validations.ValidateNumber(Console.ReadLine());
		bytesConsumed = Convert.ToDouble(numValidated2);
		
		// Proceso
		// ECommerce.ConsumerPrice(productName, productPrice);
		ECommerce.ComunicationPrice(pricePerSecond, pricePerByte, secondsConsumed, bytesConsumed);
		
	}
}