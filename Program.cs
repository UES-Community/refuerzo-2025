using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
    static void Main(string[] args)
    {
        bool isCurrentlyWorking = true;
        int totalQuantity = 0;
        
        Console.WriteLine("--- Gestion de compra de toallas ---");
        Console.WriteLine("Para evitar el cobro por envio, haga una compra igual o mayor a 3 sets");
        Console.WriteLine("----------------------------------");
        Console.ReadKey();
        Console.Clear();
        
        
        // Inicio del dia laboral
        while (isCurrentlyWorking)
        {

            int quantityPerUser;
            string continueWithRegistries;
            
            Console.WriteLine("Ingrese la cantidad de sets de toallas a comprar");
            quantityPerUser = Validations.ValidateInteger(Console.ReadLine());

            // Mensaje informativo sobre el envio
            if (quantityPerUser < 3)
            {
                Console.WriteLine("Se cobrará el envio");
            }
            else
            {
                Console.WriteLine("No se cobrará el envio");
            }
            
            totalQuantity += quantityPerUser;
            
            Console.WriteLine("Desea ingresar otro pedido? (S/N): ");
            continueWithRegistries = Console.ReadLine();
            Console.Clear();

            switch (continueWithRegistries)
            {
               case "S":
                   isCurrentlyWorking = true;
                   break;
               case "N":
                   isCurrentlyWorking = false;
                   break;
               default:
                   isCurrentlyWorking = false;
                   break;
            } 
            
        }
        
        Console.Clear();
        Console.WriteLine(" --- Ejercicio de compra de toallas --- ");
        Console.WriteLine($" Cantidad total de sets toallas vendidas: {totalQuantity} ");

    }
}