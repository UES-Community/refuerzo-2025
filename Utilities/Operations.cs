namespace hello_world.Utilities;

public class Operations
{
	/// <summary>
	/// Resta dos números
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
   public void Substract(double a, double b) //num1 = a ; num2 = b
   {
	   double result = 0;
	   
	   //Verificacion
		if (double.IsNaN(a) || double.IsNaN(b)) 
		{
			Console.WriteLine("Por favor ingresa un número válido");
			return;
		}

		result = a - b; //result = num1 - num2

		Console.WriteLine($"Resultado {a} - {b} = {result}");
   }

   /// <summary>
   /// Multiplica dos números
   /// </summary>
   /// <param name="a"> Este número debe de ser positivo </param>
   /// <param name="b"> Este número debe de ser negativo </param>
   public static void Multiply(double a, double b)
   {
	   double result = 0;
	   
	   //Verificacion
		if (double.IsNaN(a) || double.IsNaN(b)) 
		{
			Console.WriteLine("Por favor ingresa un número válido");
			return;
		}

		result = a * b; //result = num1 * num2

		Console.WriteLine($"Resultado {a} * {b} = {result}");
	   
   }
}