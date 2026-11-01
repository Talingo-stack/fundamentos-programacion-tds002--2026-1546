Console.WriteLine("Cual es tu nombre?");
String? nombre = Console.ReadLine();

Console.WriteLine("Cual es tu edad?");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cual es tu estatura?");
double estatura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Hola {nombre}, tienes {edad} años y mides {estatura} m.");
const int ANIO_ACTUAL = 2026;
Console.WriteLine($"Naciste en el año: {ANIO_ACTUAL - edad}");
