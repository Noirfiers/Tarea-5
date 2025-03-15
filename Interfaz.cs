using System;
using System.Collections.Generic;

namespace Tarea_5_laboratorio_Grupo_4
{
    class Program
    {
        static List<Videojuego> videojuegos = new List<Videojuego>();
        static List<Cliente> clientes = new List<Cliente>();
        static List<IDS> ventas = new List<IDS>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Agregar Videojuego");
                Console.WriteLine("2. Listar Videojuegos");
                Console.WriteLine("3. Realizar Venta");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AgregarVideojuego();
                        break;
                    case "2":
                        ListarVideojuegos();
                        break;
                    case "3":
                        RealizarVenta();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;

                }
            }
        }

        static void AgregarVideojuego()
        {
            try
            {
                Console.Write("ID del videojuego: ");
                string id = Console.ReadLine();

                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Console.Write("Stock inicial: ");
                int stock = int.Parse(Console.ReadLine());

                videojuegos.Add(new Videojuego(id, titulo, precio, stock));
                Console.WriteLine("¡Videojuego agregado!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void ListarVideojuegos()
        {
            Console.WriteLine("\n=== VIDEOJUEGOS DISPONIBLES ===");
            foreach (var juego in videojuegos)
            {
                Console.WriteLine(juego.ToString());
            }
        }

        static void RealizarVenta()
        {
            try
            {
                Console.Write("ID de venta: ");
                string idVenta = Console.ReadLine();

                Console.Write("ID del cliente: ");
                string idCliente = Console.ReadLine();

                Console.Write("ID del videojuego: ");
                string idVideojuego = Console.ReadLine();

                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                var venta = new IDS(idVenta, idCliente, idVideojuego, cantidad);
                ventas.Add(venta);
                Console.WriteLine("¡Venta registrada!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}