using System;
using hello_world.Utilities;

class Program
{
	static void Main(string[] args)
	{

		double ladoTriangulo, alturaRectangulo;
		double numValidated1, numValidated2;
		double areaT, volumenT;
		
		// Entrada de datos
		Console.Write("Ingrese el valor de uno de los lados del triangulo: ");
		numValidated1 = Validations.ValidateNumber(Console.ReadLine());
		ladoTriangulo = Convert.ToDouble(numValidated1); 
		
		Console.Write("Ingrese la altura del rectangulo: ");
		numValidated2 = Validations.ValidateNumber(Console.ReadLine());
		alturaRectangulo = Convert.ToDouble(numValidated1); 
		
		// Operacion de calculo de area y volumne
		areaT = Geom.AreaSuperficialPrismaTriangular(ladoTriangulo, alturaRectangulo);
		volumenT = Geom.VolumenPrismaTriangular(ladoTriangulo, alturaRectangulo);
		
		Console.WriteLine($"El area del prisma triangular es: {areaT} cm cuadrado");
		Console.WriteLine($"El volumen del prisma triangular es: {volumenT} cm cubico");
		
	}
}