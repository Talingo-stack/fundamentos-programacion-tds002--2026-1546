namespace AdivinaNumero;

class Program
{
    static void Main(string[] args)
    {
     // número secreto entre 1 y 100 (el 101 no se incluye)
int numeroSecreto = Random.Shared.Next(1, 101);

int intentos = 0;   // contador de intentos
int intento;

do
{
    Console.WriteLine("Adivina el número (1-100): ");
    string? texto = Console.ReadLine();

    if (int.TryParse(texto, out intento))
    {
        intentos++;

        // comparo con el secreto y doy una pista
        if (intento > numeroSecreto)
        {
            Console.WriteLine("El número secreto es menor.");
        }
        else if (intento < numeroSecreto)
        {
            Console.WriteLine("El número secreto es mayor.");
        }
        else
        {
            Console.WriteLine("¡Acertaste!");
        }
    }
    else
    {
        Console.WriteLine("Escriba un número entero.");
        intento = 0;   // no coincide con el secreto, así el ciclo sigue
    }
} while (intento != numeroSecreto);

Console.WriteLine($"Lo lograste en {intentos} intentos.");
    }
}
