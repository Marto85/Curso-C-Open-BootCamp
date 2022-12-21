// Ejercicio 1 de la sesion 3

Cliente cliente1 = new Cliente("Felipe", "Gomez", "Calle 7 y Calle 9", "1150789563", "felipegomez@pepito.com", "si");

Console.WriteLine("Nombre: " + cliente1.Nombre);
Console.WriteLine("Apellido: " + cliente1.Apellido);
Console.WriteLine("Direccion: " + cliente1.Direccion);
Console.WriteLine("Telefono: " + cliente1.Telefono);
Console.WriteLine("Email: " + cliente1.Email);
Console.WriteLine("Activo: " + cliente1.EsNuevo);

public struct Cliente
{
    public Cliente(string nombre, string apellido, string direccion, string telefono, string? email, string? esNuevo)
    {
        Nombre = nombre;
        Apellido = apellido;
        Direccion = direccion;
        Telefono = telefono;
        Email = email;
        EsNuevo = esNuevo;
    }

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string? Email { get; set; }
    public string? EsNuevo { get; set; }

}
