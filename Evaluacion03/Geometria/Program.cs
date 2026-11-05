namespace Geometria;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Radio del círculo: ");
double radio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Primer cateto del triángulo: ");
double cateto1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Segundo cateto del triángulo: ");
double cateto2 = Convert.ToDouble(Console.ReadLine());

// área del círculo: π por radio al cuadrado
double area = Math.PI * Math.Pow(radio, 2);

// circunferencia: 2 por π por radio
double circunferencia = 2 * Math.PI * radio;

// hipotenusa (teorema de Pitágoras): raíz de la suma de los catetos al cuadrado
double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

Console.WriteLine($"Área del círculo: {area:F2}");
Console.WriteLine($"Circunferencia: {circunferencia:F2}");
Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
    }
}
