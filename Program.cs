internal class Program
{
    static void Main(string[] args)
    {
        Central_911 Llamada1 = Central_911.Obtener_Instancia();
        Central_911 Llamada2 = Central_911.Obtener_Instancia();
        Central_911 Llamada3 = Central_911.Obtener_Instancia();
        Central_911 Llamada4 = Central_911.Obtener_Instancia();
        Central_911 Llamada5 = Central_911.Obtener_Instancia();

        Operador op1 = new Operador(1, "Laura");
        Operador op2 = new Operador(2, "Carlos");
        Operador op3 = new Operador(3, "María");
        Operador op4 = new Operador(4, "Jorge");
        Operador op5 = new Operador(5, "Pedro");

        Llamada1.ConectarLlamada(op1, "Incendio");
        Llamada2.ConectarLlamada(op2, "Violeta");
        Llamada3.ConectarLlamada(op3, "Accidente");
        Llamada5.ConectarLlamada(op5, "Accidente de tráfico");
        Llamada4.ConectarLlamada(op4, "Robo en progreso");
        Llamada4.ConectarLlamada(op4, "Intento de suicidio");


        Console.WriteLine("\nReferenceEquals: " + ReferenceEquals(Llamada1, Llamada2));
        Console.WriteLine("\nPresiona Enter para salir...");
        Console.ReadLine();
    }
}
