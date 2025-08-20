using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaPractica1
{
    internal class guia_01
    {
        public void ejercicio_1()
        {
            string mensaje;

            mensaje = "Hola Mundo!";

            Console.WriteLine(mensaje);
        }
        
        public void ejercicio_2()
        {
            // Declaracion de variables y tipos de datos
            string nombre;
            string pais;
            byte edad;

            // Asignacion de valores a las variables
            nombre = "Thomas Gomez";
            pais = "Argentina";
            edad = 25;

            // Mensaje por consola
            Console.WriteLine("Su nombre es " + nombre + ", su pais es " + pais + " y su edad es " + edad + ".");

            // Pedir datos por consola al usuario
            Console.Write("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Por favor ingrese su país: ");
            pais = Console.ReadLine();

            Console.Write("Por favor ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Su nombre es " + nombre + ", su pais es " + pais + " y su edad es " + edad + ".");
        }
        public void ejercicio_3()
        {
            // Declaracion de variables
            string nombre;
            string apellido;
            byte edad;
            string carrera;

            // Solicitar al usuario que ingrese los datos 
            Console.Write("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Por favor ingrese su apellido: ");
            apellido = Console.ReadLine();            

            Console.Write("Por favor ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor ingrese la carrera que estudia: ");
            carrera = Console.ReadLine();

            // Mostrar los datos por consola en una sola línea
            Console.WriteLine("Los datos ingresados son los siguientes. Nombre y apellido: " + nombre + " " + apellido + ". Edad: " + edad + ". Estudiante de la carrera: " + carrera + ".");

        }

        public void ejercicio_4_a()
        {
            // Declaracion de variables
            int totalMaterias;
            int materiasAprobadas;
            int materiasFaltantes;

            // Pedir al usuario los valores por consola
            Console.Write("Por favor ingrese el total de materias de su carrera: ");
            totalMaterias = Convert.ToByte(Console.ReadLine());
            
            Console.Write("Por favor ingrese el total de materias aprobadas hasta el momento: ");
            materiasAprobadas = Convert.ToByte(Console.ReadLine());

            // Calcular materias faltantes
            materiasFaltantes = totalMaterias - materiasAprobadas;

            Console.WriteLine("Las materias que le faltan para finalizar la carrera son: " + materiasFaltantes + " materias.");
        }

        public void ejercicio_4_b()
        {
            // Definir variables y constante
            const int totalMaterias = 32;
            int materiasAprobadas;
            int materiasFaltantes;

            // Solicitar valores 
            Console.WriteLine("El total de materias de la carrera es: " + totalMaterias);            

            Console.Write("Por favor ingrese el total de materias aprobadas hasta el momento: ");
            materiasAprobadas = Convert.ToByte(Console.ReadLine());

            // Calcular materias faltantes
            materiasFaltantes = totalMaterias - materiasAprobadas;

            Console.WriteLine("Las materias que le faltan para finalizar la carrera son: " + materiasFaltantes + " materias.");

        }

        public void ejercicio_5()
        {
            // Definir variables
            int numero1;
            int numero2;
            int numero3;
            int numero4;

            // Solicitar valores
            Console.Write("Por favor ingrese el primer número: ");
            numero1 = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor ingrese el segundo número: ");
            numero2 = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor ingrese el tercer número: ");
            numero3 = Convert.ToByte(Console.ReadLine());

            Console.Write("Por favor ingrese el cuarto número: ");
            numero4 = Convert.ToByte(Console.ReadLine());

            // Mostrar los 4 números en el orden inverso al ingresado por el usuario
            Console.WriteLine("La cadena de números ingresados inversa es: " + numero4 + numero3 + numero2 + numero1);
        }

        public void ejercicio_6()
        {
            // Declaracion de variables y constantes
            float t_alto;
            float t_base;
            float t_area;
            const int dividendo = 2;

            // Solicitar valores
            Console.Write("Por favor ingrese la base del triangulo: ");
            t_base = Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese el alto del triangulo: ");
            t_alto = Convert.ToSingle(Console.ReadLine());

            // Calculo de area
            t_area = (t_alto * t_base) / dividendo;
            Console.WriteLine("La base de su triangulo es: " + t_area);
        }

        // ejercicio 7 muy parecido al 6, se saltea 

        public void ejercicio_8()
        {
            // Declaracion de variables
            float notaPrimerParcialTeorico;
            float notaSegundoParcialTeorico;
            float notaPrimerParcialPractico;
            float notaSegundoParcialPractico;
            float promedioTeoria;
            float promedioPractica;
            float promedioMateria;

            // Solicitar valores
            Console.Write("Por favor ingrese la nota del primer parcial teórico: ");
            notaPrimerParcialTeorico = Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese la nota del segundo parcial teórico: ");
            notaSegundoParcialTeorico = Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese la nota del primer parcial práctico: ");
            notaPrimerParcialPractico= Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese la nota del segundo parcial práctico: ");
            notaSegundoParcialPractico = Convert.ToSingle(Console.ReadLine());

            // Calcular promedios
            promedioTeoria = (notaPrimerParcialTeorico + notaSegundoParcialTeorico) / 2;
            Console.WriteLine("Su promedio de parciales teóricos es: " + promedioTeoria);

            promedioPractica = (notaPrimerParcialPractico + notaSegundoParcialPractico) / 2;
            Console.WriteLine("Su promedio de parciales prácticos es: " + promedioPractica);

            promedioMateria = (notaPrimerParcialTeorico + notaSegundoParcialTeorico + notaPrimerParcialPractico + notaSegundoParcialPractico) / 4;
            Console.WriteLine("Su promedio de la materia es: " + promedioMateria);

        }



























    }
}
