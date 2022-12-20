namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1 de la sesion 2 
            Console.WriteLine("Hola, bienvenido a nuestra base de datos");
            Console.WriteLine("Por favor ingresa tu nombre");
            string? nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingresa tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingresa tu genero");
            string? genero = Console.ReadLine();
            Console.WriteLine("Por favor ingresa tu ciudad");
            string? ciudad = Console.ReadLine();
            Console.WriteLine("Muchas gracias por tu informacion");
        }
    }
}