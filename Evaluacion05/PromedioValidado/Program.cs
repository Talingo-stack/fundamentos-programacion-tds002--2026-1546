namespace PromedioValidado;

class Program
{
    static void Main(string[] args)
    {
        int cantidadNotas = 0;   // contador de notas válidas
int suma = 0;            // acumulador para el promedio
int notaMayor = 0;       // 0 es el mínimo posible, cualquier nota la supera o iguala
int notaMenor = 100;     // 100 es el máximo posible, cualquier nota la baja o iguala
int nota = 0;

do
{
    // ciclo interno: repite hasta que la entrada sea válida (0-100, o -1 para terminar)
    bool esValida;
    do
    {
        Console.WriteLine("Ingrese una nota (0-100) o -1 para terminar: ");
        string? texto = Console.ReadLine();

        esValida = int.TryParse(texto, out nota) && (nota == -1 || (nota >= 0 && nota <= 100));

        if (!esValida)
        {
            Console.WriteLine("Entrada inválida, intente de nuevo.");
        }
    } while (!esValida);

    // el -1 es solo la señal de salida, no es una nota
    if (nota != -1)
    {
        cantidadNotas++;
        suma += nota;

        if (nota > notaMayor)
        {
            notaMayor = nota;
        }
        if (nota < notaMenor)
        {
            notaMenor = nota;
        }
    }
} while (nota != -1);

// evito dividir entre 0 si no se ingresó ninguna nota
if (cantidadNotas > 0)
{
    // casting a double para que el promedio conserve los decimales
    double promedio = (double)suma / cantidadNotas;

    Console.WriteLine($"Promedio: {promedio:F2}");
    Console.WriteLine($"Nota mayor: {notaMayor}");
    Console.WriteLine($"Nota menor: {notaMenor}");
}
else
{
    Console.WriteLine("No se ingresaron notas.");
}
    }
}
