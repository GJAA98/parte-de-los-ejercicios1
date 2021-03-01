using System;

namespace Practica_ordenar_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Inserte un numero:");
                string valor = Console.ReadLine();
                numeros[i] = float.Parse(valor);
            }

            Console.WriteLine("Resultado:");           
            for (int i = 4; i >=0; i--)
            {
                Console.WriteLine("Numero " + i + ":" + numeros[i]);                
            }
        }
    }
}
