namespace _06_Decisiones;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresar Calificación: ");
        string? textoNota = Console.ReadLine();

        int calificacion;

        // TryParse devuelve true si pudo convertir; además la nota debe estar entre 0 y 100
        if (int.TryParse(textoNota, out calificacion) && calificacion >= 0 && calificacion <= 100)
        {
            string letra;

            // se evalúa de mayor a menor; entra al primer caso que se cumpla
            if (calificacion >= 90)
            {
                letra = "A";
            }
            else if (calificacion >= 80)
            {
                letra = "B";
            }
            else if (calificacion >= 70)
            {
                letra = "C";
            }
            else
            {
                letra = "F";
            }

            Console.WriteLine($"Calificación: {calificacion} -> Letra: {letra}");
        }
        else
        {
            Console.WriteLine("Nota inválida: escriba un número entero entre 0 y 100.");
        }

        //CALCULADORA
        Console.WriteLine("Primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Opción (1 sumar, 2 restar, 3 multiplicar, 4 dividir): ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        // switch elige qué hacer según el valor de opcion
        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Resultado: {numero1 + numero2}");
                break;
            case 2:
                Console.WriteLine($"Resultado: {numero1 - numero2}");
                break;
            case 3:
                Console.WriteLine($"Resultado: {numero1 * numero2}");
                break;
            case 4:
                // si el divisor es 0, muestro un mensaje en vez de dividir
                if (numero2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre 0.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {numero1 / numero2}");
                }
                break;
            default:
                Console.WriteLine("Opción inválida: use 1, 2, 3 o 4.");
                break;
        }
    }
}
