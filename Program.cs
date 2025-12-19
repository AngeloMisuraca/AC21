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

        do
        {
            System.Console.WriteLine("Selecione una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    creatNave(ref calcadorNave, naves);
                    navesgeneradas++;
                    break;
                case 2:
                    CambiearNombre(naves);
                    break;
                case 3:
                    listaNave(naves);
                    System.Console.WriteLine("Se han generado "+ navesgeneradas + " nave/naves");
                    break;
                case 4:
                    elimnarNave(naves);
                    break;
                case 5:
                    elimnarTodo(naves);
                    break;
                case 6:
                    System.Console.WriteLine("hemos salido de el proyecto");
                    break;
                default:
                    System.Console.WriteLine("otra vez");
                    break;
            }
        } while (opcion != 6);



    }
    static Random rnd = new Random();//si ponemos en el funcion de crearNave posible hay 2 value el mismo

    static void creatNave(ref int calcadorNave, string[] naves)
    {

        if (calcadorNave >= naves.Length)
        {
            Console.WriteLine("No pueden crear mas naves.");
            return;
        }

        string[] models = { "HALCONMILENARIO", "CAZAESTELAR", "SUPERDESTRUCTOR", "YWING", "XWING" };//para saber que palabra coge el random
        string palapra = models[rnd.Next(models.Length)];//para el cpu coger un nombre a nave
        int numero = rnd.Next(10, 100);// para el cpu coger un nomero a nave
        string nombre = palapra + "-" + numero;// cada un funcion tiene un numbre y un numero
        naves[calcadorNave] = nombre;
        System.Console.WriteLine("✓ Nave creada: " + nombre);
        calcadorNave++;
    }
    static void CambiearNombre(string[] naves)
    {
        System.Console.WriteLine("cual nave quieres cambiar su nombre(1,2,3,4,5)?");
        int num = Convert.ToInt32(Console.ReadLine());
        string nombreAnterior = naves[num-1];
        string[] models = { "HALCONMILENARIO", "CAZAESTELAR", "SUPERDESTRUCTOR", "YWING", "XWING" };
        string palapra = models[rnd.Next(models.Length)];
        naves[num - 1] =  palapra + "-" + rnd.Next(10, 100);
        System.Console.WriteLine(naves[num - 1]);
        System.Console.WriteLine("✓ Nave renombrada: " + nombreAnterior + " → " + naves[num - 1]);
    }
    static string titulocambio = "=== NAVES FABRICADAS ===";
    static void listaNave(string[] naves)
    {
        
        Console.WriteLine(titulocambio);

        System.Console.WriteLine("Quieres cambiar el nombre del titulo de esta opcion? S/N");
        string personalizar = Console.ReadLine();

        if (personalizar == "s" || personalizar == "S")
        {
            System.Console.WriteLine("Escribe el titulo nuevo");
            titulocambio = "=== " + Console.ReadLine() + " ===";
            Console.WriteLine(titulocambio);
        }
        
        for (int i = 0; i < naves.Length; i++)
        {
            System.Console.WriteLine("[" + i + "]" + naves[i]);
        }
        
    }
    static void elimnarNave(string[] naves)
    {
            System.Console.WriteLine("Cual nave quieres eliminar? (1,2,3,4,5)?");
            int num = Convert.ToInt32(Console.ReadLine());
            naves[num - 1] = null;//elimnar solo el nave que quieres
    }
    static void elimnarTodo(string[] naves)
    {
        System.Console.WriteLine("Estas seguro que quieres eliminar todas las naves? s/n");
        string confirmacion = Console.ReadLine();

        bool condicion = false;

        if (confirmacion == "S" || confirmacion == "s")
        {
            condicion = true;
        }
        else if (condicion == true)
        {
            for (int i = 0; i < naves.Length; i++)
            {
                naves[i] = null; //elimnar todoel navas
            }
        } 
        else
        {
            Console.WriteLine("Operación cancelada");
        }
    }
}


