using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
    static void Main(string[] args)
    {
        const double SALARY_BASE = 182.50; //365.00
        const int BONUS = 100;
        const double COMISION = 0.03; //3%
        bool biweekly = true;

        // Quincena iniciada
        // Registro de n vendedores
        while (biweekly) //boolean - bandera
        {
            bool registryAnotherCar = true;
            string vendor;
            int totalCars = 0;
            double sumOfCarPrices = 0.0;
            double salary;

            Console.WriteLine("Ingrese el nombre del vendedor: ");
            vendor = Console.ReadLine();

            // Registro de m carros vendidos para un vendedor m
            while (registryAnotherCar) //boolean - bandera
            {
                double carPrice = 0.00;
                char continueRegistries = 'S';

                Console.WriteLine("Ingrese el precio del vehiculo vendido: ");
                carPrice = Validations.ValidateDouble(Console.ReadLine());

                sumOfCarPrices += carPrice;
                totalCars++;

                Console.WriteLine("Desea seguir registrando autos? (S/N)");
                continueRegistries = Convert.ToChar(Console.ReadLine());

                // Continuar registrando o no?
                switch (continueRegistries) //char - centinela
                {
                    case 'S':
                        registryAnotherCar = true;
                        break;
                    case 'N':
                        registryAnotherCar = false;
                        break;
                    default:
                        registryAnotherCar = false;
                        break;
                }
            }

            salary = SALARY_BASE + (totalCars * BONUS) + (sumOfCarPrices * COMISION);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"NOMBRE VENDEDOR : {vendor}");
            Console.WriteLine($"TOTAL DE AUTOS VENDIDOS : {totalCars}");
            Console.WriteLine($"SUELDO : $ {salary}");
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Hya otro vendedor? (S/N) ");
            biweekly = Console.ReadLine() == "S"; //true ? //False
        }

        Console.WriteLine("Fin de la ejecucion...");
        Console.ReadKey();
    }
}