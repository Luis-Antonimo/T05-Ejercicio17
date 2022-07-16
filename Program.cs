using System;

namespace T05Ejercicio17
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];

            IngresarValores(array);
            MostrarIndice(array);
        }

        static void IngresarValores(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Escriba el valor del array con posición " + (i + 1) + "º");
                int valor = Convert.ToInt32(Console.ReadLine());
                array[i] = valor;
            }
        }

        static void MostrarIndice(int[] array)
        {
            foreach (int x in array)
            {
                Console.WriteLine("El elemento del array con índice: [{0}] Tiene el valor: {1}", x - 1, array[x - 1]);
            }
        }

    }
}