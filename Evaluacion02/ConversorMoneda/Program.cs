namespace ConversorMoneda;

class Program
{
    static void Main(string[] args)
    {
        //Se define la tasa de conversión de pesos a dólares
        const double TASA_USD = 60.03;
        //Se solicita al usuario que ingrese la cantidad de pesos a convertir
Console.WriteLine("Ingrese la cantidad de pesos a convertir a dólares:");
//Se lee la cantidad de pesos ingresada por el usuario y se convierte a tipo double
double pesos = Convert.ToDouble(Console.ReadLine());
//Se realiza la conversión de pesos a dólares utilizando la tasa de conversión definida anteriormente, dividiendo la cantidad de pesos entre la tasa de conversión y se guarda en la variable montoDolares  
double montoDolares = pesos / TASA_USD;
//Se muestra en pantalla el resultado de la conversión, formateando el monto en dólares a dos decimales
Console.WriteLine($"El monto en dólares es: {montoDolares:F2}");
    }
}
