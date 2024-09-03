internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa para calcular el perímetro de un rectángulo");

        // Declaración de variables
        double lado1;
        double lado2;

        // Solicitud de valores al usuario
        Console.Write("Ingrese el valor del lado 1 del rectángulo: ");
        lado1 = Convert.ToInt64(Console.ReadLine());

        Console.Write("Ingrese el valor del lado 2 del rectángulo: ");
        lado2 = Convert.ToInt64(Console.ReadLine());

        // Instanciación del objeto calculosMatemáticos
        CalculosMatemáticos calculosMatematicos = new CalculosMatemáticos(lado1, lado2);

        // Imprimir resultados por consola
        Console.WriteLine("Perímetro del rectángulos con lados {0} y {1}: {2}", lado1, lado2, calculosMatematicos.CalculoPerimetro());
    }
}

public class CalculosMatemáticos
{
    // Declaración de variables de instancia
    private double lado1;
    private double lado2;

    // Constructor
    public CalculosMatemáticos(double lado1, double lado2)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
    }

    // Calcula el perímetro del rectángulo
    public double CalculoPerimetro()
    {
        return 2*(lado1+lado2);
    }
}
