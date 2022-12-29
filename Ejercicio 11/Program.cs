namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 2 de la sesion 5
            Console.WriteLine("Bienvenido a tu lista de lenguajes de programacion");
            Console.WriteLine("A continuacion seleccione el lenguaje en que usted es especialista");
            Console.WriteLine("1. C#");
            Console.WriteLine("2. Java");
            Console.WriteLine("3. Python");
            Console.WriteLine("4. C++");
            Console.WriteLine("5. C");
            Console.WriteLine("6. JavaScript");
            Console.WriteLine("7. PHP");
            Console.WriteLine("8. Ruby");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Usted ha elegido C#");
                    break;
                case "2":
                    Console.WriteLine("Usted ha elegido Java");
                    break;
                case "3":
                    Console.WriteLine("Usted ha elegido Python");
                    break;
                case "4":
                    Console.WriteLine("Usted ha elegido C++");
                    break;
                case "5":
                    Console.WriteLine("Usted ha elegido C");
                    break;
                case "6":
                    Console.WriteLine("Usted ha elegido JavaScript");
                    break;
                case "7":
                    Console.WriteLine("Usted ha elegido PHP");
                    break;
                case "8":
                    Console.WriteLine("Usted ha elegido Ruby");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}