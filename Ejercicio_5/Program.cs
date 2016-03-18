using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_5
{

    /* 
    05.  Un centro numérico es un número que separa una lista de números 
    enteros (comenzando en 1) en dos grupos de números, cuyas sumas 
    son iguales.  
    El primer centro numérico es el 6, el cual separa la lista (1 a 
    8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas 
    iguales a 15. El segundo centro numérico es el 35, el cual separa 
    la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas 
    son ambas iguales a 595.  
    Se pide elaborar una aplicación que calcule los centros numéricos 
    entre 1 y el número que el usuario ingrese por consola.  
 
    Nota: Utilizar estructuras repetitivas, selectivas y la función 
    módulo (%).
    */ 

    class Ejercicio_5
    {
        static void Main(string[] args)
        {
            int num;
            int acum1 = 0;
            int acum2 = 0;
            int i;

            Console.Title = "Ejercicio Nro. 5";

            Console.Write("Ingrese un numero mayor a 0: ");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.Clear();
                    Console.Write("ERROR!!! no se ha ingresado un numero. Ingrese un numero mayor a 0: ");
                }

                if (num <= 0)
                {
                    Console.Clear();
                    Console.Write("ERROR!!! Ingrese un numero mayor a 0: ");
                }
            } while (num <= 0);

            Console.Clear();
            Console.WriteLine("Mostrando centros numericos desde el 1 hasta el {0}: ", num);

            for (int j = 1; j < num; j++)
            {
                acum1 += j;
                acum2 = 0;

                for (i = j + 2; acum1 > acum2; i++)
                    acum2 += i;

                if (acum1 == acum2)
                    Console.WriteLine("{0} (1 a {1} y {2} a {3})",j + 1, j, j + 2, i - 1);
            }

            Console.ReadKey();
        }
    }
}