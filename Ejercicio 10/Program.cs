namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1 de la sesion 5
            Console.WriteLine("Buenos dias. Vamos a solicitarles ciertos datos");
            Console.WriteLine("Por favor, indique su nombre");
            string? nombre = Console.ReadLine();
            Console.WriteLine("Por favor, indique su email");
            string? email = Console.ReadLine();
            Console.WriteLine("Por favor, indique si dispone de un cupon de descuento. Indique si o no");
            bool cupon = Convert.ToBoolean(Console.ReadLine());

            if (cupon == true)
            {
                Console.WriteLine("Por favor, indique el valor del producto");
                double valorProducto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Por favor, indique el % de descuento que dispone");
                double cuponDesc = Convert.ToDouble(Console.ReadLine());
                double pctCupon = cuponDesc / 100;
                Console.WriteLine("El valor final de la compra es de " + (valorProducto - (valorProducto * pctCupon)));
            }
            else
            {
                Console.WriteLine("Por favor, indique el valor de la compra");
                double valorCompra = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El valor final de la compra es de " + valorCompra);
            }
        }
    }
}