using System;
namespace PracticasArreglos
{
    class SampleOne
    {
        int[] arreglo = new int[10];

        public void Run()
        {
            LLenarArreglo();
            MostrarArreglo();
        }

        public void LLenarArreglo()
        {
            Console.WriteLine("Ingrese los datos del arreglo:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToByte(Console.ReadLine());
            }
        }

        public void MostrarArreglo()
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Arreglo[{i}]: {arreglo[i]}");
            }
        }
    }    
}
