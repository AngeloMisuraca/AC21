using System;
using System.Runtime.InteropServices;

public class Naves
{
    public static string[] naves = new string[5];

    static void Main()
    {

        Naves.naves[0] = Convert.ToString(5);
        int calcadorNave = 0;
        int navesgeneradas = 0;
        int opcion;

        Console.WriteLine("=== SISTEMA DE FABRICACIÓN DE NAVES ESTELARES ===");
        Console.WriteLine("1: crear una nave");
        Console.WriteLine("2: cambiar el nombre");
        Console.WriteLine("3: listar las naves");
        Console.WriteLine("4: eliminar una nave");
        Console.WriteLine("5: eliminar todas");
        Console.WriteLine("6: salir");
    }
}