namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1 de la sesion 4
            Console.WriteLine("Buenos dias. Elija un numero entre el 1 y el 10 para crear su tabla de multiplicar");
            int i = Convert.ToInt32(Console.ReadLine());
            int multiplicador = 1;
            if (i > 10)
            {
                Console.WriteLine("El numero que ha elegido es mayor que 10. Por favor, elija un numero entre el 1 y el 10");
            }
            while (multiplicador < 11)
            {
                Console.WriteLine(i + " x " + multiplicador + " = " + i * multiplicador);
                multiplicador++;              
            }

        }
    }
}