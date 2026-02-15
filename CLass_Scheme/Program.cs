using CLass_Scheme.classes;
using CLass_Scheme.manejo;
using System;
using System.Collections.Generic;
namespace CLass_Scheme
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            ComunidadService service = new ComunidadService();
            do
            {
                Console.WriteLine("Seleccione el tipo de usuario:");
                Console.WriteLine("1. Maestro");
                Console.WriteLine("2. Estudiante");
                Console.WriteLine("3. Mostrar Todos");
                Console.WriteLine("4. Mostrar Profesores");
                Console.WriteLine("5. Mostrar Estudiantes");
                Console.WriteLine("6. Salir");
                Console.Write("Opción (1, 2, 3...): ");
                option = int.Parse(Console.ReadLine());

                

                if (option == 1)
                {
                    Console.WriteLine("Ingrese sus credenciales:");

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Identificación: ");
                    string id = Console.ReadLine();

                    Console.Write("Salario: ");
                    decimal salario = decimal.Parse(Console.ReadLine());

                    Console.Write("Materia: ");
                    string materia = Console.ReadLine();

                    Console.Write("Nivel (Primaria/Secundaria): ");
                    string nivel = Console.ReadLine();

                    maestro maestro = new maestro
                    {
                        Nombre = nombre,
                        id = id,
                        Salario = salario,
                        Materia = materia,
                        Nivel = nivel
                    };
                    service.Agregar(maestro);
                    Console.WriteLine("Información registrada");

                }
                else if (option == 2)
                {
                    Console.WriteLine("Ingrese sus credenciales:");

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Identificación: ");
                    string id = Console.ReadLine();

                    Console.Write("Carrera: ");
                    string carrera = Console.ReadLine();


                    estudiante Estudiante = new estudiante
                    {
                        Nombre = nombre,
                        id = id,
                        Carrera = carrera
                    };
                    service.Agregar(Estudiante);

                }
                else if (option == 3)
                {
                    service.ShowAll();
                }
                else if (option == 4)
                {
                    service.ShowProfesores();
                }
                else if (option == 5)
                {
                    service.ShowEstudiantes();
                }
            } while (option != 6);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

    }
}