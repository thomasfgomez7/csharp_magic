using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_practica_3
{
    public class definicionArrays
    {
        public void Prueba_array()
        {
            // Declaracion e instanciación de un array 
            String[] primerArray = new String[5];
            int[] numbers = new int[5];
            int[] pares = { 2, 4, 6, 8, 10 };
            Console.WriteLine("numbers: " + string.Join(", ", numbers));

            // Matriz Bidimensional
            int[,] matriz = new int[2, 3];
            int[,] matriz_bidimensional = { { 1,2,3 }, { 4,5,6 } };

            // Métodos compunes para arrays 
            int length = numbers.Length;
            int rank = pares.Rank;
            numbers.SetValue(10, 2);
            Array.Sort(numbers);
            Array.Clear(numbers, 0, numbers.Length);

            // Recorrer una matriz
            for (int i=0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Imprimir cada elemento del array usando Array.ForEach            
            Array.ForEach(numbers, n => Console.WriteLine(n));            
            
            // Declaración de una matriz (2D)
            string[,] matrizString= new string[5, 7];
            Console.WriteLine($"Matriz creada con dimensiones [{matriz.GetLength(0)}, {matriz.GetLength(1)}]");

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------

            string holaMundo = "Hola Mundo!";

            Console.WriteLine(holaMundo.Length);
            /*
            .ToUpper() → convierte a mayúsculas.
            .ToLower() → convierte a minúsculas.
            .Substring(inicio, longitud) → obtiene una subcadena.
            .Contains("texto") → busca una subcadena.
            .StartsWith("H") / .EndsWith("o") → comprueba el inicio o final.
            .IndexOf("a") → devuelve la posición de un carácter/ subcadena.
            .Replace("a", "e") → reemplaza caracteres o texto.
            .Trim() → elimina espacios en blanco al inicio y final.
            .Split(' ') → separa el string en un array de subcadenas.
            */
        }
    }
}
