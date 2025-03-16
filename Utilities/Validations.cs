namespace hello_world.Utilities;

public class Validations
{
    public static double ValidateNumber(string input)
    {
        //declaracion + inicializacion de variable
        double result = 0;

        // validacion 
        if (!double.TryParse(input, out result))
        {
            Console.WriteLine("Por favor ingrese un valor numerico");
            return 0;
        }

        return result;
    }
}