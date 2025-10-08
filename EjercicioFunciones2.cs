/* un laboratorio necesita un programa que necesite convertir temperaturas entre distintas unidades.
 * El usuario podrá elegir el tipo de conversión que desea realizar:
 * 1. Celsius a Fahrenheit
 * 2. Fahrenheit a Celsius
 * 3. Celsius a Kelvin
 * El programa debe:
 * a) Mostrar un menú de opciones
 * b) Solicitar la temperatura a convertir
 * c) Usar una función con retorno y parametro para realizar la conversión
 * d) Mostrar el resultado con 2 decimales
 * e) Preguntar si desea realizar otra conversión */
using System;
class ConversionTemperaturas
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.Write("Elige una opción:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa la temperatura:");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = CelsiusAFahrenheit(temperatura);
                    Console.WriteLine($"\n{temperatura} °C = {resultado:F2} °F");
                    break;

                case 2:
                    resultado = FahrenheitACelsius(temperatura);
                    Console.WriteLine($"\n{temperatura} °F = {resultado:F2} °C");
                    break;

                case 3:
                    resultado = CelsiusAKelvin(temperatura);
                    Console.WriteLine($"\n{temperatura} °C = {resultado:F2} K");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                    break;
            }

            Console.Write("\n¿Desea realizar otra conversión?: (s/n)");
            string respuesta = Console.ReadLine()!.ToLower();
            if (respuesta != "s")
                continuar = false;
        }
        Console.WriteLine("\n Gracias");
    }
    static double CelsiusAFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
    static double FahrenheitACelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
    static double CelsiusAKelvin(double c)
    {
        return c + 273.15;
    }
}

