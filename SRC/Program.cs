//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 2 - Patrones de Diseño - Object Pool y Singleton
using System;


namespace EquiposObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equipo disponible y horarios de laboratorio\n");

            var admin = AdministradorEquipos.Instancia;
            admin.Inicializar(5);
            var pool = admin.Pool; 

            bool salir = false;

            while (!salir)
            {
                pool.MostrarEstatus();

                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Ocupar equipo");
                Console.WriteLine("2. Liberar equipo");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Número de equipo a ocupar: ");
                        if (int.TryParse(Console.ReadLine(), out int numOcupar))
                        {
                            var eq = pool.BuscarEquipo(numOcupar);
                            if (eq != null)
                            {
                                Console.Write("Nombre de persona a utilizar equipo: ");
                                string cliente = Console.ReadLine();
                                eq.Ocupar(cliente);
                            }
                            else
                            {
                                Console.WriteLine("No se encontró el equipo indicado.");
                            }
                        }
                        break;

                    case "2":
                        Console.Write("Número de equipo a liberar: ");
                        if (int.TryParse(Console.ReadLine(), out int numLiberar))
                        {
                            var eq = pool.BuscarEquipo(numLiberar);
                            if (eq != null)
                            {
                                eq.Liberar();
                            }
                            else
                            {
                                Console.WriteLine("No se encontró el equipo indicado.");
                            }
                        }
                        break;

                    case "3":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Saliendo del sistema...");
        }
    }
}
