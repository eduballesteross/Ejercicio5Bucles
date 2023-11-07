using Ejercicio5Bucles.Servicios;
using System.ComponentModel.Design;

namespace Ejercicio5Bucles;

/// <summary>
/// Clase principal de la aplicación
/// 051123 - ebp
/// </summary>

    class Program
    {

    /// <summary>
    /// Método principal de la aplicación 
    /// 051123 - ebp
    /// </summary>
    /// <param name="args"></param>
    static public void Main(string[] args)
    {
        MenuInterfaz mI = new MenuImplementacion();
        OperativaInterfaz oP = new OperativaImplementacion();

        int numMes, año;
        char repetir;

        do
        {
                numMes = mI.PedirYMostrarMes();
                año = mI.PedirYMostrarAño();


                if (numMes == 1 || numMes == 3 || numMes == 5 || numMes == 7 || numMes == 8 || numMes == 10 || numMes == 12)

                {
                    Console.WriteLine("El mes número " + numMes + " del año " + año + " tiene 31 dias");
                }
                else if (numMes == 4 || numMes == 6 || numMes == 9 || numMes == 11)
                {
                    Console.WriteLine("El mes número " + numMes + " del año " + año + " tiene 30 dias");




                }

                else
                {
                    bool bisiesto;
                    bisiesto = oP.CalcularAñoBisiesto(año);

                    if (bisiesto == true)
                    {
                        Console.WriteLine("El mes número " + numMes + " del año " + año + " tiene 28 dias");
                    }

                    else
                    {
                        Console.Write("El mes número " + numMes + " del año " + año + " tiene 29 dias");
                    }

                Console.WriteLine();

                }


            Console.WriteLine("¿Desea repetir el programa? S/N");
            repetir = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();



        }  
        while (repetir=='s');
        Console.WriteLine("Se cerrará el programa");
            
    }
    }