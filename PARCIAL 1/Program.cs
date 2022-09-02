using System;
using System.Collections;

namespace PARCIAL_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents;
            ArrayList registro = new ArrayList();
            string nombre;
            int edad;
            int nota1;
            int nota2;
            int parcial;
            int contador = 0;

            Console.WriteLine("ingrese el numero de estudiantes: ");
            numberStudents = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            while (contador < numberStudents)
            {
                Console.WriteLine("Ingrese el numero de estudiantes:");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese edad del estudiante:");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese una nota");
                nota1 = int.Parse (Console.ReadLine());
                Console.WriteLine("Ingrese otra nota");
                nota2 = int.Parse (Console.ReadLine());
                Console.WriteLine("Ingrese otra nota");
                parcial = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Students students = new Students()(Nombre = nombre, Edad = edad);
                registro.Add(students);

                contador++;
            }

        }
    }
}
