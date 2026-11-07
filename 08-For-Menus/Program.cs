namespace _08_For_Menus;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

do
{
    // muestro las opciones cada vez que se repite el menú
    Console.WriteLine("\n===== MENÚ =====");
    Console.WriteLine("1. Tablas de multiplicar");
    Console.WriteLine("2. Triángulo de asteriscos");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Elija una opción: ");
    string? textoOpcion = Console.ReadLine();

    // si no escribe un número, uso -1 para que caiga en el default del switch
    if (!int.TryParse(textoOpcion, out opcion))
    {
        opcion = -1;
    }

    // aquí va el switch 

} while (opcion != 0);

switch (opcion)
    {
        case 1:
            // paso 4: tablas
            break;
        case 2:
            // paso 5: triángulo
            break;
        case 0:
            Console.WriteLine("Hasta luego.");
            break;
        default:
            Console.WriteLine("Opción inválida: use 1, 2 o 0.");
            break;
    }

    // ciclo de afuera: una fila por cada número del 1 al 10
            for (int fila = 1; fila <= 10; fila++)
            {
                // ciclo de adentro: las 10 columnas de esa fila
                for (int columna = 1; columna <= 10; columna++)
                {
                    // ,4 reserva 4 espacios para alinear a la derecha
                    Console.Write($"{fila * columna,4}");
                }

                // al terminar las columnas, salto a la siguiente línea
                Console.WriteLine();
            }
            Console.WriteLine("Número de filas del triángulo: ");
            string? textoFilas = Console.ReadLine();

            // valido que sea un entero mayor que 0
            if (int.TryParse(textoFilas, out int filas) && filas > 0)
            {
                // ciclo de afuera: una fila por vuelta
                for (int fila = 1; fila <= filas; fila++)
                {
                    // ciclo de adentro: tantos asteriscos como el número de fila
                    for (int asterisco = 1; asterisco <= fila; asterisco++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Escriba un número entero mayor que 0.");
            }
    }
}
