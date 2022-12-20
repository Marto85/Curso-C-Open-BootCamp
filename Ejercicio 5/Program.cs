namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 3 de la sesion 2 
            Console.WriteLine("Por favor ingresa un numero para verificar condiciones");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Es mayor o igual a 18? " + (numero >= 18));

            Console.WriteLine("Ahora por favor ingresa la letra a para verificar condiciones");
            char letra = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Es la letra a? " + (letra == 'a'));

            Console.WriteLine("Ahora por favor ingresa un numero mayor a 1 y menor a 10 para verificar condiciones");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Es mayor a 1 y menor a 10? " + (numero2 > 1 && numero2 < 10));

            Console.WriteLine("Ahora por favor dime si esta soleado o nublado");
            string? clima = Console.ReadLine();
            Console.WriteLine("Esta soleado o nublado? " + (clima == "soleado" || clima == "nublado"));


        }
    }
}