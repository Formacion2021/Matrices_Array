using System;

namespace Eumeraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo [] nombre;
            char[] animales = new char[4] {'L','O','B','O' };
            int[] numeros = new int[10];
            //variable para recorrer la matriz
            int i;
            //Recorremos la matriz animales
            for (i = 0; i < 4; i++)
            {
                Console.Write(" {0} ",animales[i]);
            }
                    //Introducimos los elementos en la matriz
                    Console.WriteLine("Introduawefzca 10 elementos en la matriz: ");
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("Elementos: {0}", i);
                try
                {
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception Ex)       
                {
                    Console.WriteLine(Ex.Message);
                }
                Console.Write("\nLos elementos de la matriz son ");
                
            }
            //Recorremos los elementos de la matriz
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", numeros[i]);
            }
            Console.Write("\n");

        }
    }
}
