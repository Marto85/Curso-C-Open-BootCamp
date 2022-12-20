namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 2 de la sesion 1
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("La hora actual es {0}", time);
        }
    }
}