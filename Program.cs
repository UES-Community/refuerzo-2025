using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;

public struct Movie
{
    public string Name { get; set; }
    public int Year { get; set; }
    public string Gender { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Movie[] movies = new Movie[3];
        string csvFilePath = "peliculas.csv";
        string secondCsvFilePath = "idioma.csv";

        //Guardar datos
        for (int i = 0; i < movies.Length; i++) //declarativas vs imperativas
        {
            //Almacenamiento de nombre
            Console.WriteLine($"Ingresa los datos de la pelicula #{i + 1}:");

            Console.Write("Nombre: ");
            movies[i].Name = Console.ReadLine();
            
            //Almacenamiento de año
            Console.Write("Año: ");
            movies[i].Year = Validations.ValidateInteger(Console.ReadLine());
            
            //Almacenamiento de género
            Console.Write("Género: ");
            movies[i].Gender = Console.ReadLine();
        }
        
        //Escribir archivo
        try
        {
            using (StreamWriter sw = new StreamWriter(csvFilePath))
            {
                sw.WriteLine("Name,Year,Gender");

                foreach (Movie movie in movies)
                {
                    sw.WriteLine($"{movie.Name}, {movie.Year}, {movie.Gender}");
                }
            }

            Console.WriteLine($"The file {csvFilePath} was created");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something goes wrong {csvFilePath}: {ex.Message}");
        }
        
        //Idiomas
        Console.WriteLine("Ingrese los idiomas para cada pelicula");
        try
        {
            using (StreamWriter sw = new StreamWriter(secondCsvFilePath))
            {
               sw.WriteLine("Name,Year,Gender, Language");

               foreach (Movie movie in movies)
               {
                   Console.WriteLine($"Para la pelicula {movie.Name}, decime su estado (doblada/con titulos): ");
                   string languageSelected = Console.ReadLine();
                   
                   sw.WriteLine($"{movie.Name}, {movie.Year}, {movie.Gender}, {languageSelected}");
               }
            }
            
            Console.WriteLine($"The file {secondCsvFilePath} was created");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Something goes wrong {secondCsvFilePath}: {e.Message}");
        }
        
    }
}