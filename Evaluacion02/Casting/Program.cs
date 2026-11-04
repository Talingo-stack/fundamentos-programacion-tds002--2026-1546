namespace Casting;

class Program
{
    static void Main(string[] args)
    {
        // pido un número con decimales y lo guardo como double
Console.WriteLine("Ingrese un número con decimales: ");
double numeroDecimal = Convert.ToDouble(Console.ReadLine());

// casting explícito: (int) corta los decimales y deja solo la parte entera
int parteEntera = (int)numeroDecimal;

// casting implícito: un int cabe en un double, así que C# lo convierte solo
double enteroComoDouble = parteEntera;

// muestro los resultados con interpolación
Console.WriteLine($"Número ingresado: {numeroDecimal}");
Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");
Console.WriteLine($"Entero guardado en un double (casting implícito): {enteroComoDouble}");
    }
}
