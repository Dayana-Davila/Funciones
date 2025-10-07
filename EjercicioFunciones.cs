using System;

class PromedioEstudiante
    {
        static void Main()
        {
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese 3 calificaciones:");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double promedio = CalcularPromedio(nota1, nota2, nota3);

            string resultado = DeterminarResultado(promedio);

            Console.WriteLine("Nombre del estudiante: " + nombre);
            Console.WriteLine($"Calificaciones ingresadas: {nota1}, {nota2}, {nota3}");
            Console.WriteLine("Promedio final: " + promedio.ToString("0.00"));
            Console.WriteLine("Estado: " + resultado);
        }
        static double CalcularPromedio(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }
        static string DeterminarResultado(double promedio)
        {
            if (promedio >= 7)
                return "APROBADO";
            else
                return "REPROBADO";
        }
    }


}
}
