namespace hello_world.Miscellaneous;

public class Conditionals
{
    /// <summary>
    /// Verifica si un año es bisiesto
    /// </summary>
    /// <param name="year"> El año a verificar </param>
    public static void IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"El año {year} es bisiesto");
        }
        else
        {
            Console.WriteLine($"El año {year} no es bisiesto");
        }
    }

    public static void ProductionStats(int[] prodPerDay)
    {
        const int MIN_PROD = 100;
        int totalProd;
        double meanProd;
        bool deservesIncentive = false;

        totalProd = prodPerDay.Sum(); // iteracion (for) 0 <= 5 {i++}
        meanProd = double.Round(prodPerDay.Average(), 2); // iteracion (for) 0 <= 5 {i++ / prodPerDay.Length}

        if (meanProd > MIN_PROD)
        {
           deservesIncentive = true; 
        }

        Console.WriteLine($"Total de produccion: {totalProd}");
        Console.WriteLine($"Promedio de produccion: {meanProd}");

        if (deservesIncentive)
        {
            Console.WriteLine($"El operario recibirá un incentivo");
        }
        else
        {
            Console.WriteLine($"El operario NO recibirá un incentivo");
        }
        
    }

    /// <summary>
    /// Asigna porcentaje de bono por antiguedad
    /// </summary>
    /// <param name="yearsWorked"> Cantidad de anios laborados </param>
    /// <returns> Porcentaje segun tabla de equivalencia por anios </returns>
    public static double AntiquityBonus(int yearsWorked)
    {
       double porcent; //null

       switch (yearsWorked)
       {
           case >= 10:
               porcent = 0.20;
               break;
           case >= 5:
               porcent = 0.15;
               break;
           case >= 3:
               porcent = 0.1;
               break;
           case >= 2:
               porcent = 0.05;
               break;
           default:
               porcent = 0.0;
               break;
       }

       return porcent;
    }
}