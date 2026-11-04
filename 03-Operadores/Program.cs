namespace _03_Operadores;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Ingrese el primer numero entero (x): ");
       int x = Convert.ToInt32(Console.ReadLine());
    
         Console.WriteLine("Ingrese el segundo numero entero (y): ");
         int y = Convert.ToInt32(Console.ReadLine());

         //Operadores ari1tmeticos basicos
         int suma = x + y;
         int resta = x - y;
         int multiplicacion = x * y;

         //Se convierte a double para obtener un resultado decimal en la division
         double divisionReal = (double)x / y;

         //entre dos int, c# corta los decimales
         int divisionEntera = x / y;
         
         //Lo que sobra de la division de x entre y
         int residuo = x % y;
         
         //x es par si al dividirlo entre 2 no sobra nada
         bool esPar = (x % 2 == 0);    

         Console.WriteLine($"Suma: {suma}");
         Console.WriteLine($"Resta: {resta}");
         Console.WriteLine($"Multiplicacion: {multiplicacion}");
         Console.WriteLine($"Division real: {divisionReal}");
         Console.WriteLine($"Division entera: {divisionEntera}");
         Console.WriteLine($"Residuo: {residuo}");
         Console.WriteLine($"El primero es par?: {esPar}");


    }
}

/*
PRUEBA DE ESCRITORIO   x = 10, y = 3
x                = 10
y                = 3
suma             = 10 + 3       = 13
resta            = 10 - 3       = 7
multiplicacion   = 10 * 3       = 30
divisionReal     = 10.0 / 3     = 3.3333...
divisionEntera   = 10 / 3       = 3
residuo          = 10 % 3       = 1
esPar            = 10 % 2 == 0  = true
*/

