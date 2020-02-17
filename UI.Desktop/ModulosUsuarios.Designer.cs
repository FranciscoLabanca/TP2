namespace UI.Desktop
{
    partial class ModulosUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tscModUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.tlpModUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvModUsuarios = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.id_modulo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscModUsuarios.ContentPanel.SuspendLayout();
            this.tscModUsuarios.TopToolStripPanel.SuspendLayout();
            this.tscModUsuarios.SuspendLayout();
            this.tlpModUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModUsuarios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscModUsuarios
            // 
            // 
            // tscModUsuarios.ContentPanel
            // 
            this.tscModUsuarios.ContentPanel.Controls.Add(this.tlpModUsuarios);
            this.tscModUsuarios.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tscModUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscModUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tscModUsuarios.Name = "tscModUsuarios";
            this.tscModUsuarios.Size = new System.Drawing.Size(800, 450);
            this.tscModUsuarios.TabIndex = 0;
            this.tscModUsuarios.Text = "toolStripContainer1";
            // 
            // tscModUsuarios.TopToolStripPanel
            // 
            this.tscModUsuarios.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tlpModUsuarios
            // 
            this.tlpModUsuarios.ColumnCount = 2;
            this.tlpModUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpModUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpModUsuarios.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpModUsuarios.Controls.Add(this.btnCancelar, 1, 1);
            this.tlpModUsuarios.Controls.Add(this.dgvModUsuarios, 0, 0);
            this.tlpModUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpModUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlpModUsuarios.Name = "tlpModUsuarios";
            this.tlpModUsuarios.RowCount = 2;
            this.tlpModUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpModUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpModUsuarios.Size = new System.Drawing.Size(800, 425);
            this.tlpModUsuarios.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(722, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvModUsuarios
            // 
            this.dgvModUsuarios.AllowUserToAddRows = false;
            this.dgvModUsuarios.AllowUserToDeleteRows = false;
            this.dgvModUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_modulo_usuario,
            this.id_modulo,
            this.id_usuario,
            this.alta,
            this.baja,
            this.modificacion,
            this.consulta});
            this.tlpModUsuarios.SetColumnSpan(this.dgvModUsuarios, 2);
            this.dgvModUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvModUsuarios.Name = "dgvModUsuarios";
            this.dgvModUsuarios.ReadOnly = true;
            this.dgvModUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModUsuarios.Size = new System.Drawing.Size(794, 390);
            this.dgvModUsuarios.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::UI.Desktop.Properties.Resources.icono_agregar2;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources.icono_editar;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources.icono_eliminar;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // id_modulo_usuario
            // 
            this.id_modulo_usuario.DataPropertyName = "ID";
            this.id_modulo_usuario.HeaderText = "ID";
            this.id_modulo_usuario.Name = "id_modulo_usuario";
            this.id_modulo_usuario.ReadOnly = true;
            // 
            // id_modulo
            // 
            this.id_modulo.DataPropertyName = "IDModulo";
            this.id_modulo.HeaderText = "ID Modulo";
            this.id_modulo.Name = "id_modulo";
            this.id_modulo.ReadOnly = true;
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "IDUsuario";
            this.id_usuario.HeaderText = "ID Usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // alta
            // 
            this.alta.DataPropertyName = "PermiteAlta";
            this.alta.HeaderText = "Alta";
            this.alta.Name = "alta";
            this.alta.ReadOnly = true;
            // 
            // baja
            // 
            this.baja.DataPropertyName = "PermiteBaja";
            this.baja.HeaderText = "Baja";
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            // 
            // modificacion
            // 
            this.modificacion.DataPropertyName = "PermiteModificacion";
            this.modificacion.HeaderText = "Modificación";
            this.modificacion.Name = "modificacion";
            this.modificacion.ReadOnly = true;
            // 
            // consulta
            // 
            this.consulta.DataPropertyName = "PermiteConsulta";
            this.consulta.HeaderText = "Consulta";
            this.consulta.Name = "consulta";
            this.consulta.ReadOnly = true;
            // 
            // ModulosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscModUsuarios);
            this.Name = "ModulosUsuarios";
            this.Text = "ModulosUsuarios";
            this.Load += new System.EventHandler(this.ModulosUsuarios_Load);
            this.tscModUsuarios.ContentPanel.ResumeLayout(false);
            this.tscModUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tscModUsuarios.TopToolStripPanel.PerformLayout();
            this.tscModUsuarios.ResumeLayout(false);
            this.tscModUsuarios.PerformLayout();
            this.tlpModUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModUsuarios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscModUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlpModUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvModUsuarios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_modulo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn consulta;
    }
}