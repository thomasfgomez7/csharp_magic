namespace Clase_practica2
{
    internal class EjerciciosCondicional
    {
        public void ejemploIf()
        {
            // Declaracion de variables
            string situacion;
            int nota = 5;                       

            // if de mas de una sentencia
            if (nota < 1 || nota > 10)
            {                
                Console.WriteLine("La nota está fuera de rango.");
            }
            else
            {
                if (nota < 4)
                {
                    if (nota == 1)
                    {
                        situacion = "Desastre";
                    }
                    else
                    {
                        situacion = "Aplazado";
                    }                        
                    Console.WriteLine("La situación del alumno es: " + situacion);
                }
                if (nota < 7)
                {
                    situacion = "Regularizado";
                    Console.WriteLine("La situación del alumno es: " + situacion);
                }
                if (nota < 10)
                {
                    situacion = "Promocionado";
                    Console.WriteLine("La situación del alumno es: " + situacion);
                }                        
            }            
        }
    }
}
