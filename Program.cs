using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
    static void Main(string[] args)
    {
        string clientName;
        int roomType;
        int daysToStay;
        char continueRegistries = 'S';
        int clientsCount = 0;

        do
        {
            double rateToPay, discountToApply, subTotal, total;

            Console.WriteLine("Ingrese el nombre del huésped: ");
            clientName = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de habitación a utilizar: ");
            Console.WriteLine("1. $120\n2. $155\n3. $219\n4. $285\n5.$400");

            roomType = Validations.ValidateInteger(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dias a hospedarse en la habitación: ");
            daysToStay = Validations.ValidateInteger(Console.ReadLine());

            rateToPay = Conditionals.GetAmountToPayDaily(roomType); // $120
            discountToApply = Conditionals.GetDiscountPerDays(daysToStay); // 10%
            subTotal = daysToStay * rateToPay;
            total = subTotal - (subTotal * discountToApply); // $120 - (120 * 10%) == 120 - 12 = 1082 = 108
            clientsCount++;
            
            Console.Clear();
            Console.WriteLine("************ REPORTE ************");
            
            // Header
            Console.WriteLine("\n {0, -20}{1, 8}{2, 8}{3, 10}{4, 10}{5, 12}",
                "Nombre Huesped",
                "dias",
                "tarifa",
                "subtotal",
                "descuento",
                "total");
            
            // Filas
            Console.WriteLine("\n {0, -20}{1, 8}{2, 8}{3, 10}{4, 10}{5, 12}",
                clientName,
                daysToStay,
                rateToPay,
                subTotal,
                discountToApply,
                total);
            
            Console.WriteLine($"Clientes ingresados: {clientsCount}");
            Console.WriteLine("Desea ingresar clientes(huesped)  -- (S/N)");
            continueRegistries = Char.Parse(Console.ReadLine().ToUpper()) ;
            

        } while (continueRegistries == 'S');
    }
}