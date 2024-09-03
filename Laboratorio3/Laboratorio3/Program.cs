internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumbero, suma;

        Console.Write("Introduce el primero numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero: ");
        segundoNumbero = Convert.ToInt32(Console.ReadLine());

        suma = primerNumero + segundoNumbero;

        Console.WriteLine("La suma de {0} y {1} es {2}", primerNumero, segundoNumbero, suma);
    }
}
