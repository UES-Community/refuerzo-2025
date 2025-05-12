using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;

class Program
{
    static void Main(string[] args)
    {
        int[] myScores = {12, 93,6 , 10, 1}; //notas de mis 5 materias de la U
        string[] myAsignatures = { "MIP", "SGI", "EBB", "RRHH", "TAD"};
        int[] firstThree = new int[5];
        int oddNumber = 0;
        string myFavoriteAsignature;
        int position;

        // Array.Copy(myScores, firstThree, 3);// copiaba 3 de myScores -> firstThree
        //myScores.CopyTo(firstThree, 0); //5
        // oddNumber = Array.Find(myScores, numerito => numerito%2 != 0); //6/2 = 3 %0 ; 7/2 = 3 %1; 
        // myFavoriteAsignature = Array.Find(myAsignatures, asignature => asignature == "IAI");
        // position = Array.IndexOf(myScores, 10); //indice = posicion; posicion = 0; [0, 1]
        Console.WriteLine($"Arreglo de sin ordenar: {myScores}");
        foreach (int i in myScores)
        {
            Console.WriteLine(i);
        }
        
        Array.Sort(myScores);

        Console.WriteLine($"Arreglo de notas ordenado: {myScores}");
        foreach (int i in myScores)
        {
            Console.WriteLine(i);
        }
    }

}