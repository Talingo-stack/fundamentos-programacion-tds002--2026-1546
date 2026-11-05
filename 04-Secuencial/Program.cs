namespace _04_Secuencial;

class Program
{
    static void Main(string[] args)
    {
       const double KG_POR_LIBRA = 0.453592; // Constante para la conversión de libras a kilogramos
       //se solicita el peso en libras al usuario
       Console.WriteLine("Ingrese su peso en libras: ");
       double libras = Convert.ToDouble(Console.ReadLine());

       //se pide la temperatura
       Console.WriteLine("Ingrese la temperatura en °F: ");
       double fahrenheit = Convert.ToDouble(Console.ReadLine());
    
    double kilogramos = libras * KG_POR_LIBRA;
    double celsius = (fahrenheit - 32) * 5/9;

    // muestro los resultados con dos decimales
Console.WriteLine($"{libras} lb equivalen a {kilogramos:F2} kg");
Console.WriteLine($"{fahrenheit} °F equivalen a {celsius:F2} °C");
    }
}
