internal class Program
{
    private static void Main(string[] args)
    {
        double ladoInferior1, ladoInferior2, ladoSuperior;

        ladoInferior1 = PedirLado("primer lado inferior");
        ladoInferior2 = PedirLado("segundo lado inferior");
        ladoSuperior = PedirLado("lado superior");

        if (validarTriangulo(ladoInferior1, ladoInferior2, ladoSuperior))
        {
            if (ladoInferior1 == ladoInferior2 && ladoInferior2 == ladoSuperior)
            {
                Console.WriteLine("Triangulo Equilatero");
            }
            else if (ladoInferior1 == ladoInferior2 && ladoInferior2 != ladoSuperior)
            {
                Console.WriteLine("Triangulo Isoceles");
            }
            else
            {
                Console.WriteLine("Triangulo Escaleno");
            }
        } else
        {
            Console.WriteLine("Los lados ingresados no forman un triangulo");
        }
    }

    private static double PedirLado(string nombreLado)
    {
        double lado;
        while (true)
        {
            try
            {
                Console.WriteLine($"Ingresa la longitud del {nombreLado}:");
                lado = Convert.ToDouble(Console.ReadLine());
                if (lado <= 0)
                {
                    Console.WriteLine("Debe ingresar un numero positivo. Inténtalo de nuevo.");
                    continue;
                }
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ha ingresado un dato no numérico. Por favor ingresa un número válido.");
            }
        }
        return lado;
    }

    private static bool validarTriangulo(double ladoInferior1, double ladoInferior2, double ladoSuperior)
    {
        return ((ladoInferior1+ladoInferior2) > ladoSuperior);
    }
}