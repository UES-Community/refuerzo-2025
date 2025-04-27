using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
    static void Main(string[] args)
    {

        string inputWord; //entrada
        string invertedWord = ""; //salida
        char[] charArray; //proceso
        
        Console.WriteLine("Escribe una palabra: ");
        inputWord = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(inputWord)) 
        {
            charArray = inputWord.ToCharArray();
            foreach (char caracter in charArray) 
            {
                invertedWord = caracter + invertedWord;  
            } 
            
            Console.WriteLine($"La palabra invertida es: {invertedWord}");
        }

    }
}