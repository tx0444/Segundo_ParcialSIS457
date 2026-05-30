using CadParcial2Krba;
using ClnParcial2Krba;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CpParcial2Krba
{
    public partial class FrmProgama : Form
    {
        private bool esNuevo = false;

        public FrmProgama()
        {
            InitializeComponent();
        }

        private string usuarioRegistro => Environment.UserName;

        private void FrmProgama_Load(object sender, EventArgs e)
        {
            cargarCanal();
            cargarCategoria();
            configurarTabla();
            listar();
            mostrarFormulario(false);
        }

        private void configurarTabla()
        {
            dgvLista.AutoGenerateColumns = true;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.MultiSelect = false;
            dgvLista.ReadOnly = true;
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.RowHeadersVisible = false;
            dgvLista.BorderStyle = BorderStyle.None;
            dgvLista.BackgroundColor = Color.White;
            dgvLista.GridColor = Color.FromArgb(230, 233, 236);
            dgvLista.RowTemplate.Height = 30;
            dgvLista.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvLista.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 55, 72);
            dgvLista.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLista.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvLista.EnableHeadersVisualStyles = false;
        }

        private void listar()
        {
            var lista = ProgamaCln.listarPa(txtParametro.Text);
            dgvLista.DataSource = lista;

            if (dgvLista.Columns["id"] != null) dgvLista.Columns["id"].Visible = false;
            if (dgvLista.Columns["idCanal"] != null) dgvLista.Columns["idCanal"].Visible = false;
            if (dgvLista.Columns["idCategoriaPrograma"] != null) dgvLista.Columns["idCategoriaPrograma"].Visible = false;
            if (dgvLista.Columns["estado"] != null) dgvLista.Columns["estado"].Visible = false;

            cambiarEncabezado("canal", "Canal");
            cambiarEncabezado("categoria", "Categoria");
            cambiarEncabezado("titulo", "Titulo");
            cambiarEncabezado("descripcion", "Descripcion");
            cambiarEncabezado("duracion", "Duracion");
            cambiarEncabezado("productor", "Productor");
            cambiarEncabezado("fechaEstreno", "Fecha estreno");
            cambiarEncabezado("usuarioRegistro", "Usuario");
            cambiarEncabezado("fechaRegistro", "Registro");

            if (dgvLista.Columns["descripcion"] != null) dgvLista.Columns["descripcion"].FillWeight = 170;
            if (dgvLista.Columns["titulo"] != null) dgvLista.Columns["titulo"].FillWeight = 130;
            if (dgvLista.Columns["categoria"] != null) dgvLista.Columns["categoria"].FillWeight = 90;
            if (dgvLista.Columns["duracion"] != null) dgvLista.Columns["duracion"].FillWeight = 70;
            if (dgvLista.Columns["fechaEstreno"] != null)
                dgvLista.Columns["fechaEstreno"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvLista.Columns["fechaRegistro"] != null)
                dgvLista.Columns["fechaRegistro"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            bool tieneDatos = lista.Count > 0;
            btnEditar.Enabled = tieneDatos;
            btnEliminar.Enabled = tieneDatos;
            lblResumen.Text = tieneDatos ? $"Registros encontrados: {lista.Count}" : "No se encontraron registros";
        }

        private void cambiarEncabezado(string columna, string texto)
        {
            if (dgvLista.Columns[columna] != null)
                dgvLista.Columns[columna].HeaderText = texto;
        }

        private void cargarCanal()
        {
            cbxCanal.DataSource = CanalCln.listar();
            cbxCanal.ValueMember = "id";
            cbxCanal.DisplayMember = "nombre";
            cbxCanal.SelectedIndex = -1;
        }

        private void cargarCategoria()
        {
            cbxCategoria.DataSource = CategoriaProgramaCln.listar();
            cbxCategoria.ValueMember = "id";
            cbxCategoria.DisplayMember = "nombre";
            cbxCategoria.SelectedIndex = -1;
        }

        private void mostrarFormulario(bool mostrar)
        {
            pnlFormulario.Visible = mostrar;
            pnlListado.Width = mostrar ? 770 : 1138;
            pnlAcciones.Enabled = !mostrar;
            txtParametro.Enabled = !mostrar;
            btnBuscar.Enabled = !mostrar;

            if (!mostrar)
            {
                limpiar();
                dgvLista.Focus();
            }
        }

        private void limpiar()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtProductor.Clear();
            cbxCanal.SelectedIndex = -1;
            cbxCategoria.SelectedIndex = -1;
            nudDuracion.Value = 1;
            dtpFechaEstreno.Value = DateTime.Today;
            resetearErrores();
        }

        private void resetearErrores()
        {
            erpTitulo.Clear();
            erpDescripcion.Clear();
            erpCanal.Clear();
            erpCategoria.Clear();
            erpDuracion.Clear();
            erpProductor.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            lblFormularioTitulo.Text = "Nuevo progama";
            mostrarFormulario(true);
            limpiar();
            txtTitulo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow == null) return;

            esNuevo = false;
            lblFormularioTitulo.Text = "Editar progama";
            resetearErrores();

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var progama = ProgamaCln.obtenerUno(id);
            if (progama == null) return;

            txtTitulo.Text = progama.titulo;
            txtDescripcion.Text = progama.descripcion;
            txtProductor.Text = progama.productor;
            cbxCanal.SelectedValue = progama.idCanal;
            cbxCategoria.SelectedValue = progama.idCategoriaPrograma;
            nudDuracion.Value = progama.duracion;
            dtpFechaEstreno.Value = progama.fechaEstreno;

            mostrarFormulario(true);
            txtTitulo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mostrarFormulario(false);
        }

        private bool validar()
        {
            bool esValido = true;
            resetearErrores();

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                erpTitulo.SetError(txtTitulo, "El titulo es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "La descripcion es obligatoria");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtProductor.Text))
            {
                erpProductor.SetError(txtProductor, "El productor es obligatorio");
                esValido = false;
            }
            if (cbxCanal.SelectedIndex < 0)
            {
                erpCanal.SetError(cbxCanal, "El canal es obligatorio");
                esValido = false;
            }
            if (cbxCategoria.SelectedIndex < 0)
            {
                erpCategoria.SetError(cbxCategoria, "La categoria es obligatoria");
                esValido = false;
            }
            if (nudDuracion.Value <= 0)
            {
                erpDuracion.SetError(nudDuracion, "La duracion debe ser mayor a cero");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;

            var progama = new Progama()
            {
                titulo = txtTitulo.Text.Trim(),
                descripcion = txtDescripcion.Text.Trim(),
                productor = txtProductor.Text.Trim(),
                idCanal = (int)cbxCanal.SelectedValue,
                idCategoriaPrograma = (int)cbxCategoria.SelectedValue,
                duracion = (int)nudDuracion.Value,
                fechaEstreno = dtpFechaEstreno.Value.Date,
                usuarioRegistro = usuarioRegistro
            };

            if (esNuevo)
            {
                progama.fechaRegistro = DateTime.Now;
                progama.estado = 1;
                ProgamaCln.crear(progama);
            }
            else
            {
                progama.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                ProgamaCln.modificar(progama);
            }

            listar();
            mostrarFormulario(false);
            MessageBox.Show("Progama guardado correctamente", "::: Mensaje - Parcial2Krba :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow == null) return;

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string titulo = dgvLista.CurrentRow.Cells["titulo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"Esta seguro que desea eliminar el progama {titulo}?",
                "::: Mensaje - Parcial2Krba :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                ProgamaCln.eliminar(id, usuarioRegistro);
                listar();
                MessageBox.Show("Progama dado de baja correctamente", "::: Mensaje - Parcial2Krba :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
