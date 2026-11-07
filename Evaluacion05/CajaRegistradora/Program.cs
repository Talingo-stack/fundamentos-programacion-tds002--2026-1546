namespace CajaRegistradora;

class Program
{
    static void Main(string[] args)
    {
      // ITBIS: impuesto del 18 %, expresado como decimal
const double TASA_ITBIS = 0.18;

int cantidadProductos = 0;   // contador: cuántos productos se registraron
double subtotal = 0;         // acumulador: suma de todos los precios
double precio;

do
{
    Console.WriteLine("Ingrese el precio del producto (0 para terminar): ");
    string? texto = Console.ReadLine();

    // TryParse evita que el programa se caiga si escriben letras
    if (!double.TryParse(texto, out precio) || precio < 0)
    {
        Console.WriteLine("Precio inválido, intente de nuevo.");
        precio = -1;   // fuerzo que el ciclo continúe
    }
    else if (precio > 0)
    {
        // precio válido: cuento el producto y lo sumo al subtotal
        cantidadProductos++;
        subtotal += precio;
    }
} while (precio != 0);

double itbis = subtotal * TASA_ITBIS;
double total = subtotal + itbis;

Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {subtotal:N2}");
Console.WriteLine($"ITBIS (18 %): {itbis:N2}");
Console.WriteLine($"Total: {total:N2}");
    }
}

