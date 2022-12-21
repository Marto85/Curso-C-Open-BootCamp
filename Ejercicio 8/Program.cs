namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 2 de la sesion 4
            Console.WriteLine("Buenos dias. Elija un numero entero desde el cual quiere iniciar a contar");
            int inicio = Convert.ToInt32(Console.ReadLine());
            
            
            if (inicio == 0)
            {
                Console.WriteLine("El numero que ha elegido es 0. Por favor, elija un numero positivo o negativo para iniciar el contador");

            }
            else
            {
                Console.WriteLine("Elija un numero entero hasta el cual quiere contar");
                int fin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El contador para sus numeros seleccionados es el siguiente:");
                
                do
                {
                    Console.WriteLine(inicio);
                    inicio++;
                }
                while (inicio <= fin);

            }   
            
        }
    }
}