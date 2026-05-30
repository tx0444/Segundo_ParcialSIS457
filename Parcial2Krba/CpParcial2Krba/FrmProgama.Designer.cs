namespace CpParcial2Krba
{
    partial class FrmProgama
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.lblFormularioTitulo = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.txtProductor = new System.Windows.Forms.TextBox();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblProductor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxCanal = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTituloProgama = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCanal = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDuracion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpProductor = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEncabezado.SuspendLayout();
            this.pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1184, 82);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(341, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gestion de programas de television y eliminacion logica";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Progamas";
            // 
            // pnlListado
            // 
            this.pnlListado.BackColor = System.Drawing.Color.White;
            this.pnlListado.Controls.Add(this.dgvLista);
            this.pnlListado.Controls.Add(this.pnlAcciones);
            this.pnlListado.Controls.Add(this.pnlBusqueda);
            this.pnlListado.Location = new System.Drawing.Point(18, 100);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(770, 530);
            this.pnlListado.TabIndex = 1;
            // 
            // dgvLista
            // 
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(0, 72);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(770, 400);
            this.dgvLista.TabIndex = 2;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.lblResumen);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 472);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(770, 58);
            this.pnlAcciones.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.Location = new System.Drawing.Point(667, 13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 32);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(575, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(52, 144, 220);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(483, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 32);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(391, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 32);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(74, 85, 104);
            this.lblResumen.Location = new System.Drawing.Point(16, 21);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(128, 15);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.Text = "Registros encontrados";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Controls.Add(this.txtParametro);
            this.pnlBusqueda.Controls.Add(this.lblParametro);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 0);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(770, 72);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(660, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParametro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtParametro.Location = new System.Drawing.Point(18, 33);
            this.txtParametro.MaxLength = 50;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(636, 25);
            this.txtParametro.TabIndex = 1;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblParametro.ForeColor = System.Drawing.Color.FromArgb(74, 85, 104);
            this.lblParametro.Location = new System.Drawing.Point(15, 14);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(180, 15);
            this.lblParametro.TabIndex = 0;
            this.lblParametro.Text = "Buscar por titulo, canal o productor";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.Controls.Add(this.gbxDatos);
            this.pnlFormulario.Location = new System.Drawing.Point(806, 100);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(360, 530);
            this.pnlFormulario.TabIndex = 2;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lblFormularioTitulo);
            this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
            this.gbxDatos.Controls.Add(this.txtProductor);
            this.gbxDatos.Controls.Add(this.lblFechaEstreno);
            this.gbxDatos.Controls.Add(this.lblProductor);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.nudDuracion);
            this.gbxDatos.Controls.Add(this.lblDuracion);
            this.gbxDatos.Controls.Add(this.txtDescripcion);
            this.gbxDatos.Controls.Add(this.cbxCanal);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Controls.Add(this.lblDescripcion);
            this.gbxDatos.Controls.Add(this.lblTituloProgama);
            this.gbxDatos.Controls.Add(this.lblCanal);
            this.gbxDatos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbxDatos.Location = new System.Drawing.Point(14, 14);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(332, 500);
            this.gbxDatos.TabIndex = 0;
            this.gbxDatos.TabStop = false;
            // 
            // lblFormularioTitulo
            // 
            this.lblFormularioTitulo.AutoSize = true;
            this.lblFormularioTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormularioTitulo.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblFormularioTitulo.Location = new System.Drawing.Point(18, 22);
            this.lblFormularioTitulo.Name = "lblFormularioTitulo";
            this.lblFormularioTitulo.Size = new System.Drawing.Size(150, 25);
            this.lblFormularioTitulo.TabIndex = 14;
            this.lblFormularioTitulo.Text = "Nuevo progama";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstreno.Location = new System.Drawing.Point(22, 366);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(285, 23);
            this.dtpFechaEstreno.TabIndex = 5;
            // 
            // txtProductor
            // 
            this.txtProductor.Location = new System.Drawing.Point(22, 313);
            this.txtProductor.MaxLength = 100;
            this.txtProductor.Name = "txtProductor";
            this.txtProductor.Size = new System.Drawing.Size(285, 23);
            this.txtProductor.TabIndex = 4;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(19, 348);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(82, 15);
            this.lblFechaEstreno.TabIndex = 13;
            this.lblFechaEstreno.Text = "Fecha estreno";
            // 
            // lblProductor
            // 
            this.lblProductor.AutoSize = true;
            this.lblProductor.Location = new System.Drawing.Point(19, 295);
            this.lblProductor.Name = "lblProductor";
            this.lblProductor.Size = new System.Drawing.Size(61, 15);
            this.lblProductor.TabIndex = 12;
            this.lblProductor.Text = "Productor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.Location = new System.Drawing.Point(171, 436);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(22, 436);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 36);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(22, 260);
            this.nudDuracion.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(285, 23);
            this.nudDuracion.TabIndex = 3;
            this.nudDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(19, 242);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(104, 15);
            this.lblDuracion.TabIndex = 8;
            this.lblDuracion.Text = "Duracion minutos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 166);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(285, 61);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cbxCanal
            // 
            this.cbxCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanal.FormattingEnabled = true;
            this.cbxCanal.Location = new System.Drawing.Point(22, 113);
            this.cbxCanal.Name = "cbxCanal";
            this.cbxCanal.Size = new System.Drawing.Size(285, 23);
            this.cbxCanal.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(22, 60);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(285, 23);
            this.txtTitulo.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 148);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblTituloProgama
            // 
            this.lblTituloProgama.AutoSize = true;
            this.lblTituloProgama.Location = new System.Drawing.Point(19, 42);
            this.lblTituloProgama.Name = "lblTituloProgama";
            this.lblTituloProgama.Size = new System.Drawing.Size(37, 15);
            this.lblTituloProgama.TabIndex = 1;
            this.lblTituloProgama.Text = "Titulo";
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(19, 95);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(38, 15);
            this.lblCanal.TabIndex = 0;
            this.lblCanal.Text = "Canal";
            // 
            // FrmProgama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1184, 651);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmProgama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progamas - Parcial2Krba";
            this.Load += new System.EventHandler(this.FrmProgama_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductor)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlListado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblFormularioTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.TextBox txtProductor;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblProductor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxCanal;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTituloProgama;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpDescripcion;
        private System.Windows.Forms.ErrorProvider erpCanal;
        private System.Windows.Forms.ErrorProvider erpDuracion;
        private System.Windows.Forms.ErrorProvider erpProductor;
    }
}