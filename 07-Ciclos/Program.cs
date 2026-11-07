namespace _07_Ciclos;

class Program
{
    static void Main(string[] args)
    {
        // ---------- 1. PEDIR UN NÚMERO ENTRE 1 Y 12 ----------
        int numero;
        bool esValido;

        do
        {
            Console.WriteLine("Ingrese un número entre 1 y 12: ");
            string? texto = Console.ReadLine();

            // TryParse convierte sin caerse; además el número debe estar entre 1 y 12
            esValido = int.TryParse(texto, out numero) && numero >= 1 && numero <= 12;

            if (!esValido)
            {
                Console.WriteLine("Número inválido, intente de nuevo.");
            }
        } while (!esValido);

        // ---------- 2. TABLA DE MULTIPLICAR DEL 1 AL 12 ----------
        int contador = 1;   // cuenta de 1 a 12
        int suma = 0;       // acumulador: va sumando cada resultado

        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");

            // sumo este resultado al total
            suma += resultado;

            // avanzo el contador; sin esto el ciclo nunca terminaría
            contador++;
        }

        // ---------- 3. SUMA DE TODOS LOS RESULTADOS ----------
        Console.WriteLine($"Suma de todos los resultados: {suma}");
    }
}
