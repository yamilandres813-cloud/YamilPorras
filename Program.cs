using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración e inicialización de arreglos y variables
            string[] pacientes = new string[14];
            int[] urgencias = new int[14];
            int cantidad = 0;
            int opcion = 0;

            do
            {
                // Mostrar menú principal
                Console.WriteLine("=== MENU PRINCIPAL ===");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Mostrar pacientes");
                Console.WriteLine("3. Modificar urgencia");
                Console.WriteLine("4. Eliminar paciente");
                Console.WriteLine("5. Salir");
                Console.Write("Digite una opcion: ");

                // Validar que el usuario ingrese un número
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0; // Opción inválida si se ingresa texto
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        // 1. Registrar paciente
                        if (cantidad < 14)
                        {
                            Console.Write("Nombre del paciente: ");
                            pacientes[cantidad] = Console.ReadLine();

                            int nivel;
                            do
                            {
                                Console.Write("Nivel de urgencia (1-5): ");
                                int.TryParse(Console.ReadLine(), out nivel);

                                if (nivel < 1 || nivel > 5)
                                {
                                    Console.WriteLine("Error. El nivel debe estar entre 1 y 5.");
                                }
                            } while (nivel < 1 || nivel > 5);

                            urgencias[cantidad] = nivel;
                            cantidad++;

                            Console.WriteLine("Paciente registrado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No hay espacio disponible.");
                        }
                        break;

                    case 2:
                    case 3:
                    case 4:
                        // Opciones que requieren listar pacientes
                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay pacientes registrados.");
                        }
                        else
                        {
                            Console.WriteLine("=== LISTA DE PACIENTES ===");
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine($"{i + 1}. {pacientes[i]} - Urgencia: {urgencias[i]}");
                            }
                            Console.WriteLine();

                            // Modificar urgencia
                            if (opcion == 3)
                            {
                                Console.Write("Digite el numero del paciente a modificar: ");
                                int.TryParse(Console.ReadLine(), out int posicion);

                                if (posicion >= 1 && posicion <= cantidad)
                                {
                                    int nuevoNivel;
                                    do
                                    {
                                        Console.Write("Digite el nuevo nivel de urgencia (1-5): ");
                                        int.TryParse(Console.ReadLine(), out nuevoNivel);

                                        if (nuevoNivel < 1 || nuevoNivel > 5)
                                        {
                                            Console.WriteLine("Error. El nivel debe estar entre 1 y 5.");
                                        }
                                    } while (nuevoNivel < 1 || nuevoNivel > 5);

                                    urgencias[posicion - 1] = nuevoNivel;
                                    Console.WriteLine("Urgencia modificada correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("Paciente no encontrado.");
                                }
                            }

                            // Eliminar paciente sin bucle de desplazamiento
                            if (opcion == 4)
                            {
                                Console.Write("Digite el numero del paciente a eliminar: ");
                                int.TryParse(Console.ReadLine(), out int posicion);

                                if (posicion >= 1 && posicion <= cantidad)
                                {
                                    int indiceEliminar = posicion - 1;
                                    int ultimoIndice = cantidad - 1;

                                    // Copiamos los datos del último registro en la posición que queremos borrar
                                    pacientes[indiceEliminar] = pacientes[ultimoIndice];
                                    urgencias[indiceEliminar] = urgencias[ultimoIndice];

                                    // Reducimos el conteo total
                                    cantidad--;

                                    Console.WriteLine("Paciente eliminado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("Paciente no encontrado.");
                                }
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

                //limpiar pantalla si no se ha elegido salir
                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 5);
        }
    }
}
