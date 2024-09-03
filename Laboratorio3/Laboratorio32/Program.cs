using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa para calcular el área de un círculo");

        // Declaración de variables
        double radio;

        // Solicitud de valores al usuario
        Console.Write("Ingrese el radio del círculo: ");
        radio = Convert.ToInt64(Console.ReadLine());

        // Instanciación del objeto calculosMatemáticos
        CalculosMatemáticos calculosMatematicos = new CalculosMatemáticos(radio);

        // Imprimir resultados por consola
        Console.WriteLine("Área del círculo con radio {0} es: {1}", radio, calculosMatematicos.CalculoArea());
    }
}

public class CalculosMatemáticos
{
    // Declaración de variables de instancia
    private double radio;

    // Constructor
    public CalculosMatemáticos(double radio)
    {
        this.radio = radio;
    }

    // Calcula el área del círculo
    public double CalculoArea()
    {
        return 3.14 * (radio*radio);
    }
}
