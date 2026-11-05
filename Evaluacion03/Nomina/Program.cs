namespace Nomina;

class Program
{
    static void Main(string[] args)
    {
        const double TASA_AFP = 0.0287;
     const double TASA_SFS = 0.0304;
    // pido los datos del empleado
Console.WriteLine("Nombre del empleado: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Horas trabajadas: ");
double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Pago por hora: ");
double pagoPorHora = Convert.ToDouble(Console.ReadLine());

// salario bruto: horas por lo que se paga cada hora
double salarioBruto = horasTrabajadas * pagoPorHora;

// descuentos: porcentaje aplicado al salario bruto
double descuentoAfp = salarioBruto * TASA_AFP;
double descuentoSfs = salarioBruto * TASA_SFS;

// salario neto: lo que queda después de los descuentos
double salarioNeto = salarioBruto - descuentoAfp - descuentoSfs;

// muestro el nombre en mayúsculas y los montos con 2 decimales
Console.WriteLine($"Empleado: {nombre?.ToUpper()}");
Console.WriteLine($"Salario bruto: {salarioBruto:N2}");
Console.WriteLine($"AFP (2.87 %): {descuentoAfp:N2}");
Console.WriteLine($"SFS (3.04 %): {descuentoSfs:N2}");
Console.WriteLine($"Salario neto: {salarioNeto:N2}");
    }
}
