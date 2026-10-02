namespace Reto2RutaTesoro;

/// <summary>
/// Estructura de datos de Lista Simplemente Enlazada construida desde cero.
/// Cumple estrictamente con la restricción de no usar colecciones predefinidas
/// (List, LinkedList, Queue, Stack, Dictionary, ni arreglos como almacenamiento).
/// </summary>
public class ListaSimple
{
    /// <summary>
    /// Puntero de referencia al primer nodo de la lista (cabeza).
    /// Si la lista está vacía, Inicio es null.
    /// </summary>
    public Nodo? Inicio { get; private set; }

    public ListaSimple()
    {
        Inicio = null;
    }

    /// <summary>
    /// Indica si la lista carece de elementos.
    /// </summary>
    public bool EstaVacia => Inicio == null;

    /// <summary>
    /// Verifica si ya existe una ubicación con el ID indicado.
    /// </summary>
    public bool Existe(int id)
    {
        return Buscar(id) != null;
    }

    /// <summary>
    /// Inserta una nueva ubicación al final de la ruta del tesoro.
    /// </summary>
    /// <param name="nuevo">El nodo que representa la nueva ubicación.</param>
    /// <returns>True si se insertó con éxito, False si ya existe un nodo con ese ID.</returns>
    public bool InsertarFinal(Nodo nuevo)
    {
        if (nuevo == null) return false;

        // Validar que el ID sea único
        if (Existe(nuevo.Id))
        {
            return false;
        }

        // Caso 1: La lista está vacía
        if (Inicio == null)
        {
            Inicio = nuevo;
            return true;
        }

        // Caso 2: Recorrer hasta el último nodo
        Nodo actual = Inicio;
        while (actual.Siguiente != null)
        {
            actual = actual.Siguiente;
        }

        actual.Siguiente = nuevo;
        return true;
    }

    /// <summary>
    /// Inserta una nueva ubicación al inicio de la ruta del tesoro.
    /// </summary>
    /// <param name="nuevo">El nodo que representa la nueva ubicación.</param>
    /// <returns>True si se insertó con éxito, False si ya existe un nodo con ese ID.</returns>
    public bool InsertarInicio(Nodo nuevo)
    {
        if (nuevo == null) return false;

        // Validar que el ID sea único
        if (Existe(nuevo.Id))
        {
            return false;
        }

        nuevo.Siguiente = Inicio;
        Inicio = nuevo;
        return true;
    }

    /// <summary>
    /// Inserta una nueva ubicación en una posición específica (base 1).
    /// </summary>
    public bool InsertarEnPosicion(int posicion, Nodo nuevo)
    {
        if (nuevo == null || posicion < 1) return false;

        if (Existe(nuevo.Id))
        {
            return false;
        }

        // Si la posición es 1 o la lista está vacía, se inserta al inicio
        if (posicion == 1 || Inicio == null)
        {
            return InsertarInicio(nuevo);
        }

        Nodo actual = Inicio;
        int contador = 1;

        // Avanzar hasta la posición previa
        while (actual.Siguiente != null && contador < posicion - 1)
        {
            actual = actual.Siguiente;
            contador++;
        }

        nuevo.Siguiente = actual.Siguiente;
        actual.Siguiente = nuevo;
        return true;
    }

    /// <summary>
    /// Busca un nodo por su identificador único (ID).
    /// Recorre la lista de forma secuencial desde Inicio hasta NULL.
    /// </summary>
    /// <param name="id">ID de la ubicación a buscar.</param>
    /// <returns>El nodo correspondiente o null si no se encuentra.</returns>
    public Nodo? Buscar(int id)
    {
        Nodo? actual = Inicio;
        while (actual != null)
        {
            if (actual.Id == id)
            {
                return actual;
            }
            actual = actual.Siguiente;
        }
        return null;
    }

    /// <summary>
    /// Modifica los datos de una ubicación existente en la lista enlazada.
    /// </summary>
    /// <param name="id">ID de la ubicación a modificar.</param>
    /// <param name="nuevoNombre">Nuevo nombre o ubicación.</param>
    /// <param name="nuevaPista">Nueva pista del tesoro.</param>
    /// <param name="nuevoPeligro">Nuevo nivel de peligro (1-10).</param>
    /// <returns>True si el nodo fue encontrado y modificado; False si no existe.</returns>
    public bool Modificar(int id, string nuevoNombre, string nuevaPista, int nuevoPeligro)
    {
        Nodo? objetivo = Buscar(id);
        if (objetivo == null)
        {
            return false;
        }

        objetivo.Nombre = nuevoNombre;
        objetivo.Pista = nuevaPista;
        objetivo.Peligro = nuevoPeligro;
        return true;
    }

    /// <summary>
    /// Elimina una ubicación de la ruta a partir de su ID.
    /// Maneja los casos: lista vacía, eliminación del primer nodo (cabeza),
    /// eliminación de nodo intermedio o final, y nodo no encontrado.
    /// </summary>
    /// <param name="id">ID de la ubicación a eliminar.</param>
    /// <returns>True si se eliminó con éxito, False si el ID no existe en la lista.</returns>
    public bool Eliminar(int id)
    {
        if (Inicio == null)
        {
            return false;
        }

        // Caso 1: El nodo a eliminar es el primero (Inicio)
        if (Inicio.Id == id)
        {
            Inicio = Inicio.Siguiente;
            return true;
        }

        // Caso 2: El nodo a eliminar está en el medio o al final
        Nodo actual = Inicio;
        while (actual.Siguiente != null && actual.Siguiente.Id != id)
        {
            actual = actual.Siguiente;
        }

        // Si se encontró el nodo a eliminar
        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Cuenta el número total de nodos recorriendo la lista desde Inicio hasta NULL.
    /// </summary>
    public int Contar()
    {
        int contador = 0;
        Nodo? actual = Inicio;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    /// <summary>
    /// Vacía la lista simplemente enlazada estableciendo Inicio en null.
    /// </summary>
    public void Limpiar()
    {
        Inicio = null;
    }

    /// <summary>
    /// Genera una representación textual esquemática de la lista enlazada:
    /// Inicio -> [Nodo 1] -> [Nodo 2] -> ... -> NULL
    /// </summary>
    public string ObtenerEsquemaRuta()
    {
        if (Inicio == null)
        {
            return "Inicio -> NULL (Ruta vacía)";
        }

        var sb = new System.Text.StringBuilder();
        sb.Append("Inicio");

        Nodo? actual = Inicio;
        while (actual != null)
        {
            sb.Append($" -> [ID: {actual.Id} | {actual.Nombre}]");
            actual = actual.Siguiente;
        }

        sb.Append(" -> NULL");
        return sb.ToString();
    }
}
