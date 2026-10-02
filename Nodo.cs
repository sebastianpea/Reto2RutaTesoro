namespace Reto2RutaTesoro;

/// <summary>
/// Representa una ubicación individual en el mapa de la ruta del tesoro.
/// Actúa como el nodo fundamental de la lista simplemente enlazada.
/// </summary>
public class Nodo
{
    // Propiedades de la ubicación
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Pista { get; set; }
    public int Peligro { get; set; } // Escala de 1 a 10

    // Referencia al siguiente nodo en la ruta
    public Nodo? Siguiente { get; set; }

    /// <summary>
    /// Constructor para inicializar una ubicación con sus datos obligatorios.
    /// El apuntador Siguiente se inicializa en null por defecto.
    /// </summary>
    public Nodo(int id, string nombre, string pista, int peligro)
    {
        Id = id;
        Nombre = nombre;
        Pista = pista;
        Peligro = peligro;
        Siguiente = null;
    }

    public override string ToString()
    {
        return $"[ID: {Id}] {Nombre} (Peligro: {Peligro}/10)";
    }
}
