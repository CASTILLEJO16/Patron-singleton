public class Operador
{
    public int Id_Operador { get; set; }
    public string Nombre { get; set; }

    public Operador(int id, string nombre)
    {
        Id_Operador = id;
        Nombre = nombre;
    }

    public void AtiendeEmergencia(string tipoEmergencia)
    {
        Console.WriteLine($"Operador {Nombre} atendiendo emergencia de tipo: {tipoEmergencia}");

        switch (tipoEmergencia)
        {
            case "Intento de suicidio":
                Console.WriteLine("Enviando unidades de apoyo y rescate");
                break;
            case "Incendio":
                Console.WriteLine("Enviando bomberos.");
                break;
            case "Accidente":
                Console.WriteLine("Enviado paramedicos y oficiales.");
                break;
            case "Violeta":
                Console.WriteLine("Enviando una patrulla.");
                break;
            case "Robo en progreso":
                Console.WriteLine("Enviando unidades de  patrulla.");
                break;
            case "Accidente de tráfico":
                Console.WriteLine("Enviando unidades de ambulancia.");
                break;
            default:
                Console.WriteLine("Tipo de emergencia no reconocido.");
                break;
        }
    }
}