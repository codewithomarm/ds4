using Laboratorio95;

internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.WriteLine("Generar un arreglo de numeros entre dos numeros aleatorios");
        foreach (int i in aleatorios.generarRandom())
        {
            Console.WriteLine(i);
        }
    }
}