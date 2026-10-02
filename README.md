# Reto 2 – La Ruta del Tesoro Perdido
### Listas Simplemente Enlazadas en C# (.NET 10 / Windows Forms)

Proyecto para el **Reto 2: "Ejemplo de listas simples enlazadas: La Ruta del Tesoro Perdido"**, desarrollado en **C# con .NET 10** bajo **Windows Forms** para **Visual Studio 2026**.

---

## 1. Objetivo y Reglas del Reto

Simular la ruta de un tesoro donde cada ubicación es un objeto `Nodo` conectado al siguiente mediante una clase `ListaSimple` programada desde cero.

### Restricciones cumplidas:
- No se utilizan colecciones del sistema (`List<T>`, `LinkedList<T>`, `Queue<T>`, `Stack<T>`, `Dictionary<TKey, TValue>`).
- No se usan arreglos como almacenamiento.
- No se usan los controles de WinForms como almacenamiento.
- El `DataGridView` se usa únicamente para visualizar los datos, recorriendo la lista desde `Inicio` hasta `NULL` en cada cambio.
- La lógica de la estructura está separada de los eventos de los botones del formulario.

---

## 2. Estructura del Proyecto

```text
Reto2RutaTesoro/
│
├── Nodo.cs                  # Clase Nodo (Id, Nombre, Pista, Peligro, Siguiente)
├── ListaSimple.cs           # Clase ListaSimple con operaciones manuales
├── FrmRutaTesoro.cs         # Código del formulario y eventos
├── FrmRutaTesoro.Designer.cs# Controles de Windows Forms
├── Program.cs               # Punto de inicio
└── Reto2RutaTesoro.csproj   # Archivo de proyecto .NET 10
```

---

## 3. Operaciones implementadas en ListaSimple

- `InsertarFinal(Nodo nuevo)`: Inserta un nodo al final de la lista.
- `InsertarInicio(Nodo nuevo)`: Inserta un nodo al inicio (nueva cabeza).
- `InsertarEnPosicion(int pos, Nodo nuevo)`: Inserta en una posición específica.
- `Buscar(int id)`: Busca y retorna el nodo por ID.
- `Modificar(int id, string nombre, string pista, int peligro)`: Modifica los datos del nodo.
- `Eliminar(int id)`: Elimina el nodo ajustando las referencias.
- `Contar()`: Cuenta los nodos recorriendo la lista.
- `Limpiar()`: Vacía la lista (`Inicio = null`).
- `ObtenerEsquemaRuta()`: Muestra la cadena en formato `Inicio -> [ID: 1] -> ... -> NULL`.

---

## 4. Cómo Ejecutar

Desde consola en la carpeta del proyecto:
```bash
dotnet run
```

O abriendo la solución `Reto2RutaTesoro.sln` en Visual Studio 2026 / 2022 y presionando F5.
