namespace Reto2RutaTesoro;

public partial class FrmRutaTesoro : Form
{
    // Estructura de datos manual
    private readonly ListaSimple listaRuta = new ListaSimple();

    public FrmRutaTesoro()
    {
        InitializeComponent();
        DibujarIconoSimple();
        ActualizarDataGridView();
    }

    // Dibuja una simple cruz o marca en el PictureBox
    private void DibujarIconoSimple()
    {
        Bitmap bmp = new Bitmap(44, 44);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.Clear(SystemColors.Control);
            using (Pen pen = new Pen(Color.DarkBlue, 2f))
            {
                g.DrawRectangle(pen, 4, 4, 35, 35);
                g.DrawLine(pen, 4, 4, 39, 39);
                g.DrawLine(pen, 4, 39, 39, 4);
            }
        }
        picMapa.Image = bmp;
    }

    // Actualiza el DataGridView recorriendo la lista desde Inicio hasta NULL
    private void ActualizarDataGridView()
    {
        dgvRuta.Rows.Clear();

        Nodo? actual = listaRuta.Inicio;
        int conteo = 0;

        while (actual != null)
        {
            conteo++;
            string siguienteTexto = actual.Siguiente != null
                ? "ID: " + actual.Siguiente.Id
                : "NULL";

            dgvRuta.Rows.Add(
                actual.Id,
                actual.Nombre,
                actual.Peligro,
                actual.Pista,
                siguienteTexto
            );

            actual = actual.Siguiente;
        }

        txtEsquema.Text = listaRuta.ObtenerEsquemaRuta();
        lblTotalNodos.Text = "Total nodos: " + conteo;
    }

    private void btnInsertarFinal_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos(out int id, out string nombre, out string pista, out int peligro))
        {
            return;
        }

        if (listaRuta.Existe(id))
        {
            MessageBox.Show("Ya existe una ubicación con el ID: " + id, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            nudId.Focus();
            return;
        }

        Nodo nuevo = new Nodo(id, nombre, pista, peligro);
        bool resultado = listaRuta.InsertarFinal(nuevo);

        if (resultado)
        {
            ActualizarDataGridView();
            MessageBox.Show("Ubicación agregada al final de la ruta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }
    }

    private void btnInsertarInicio_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos(out int id, out string nombre, out string pista, out int peligro))
        {
            return;
        }

        if (listaRuta.Existe(id))
        {
            MessageBox.Show("Ya existe una ubicación con el ID: " + id, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            nudId.Focus();
            return;
        }

        Nodo nuevo = new Nodo(id, nombre, pista, peligro);
        bool resultado = listaRuta.InsertarInicio(nuevo);

        if (resultado)
        {
            ActualizarDataGridView();
            MessageBox.Show("Ubicación agregada al inicio de la ruta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }
    }

    private void btnBuscar_Click(object? sender, EventArgs e)
    {
        int idABuscar = (int)nudId.Value;
        Nodo? encontrado = listaRuta.Buscar(idABuscar);

        if (encontrado != null)
        {
            txtNombre.Text = encontrado.Nombre;
            txtPista.Text = encontrado.Pista;
            nudPeligro.Value = encontrado.Peligro;

            SeleccionarFilaPorId(encontrado.Id);

            string sigInfo = encontrado.Siguiente != null ? encontrado.Siguiente.Id.ToString() : "NULL";
            MessageBox.Show(
                "Ubicación encontrada:\n\n" +
                "ID: " + encontrado.Id + "\n" +
                "Nombre: " + encontrado.Nombre + "\n" +
                "Peligro: " + encontrado.Peligro + "\n" +
                "Pista: " + encontrado.Pista + "\n" +
                "Siguiente: " + sigInfo,
                "Resultado de Búsqueda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        else
        {
            MessageBox.Show("No se encontró ningún nodo con el ID " + idABuscar, "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnModificar_Click(object? sender, EventArgs e)
    {
        int id = (int)nudId.Value;
        string nombre = txtNombre.Text.Trim();
        string pista = txtPista.Text.Trim();
        int peligro = (int)nudPeligro.Value;

        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(pista))
        {
            MessageBox.Show("El nombre y la pista no pueden quedar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        bool modificado = listaRuta.Modificar(id, nombre, pista, peligro);

        if (modificado)
        {
            ActualizarDataGridView();
            SeleccionarFilaPorId(id);
            MessageBox.Show("Ubicación modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("No se encontró ninguna ubicación con el ID: " + id + " para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        int id = (int)nudId.Value;

        if (!listaRuta.Existe(id))
        {
            MessageBox.Show("No existe ninguna ubicación con el ID: " + id, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            "¿Desea eliminar la ubicación con ID " + id + "?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (respuesta == DialogResult.Yes)
        {
            bool eliminado = listaRuta.Eliminar(id);
            if (eliminado)
            {
                ActualizarDataGridView();
                LimpiarCampos();
                MessageBox.Show("Ubicación eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void btnLimpiar_Click(object? sender, EventArgs e)
    {
        LimpiarCampos();
    }

    private void btnCargarEjemplo_Click(object? sender, EventArgs e)
    {
        if (!listaRuta.EstaVacia)
        {
            DialogResult res = MessageBox.Show(
                "La lista ya tiene datos. ¿Desea borrarlos para cargar los datos del ejercicio?",
                "Cargar Ejemplo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (res == DialogResult.Yes)
            {
                listaRuta.Limpiar();
            }
            else
            {
                return;
            }
        }

        // Cargar los datos del PDF
        listaRuta.InsertarFinal(new Nodo(1, "Playa del Naufragio", "Buscar debajo de la arena", 5));
        listaRuta.InsertarFinal(new Nodo(2, "Cueva del Kraken", "Cuidado con los tentáculos", 9));
        listaRuta.InsertarFinal(new Nodo(3, "Isla Calavera", "Detrás de la gran roca", 7));
        listaRuta.InsertarFinal(new Nodo(4, "Templo Perdido", "En el cofre antiguo", 8));

        ActualizarDataGridView();
        LimpiarCampos();
        MessageBox.Show("Se cargaron las 4 ubicaciones de ejemplo.", "Datos Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnRecorrer_Click(object? sender, EventArgs e)
    {
        if (listaRuta.EstaVacia)
        {
            MessageBox.Show("La lista está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string mensaje = "Recorrido de la lista enlazada:\n\n";
        Nodo? actual = listaRuta.Inicio;
        int paso = 1;

        while (actual != null)
        {
            mensaje += paso + ") [ID: " + actual.Id + "] " + actual.Nombre + " | Peligro: " + actual.Peligro + "\n";
            mensaje += "   Pista: " + actual.Pista + "\n";
            if (actual.Siguiente != null)
            {
                mensaje += "   Siguiente -> ID: " + actual.Siguiente.Id + "\n\n";
            }
            else
            {
                mensaje += "   Siguiente -> NULL (Fin de la ruta)\n\n";
            }

            actual = actual.Siguiente;
            paso++;
        }

        MessageBox.Show(mensaje, "Recorrido de la Ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnVaciar_Click(object? sender, EventArgs e)
    {
        if (listaRuta.EstaVacia)
        {
            MessageBox.Show("La lista ya está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult res = MessageBox.Show(
            "¿Está seguro de que desea vaciar toda la lista?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

        if (res == DialogResult.Yes)
        {
            listaRuta.Limpiar();
            ActualizarDataGridView();
            LimpiarCampos();
            MessageBox.Show("La lista se ha vaciado.", "Lista Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void dgvRuta_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < dgvRuta.Rows.Count)
        {
            DataGridViewRow fila = dgvRuta.Rows[e.RowIndex];
            if (fila.Cells[0].Value != null && int.TryParse(fila.Cells[0].Value?.ToString(), out int id))
            {
                Nodo? nodo = listaRuta.Buscar(id);
                if (nodo != null)
                {
                    nudId.Value = nodo.Id;
                    txtNombre.Text = nodo.Nombre;
                    txtPista.Text = nodo.Pista;
                    nudPeligro.Value = nodo.Peligro;
                }
            }
        }
    }

    private void SeleccionarFilaPorId(int id)
    {
        foreach (DataGridViewRow fila in dgvRuta.Rows)
        {
            if (fila.Cells[0].Value != null && int.TryParse(fila.Cells[0].Value?.ToString(), out int filaId))
            {
                if (filaId == id)
                {
                    fila.Selected = true;
                    dgvRuta.CurrentCell = fila.Cells[0];
                    break;
                }
            }
        }
    }

    private void LimpiarCampos()
    {
        txtNombre.Clear();
        txtPista.Clear();
        nudPeligro.Value = 5;

        // Calcular siguiente ID sugerido
        int maxId = 0;
        Nodo? actual = listaRuta.Inicio;
        while (actual != null)
        {
            if (actual.Id > maxId)
            {
                maxId = actual.Id;
            }
            actual = actual.Siguiente;
        }

        nudId.Value = maxId + 1;
        txtNombre.Focus();
    }

    private bool ValidarCampos(out int id, out string nombre, out string pista, out int peligro)
    {
        id = (int)nudId.Value;
        nombre = txtNombre.Text.Trim();
        pista = txtPista.Text.Trim();
        peligro = (int)nudPeligro.Value;

        if (id <= 0)
        {
            MessageBox.Show("El ID debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            nudId.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(nombre))
        {
            MessageBox.Show("Debe escribir el nombre de la ubicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNombre.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(pista))
        {
            MessageBox.Show("Debe escribir una pista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPista.Focus();
            return false;
        }

        return true;
    }
}
