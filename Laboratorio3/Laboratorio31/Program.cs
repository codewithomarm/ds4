using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    public static void Main(string[] args)
    {
        // Declaración de variables
        int a, b;

        // Solicitud de valores al usuario
        Console.Write("Ingrese el primer número (a): ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número (b): ");
        b = Convert.ToInt32(Console.ReadLine());

        // Instanciación del objeto calculosMatemáticos
        CalculosMatemáticos calculosMatematicos = new CalculosMatemáticos(a, b);

        Console.WriteLine("Resultado de la operación matemática (a+b)*(a-b): {0}", calculosMatematicos.Calcular());
    }
}

public class CalculosMatemáticos
{
    // Declaración de variables de instancia
    private int a;
    private int b;

    // Constructor
    public CalculosMatemáticos(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    // Calcula la suma por la diferencia de dos números
    public int Calcular()
    {
        return (a + b) * (a - b);
    }
}
