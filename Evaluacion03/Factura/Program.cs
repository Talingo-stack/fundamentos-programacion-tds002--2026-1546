namespace Factura;

class Program
{
    static void Main(string[] args)
    {
        // ITBIS: impuesto del 18 %, expresado como decimal
const double TASA_ITBIS = 0.18;

Console.WriteLine("Producto: ");
string? producto = Console.ReadLine();

Console.WriteLine("Cantidad: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Precio unitario: ");
double precio = Convert.ToDouble(Console.ReadLine());

// subtotal: cantidad por precio
double subtotal = cantidad * precio;

// ITBIS: porcentaje sobre el subtotal
double itbis = subtotal * TASA_ITBIS;

// total: subtotal más impuesto
double total = subtotal + itbis;

// encabezado de la factura: texto a la izquierda (-), números a la derecha
Console.WriteLine($"{"Producto",-15}{"Cant.",6}{"Precio",12}");
Console.WriteLine($"{producto,-15}{cantidad,6}{precio,12:N2}");
Console.WriteLine(new string('-', 33));

// totales, alineados en la misma columna de los precios
Console.WriteLine($"{"Subtotal",-21}{subtotal,12:N2}");
Console.WriteLine($"{"ITBIS (18 %)",-21}{itbis,12:N2}");
Console.WriteLine($"{"Total",-21}{total,12:N2}");
    }
}
