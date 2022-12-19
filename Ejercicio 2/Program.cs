namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("La hora actual es {0}", time);
        }
    }
}