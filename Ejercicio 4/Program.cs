namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 2 de la sesion 2 
            Console.WriteLine("Hola bienvenido a la base de datos de vehiculos");
            Console.WriteLine("Por favor indicanos la cantidad de puertas que tiene tu coche");
            int puertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor indicanos la cantidad de ruedas que tiene tu coche");
            int ruedas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor indicanos la marca de tu coche");
            string? marca = Console.ReadLine();
            Console.WriteLine("Por favor indicanos si tu coche tiene la ITV vigente o no");
            string? itv = Console.ReadLine();

            Console.WriteLine("Ahora vamos a registrar los datos de tu mesa favorita");
            Console.WriteLine("Por favor indicanos el peso de tu mesa. Puedes usar un numero decimal para indicar kg y gramos si lo deseas");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor indicanos el largo de tu mesa. Puedes usar un numero decimal para indicar metros y centimetros si lo deseas");
            double largo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor indicanos el color de tu mesa");
            string? color = Console.ReadLine();
            Console.WriteLine("Por favor indicanos el material de tu mesa");
            string? material = Console.ReadLine();
            
        }
    }
}