internal class Program
{
    private static void Main(string[] args)
    {
        int precioProducto = 0;
        Console.Write("Porfavor ingrese el precio del producto: ");
        try
        {
            precioProducto = int.Parse(Console.ReadLine());
            if (precioProducto <= 0)
            {
                Console.WriteLine("Ha ingresado un valor menor o igual a cero");
            }
            Console.WriteLine("Porfavor ingrese la forma de pagar");
            Console.WriteLine("1: Efectivo || 2: Tarjeta");
            Console.Write("Forma de pago: ");
            try
            {
                int formaPago = int.Parse(Console.ReadLine());
                switch (formaPago)
                {
                    case 1:
                        Console.WriteLine("Gracias por pagar el producto");
                        break;
                    case 2:
                        Console.Write("Ingrese los 16 digitos de la tarjeta: ");
                        try
                        {
                            int numerosTarjeta = int.Parse(Console.ReadLine());
                            if (numerosTarjeta.ToString().Length == 16)
                            {
                                Console.WriteLine("Gracias por pagar el producto");
                            } else
                            {
                                Console.WriteLine("Tarjeta de credito invalida");
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Ha ingresado un valor no numerico.");
                        }
                        break;
                    default:
                        Console.WriteLine("Selecciono una opcion no valida");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ha ingresado un valor no numerico.");
            }

        } catch (FormatException e)
        {
            Console.WriteLine("Ha ingresado un valor no numerico.");
        }
        
    }
}