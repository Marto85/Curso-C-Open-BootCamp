namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 3 de la sesion 4
            Console.WriteLine("Buenos dias. Vamos a armar un rectangulo o un cuadrado con asteriscos.");
            Console.WriteLine("Elija la altura por favor.");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elija la anchura por favor.");
            int anchura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A continuacion mencione si desea dibujar unicamente las esquinas o si desea rellenarlo.");
            Console.WriteLine("Si desea dibujar las esquinas, escriba 1. Si desea rellenarlo, escriba 2.");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por ultimo, indique por favor cuantos rectangulos o cuadrados desea dibujar.");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    for (int j = 0; j < altura; j++)
                    {
                        for (int k = 0; k < anchura; k++)
                        {
                            if (j == 0 || j == altura - 1 || k == 0 || k == anchura - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
            else if (opcion == 2)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    for (int j = 0; j < altura; j++)
                    {
                        for (int k = 0; k < anchura; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("La opcion que ha elegido no es valida. Por favor, elija 1 o 2");
            }          

        }
    }
}