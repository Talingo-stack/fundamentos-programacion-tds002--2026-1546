namespace FichaPersonal;

class Program
{
    static void Main(string[] args)
    {//Se le solicita el nombre al usuario y se guarda en la variable nombre
        Console.WriteLine("Cual es tu nombre?");
        String? nombre = Console.ReadLine();
//Se le solicita la edad al usuario y se guarda en la variable edad
        Console.WriteLine("Cual es tu edad?");
        int edad = Convert.ToInt32(Console.ReadLine());
//Se le solicita la estatura al usuario y se guarda en la variable estatura
        Console.WriteLine("Cual es tu estatura?");
        double estatura = Convert.ToDouble(Console.ReadLine());
//Se le pregunta al usuario si trabaja, el usuario escribre true o false y se guarda en la variable trabaja, no se como poner que diga si o no :c
        Console.WriteLine("Trabajas? (true/false)");
        bool trabaja = Convert.ToBoolean(Console.ReadLine());
// se reeliza el calculo de los años que faltan para que el usuario cumpla 30 años y se guarda en la variable anosfaltantes
const int ANIO_ACTUAL = 2026; 
int anosfaltantes = 30 - edad; 
int anioTreinta = ANIO_ACTUAL + anosfaltantes; 
//Se muestra en pantalla el mensaje que indica todo los datos anteriores y los calculos realizados
Console.WriteLine($"Hola {nombre}, tienes {edad} años y mides {estatura} m. Naciste en el año: {ANIO_ACTUAL - edad}. Te faltan {anosfaltantes} años para cumplir 30, lo cual será en el año {anioTreinta}. Trabajas? {trabaja}");
 
    }
}
