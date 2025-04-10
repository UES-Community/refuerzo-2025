﻿namespace hello_world.Utilities;

public class Validations
{
    public static int ValidateInteger(string input)
    {
        //declaracion + inicializacion de variable
        int result = 0;

        // validacion 
        if (!int.TryParse(input, out result))
        {
            Console.WriteLine("Por favor ingrese un valor numerico");
            return 0;
        }
        

        return result;
    }
    
    public static double ValidateDouble(string input)
    {
        //declaracion + inicializacion de variable
        double result = 0;

        // validacion 
        if (!Double.TryParse(input, out result))
        {
            Console.WriteLine("Por favor ingrese un valor numerico");
            return 0;
        }
        

        return result;
    }

    public static string NotEmpty(string input)
    {

        string inputToReturn;
        
        if (string.IsNullOrWhiteSpace(input))
        {
            inputToReturn = "Sin nombre";
        }
        
        else
        {
            inputToReturn = input;
        }
        
        return inputToReturn;
    }
}