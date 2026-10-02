namespace Reto2RutaTesoro;

/// <summary>
/// Estructura de datos de Lista Simplemente Enlazada construida desde cero.
/// Cumple estrictamente con la restricción de no usar colecciones predefinidas
/// (List, LinkedList, Queue, Stack, Dictionary, ni arreglos como almacenamiento).
/// </summary>
public class ListaSimple
{

    public Nodo? Inicio { get; private set; }

    public ListaSimple()
    {
        Inicio = null;
    }

    public bool EstaVacia => Inicio == null;

    public bool Existe(int id)
    {
        return Buscar(id) != null;
    }

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

    public bool InsertarEnPosicion(int posicion, Nodo nuevo)
    {
        if (nuevo == null || posicion < 1) return false;

        if (Existe(nuevo.Id))
        {
            return false;
        }

        if (posicion == 1 || Inicio == null)
        {
            return InsertarInicio(nuevo);
        }

        Nodo actual = Inicio;
        int contador = 1;

        while (actual.Siguiente != null && contador < posicion - 1)
        {
            actual = actual.Siguiente;
            contador++;
        }

        nuevo.Siguiente = actual.Siguiente;
        actual.Siguiente = nuevo;
        return true;
    }

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

    public void Limpiar()
    {
        Inicio = null;
    }

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
