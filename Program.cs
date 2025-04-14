using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
    static void Main(string[] args)
    {

        double packageWeight; //peso individuales
        int totalPackageCount = 0;
        int lowerToTen = 0;
        int betweenTenTwenty = 0;
        int higherToTwenty = 0; //conteo de paquetes

        do
        {
            
        Console.WriteLine("Ingrese el peso del paquete en kg: ");
        packageWeight = Validations.ValidateDouble(Console.ReadLine()); //VALIDAR QUE LA ENTRADA DEL USUARIO SEA UN DIGITO NUMERICO

        if (packageWeight != 0)
        {
            totalPackageCount++;

            if (packageWeight < 10)
            {
                lowerToTen++;
            }
            else if (packageWeight >= 10 && packageWeight < 20)
            {
                betweenTenTwenty++;
            }
            else
            {
                higherToTwenty++;
            }
        }
        
        
        } while (packageWeight != 0);
        
        Console.WriteLine($"Paquetes inferiores a 10 kg: {lowerToTen}");
        Console.WriteLine($"Paquetes entre 10 kg y 20 kg: {betweenTenTwenty}");
        Console.WriteLine($"Paquetes superiores a 20 kg: {higherToTwenty}");
        Console.WriteLine($"Paquetes totales pesados: {totalPackageCount}");
        
       Console.WriteLine("\n Presione cualquier tecla para continuar...");
       Console.ReadKey();
    }
}