using Laboratorio94;

internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.WriteLine("Generar un numero entre 2 numeros");
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(aleatorios.generarRandom(num1, num2));
        Console.WriteLine();

        Console.WriteLine("Generar un arreglo de numeros entre dos numeros aleatorios");
        foreach(int i in aleatorios.generarRandom()){
            Console.WriteLine(i);
        }
    }
}