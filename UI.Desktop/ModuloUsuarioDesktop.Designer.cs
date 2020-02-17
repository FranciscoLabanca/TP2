namespace UI.Desktop
{
    partial class ModuloUsuarioDesktop
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
            this.components = new System.ComponentModel.Container();
            this.tlpModUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbIdUsuario = new System.Windows.Forms.Label();
            this.lbIdModulo = new System.Windows.Forms.Label();
            this.lbAlta = new System.Windows.Forms.Label();
            this.lbBaja = new System.Windows.Forms.Label();
            this.lbModificacion = new System.Windows.Forms.Label();
            this.lbConsulta = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.cbModulo = new System.Windows.Forms.ComboBox();
            this.modulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbAlta = new System.Windows.Forms.CheckBox();
            this.cbBaja = new System.Windows.Forms.CheckBox();
            this.cbModificacion = new System.Windows.Forms.CheckBox();
            this.cbConsulta = new System.Windows.Forms.CheckBox();
            this.usuariosTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.usuariosTableAdapter();
            this.modulosTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.modulosTableAdapter();
            this.tlpModUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpModUsuario
            // 
            this.tlpModUsuario.ColumnCount = 4;
            this.tlpModUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpModUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpModUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpModUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpModUsuario.Controls.Add(this.btnAceptar, 2, 4);
            this.tlpModUsuario.Controls.Add(this.btnCancelar, 3, 4);
            this.tlpModUsuario.Controls.Add(this.lbId, 0, 0);
            this.tlpModUsuario.Controls.Add(this.lbIdUsuario, 2, 0);
            this.tlpModUsuario.Controls.Add(this.lbIdModulo, 0, 1);
            this.tlpModUsuario.Controls.Add(this.lbAlta, 2, 1);
            this.tlpModUsuario.Controls.Add(this.lbBaja, 0, 2);
            this.tlpModUsuario.Controls.Add(this.lbModificacion, 2, 2);
            this.tlpModUsuario.Controls.Add(this.lbConsulta, 0, 3);
            this.tlpModUsuario.Controls.Add(this.tbId, 1, 0);
            this.tlpModUsuario.Controls.Add(this.cbUsuario, 3, 0);
            this.tlpModUsuario.Controls.Add(this.cbModulo, 1, 1);
            this.tlpModUsuario.Controls.Add(this.cbAlta, 3, 1);
            this.tlpModUsuario.Controls.Add(this.cbBaja, 1, 2);
            this.tlpModUsuario.Controls.Add(this.cbModificacion, 3, 2);
            this.tlpModUsuario.Controls.Add(this.cbConsulta, 1, 3);
            this.tlpModUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpModUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlpModUsuario.Name = "tlpModUsuario";
            this.tlpModUsuario.RowCount = 5;
            this.tlpModUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpModUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpModUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpModUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpModUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpModUsuario.Size = new System.Drawing.Size(800, 238);
            this.tlpModUsuario.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(403, 211);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(483, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbId
            // 
            this.lbId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(59, 19);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID";
            // 
            // lbIdUsuario
            // 
            this.lbIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdUsuario.AutoSize = true;
            this.lbIdUsuario.Location = new System.Drawing.Point(434, 19);
            this.lbIdUsuario.Name = "lbIdUsuario";
            this.lbIdUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbIdUsuario.TabIndex = 3;
            this.lbIdUsuario.Text = "Usuario";
            // 
            // lbIdModulo
            // 
            this.lbIdModulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdModulo.AutoSize = true;
            this.lbIdModulo.Location = new System.Drawing.Point(35, 71);
            this.lbIdModulo.Name = "lbIdModulo";
            this.lbIdModulo.Size = new System.Drawing.Size(42, 13);
            this.lbIdModulo.TabIndex = 4;
            this.lbIdModulo.Text = "Modulo";
            // 
            // lbAlta
            // 
            this.lbAlta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAlta.AutoSize = true;
            this.lbAlta.Location = new System.Drawing.Point(452, 71);
            this.lbAlta.Name = "lbAlta";
            this.lbAlta.Size = new System.Drawing.Size(25, 13);
            this.lbAlta.TabIndex = 5;
            this.lbAlta.Text = "Alta";
            // 
            // lbBaja
            // 
            this.lbBaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbBaja.AutoSize = true;
            this.lbBaja.Location = new System.Drawing.Point(49, 123);
            this.lbBaja.Name = "lbBaja";
            this.lbBaja.Size = new System.Drawing.Size(28, 13);
            this.lbBaja.TabIndex = 6;
            this.lbBaja.Text = "Baja";
            // 
            // lbModificacion
            // 
            this.lbModificacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbModificacion.AutoSize = true;
            this.lbModificacion.Location = new System.Drawing.Point(410, 123);
            this.lbModificacion.Name = "lbModificacion";
            this.lbModificacion.Size = new System.Drawing.Size(67, 13);
            this.lbModificacion.TabIndex = 7;
            this.lbModificacion.Text = "Modificacion";
            // 
            // lbConsulta
            // 
            this.lbConsulta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbConsulta.AutoSize = true;
            this.lbConsulta.Location = new System.Drawing.Point(29, 175);
            this.lbConsulta.Name = "lbConsulta";
            this.lbConsulta.Size = new System.Drawing.Size(48, 13);
            this.lbConsulta.TabIndex = 8;
            this.lbConsulta.Text = "Consulta";
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbId.Location = new System.Drawing.Point(83, 16);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 9;
            // 
            // cbUsuario
            // 
            this.cbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUsuario.DataSource = this.usuariosBindingSource;
            this.cbUsuario.DisplayMember = "nombre_usuario";
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(483, 15);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(97, 21);
            this.cbUsuario.TabIndex = 10;
            this.cbUsuario.ValueMember = "id_usuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbModulo
            // 
            this.cbModulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbModulo.DataSource = this.modulosBindingSource;
            this.cbModulo.DisplayMember = "desc_modulo";
            this.cbModulo.FormattingEnabled = true;
            this.cbModulo.Location = new System.Drawing.Point(83, 67);
            this.cbModulo.Name = "cbModulo";
            this.cbModulo.Size = new System.Drawing.Size(100, 21);
            this.cbModulo.TabIndex = 11;
            this.cbModulo.ValueMember = "id_modulo";
            // 
            // modulosBindingSource
            // 
            this.modulosBindingSource.DataMember = "modulos";
            this.modulosBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // cbAlta
            // 
            this.cbAlta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAlta.AutoSize = true;
            this.cbAlta.Location = new System.Drawing.Point(483, 71);
            this.cbAlta.Name = "cbAlta";
            this.cbAlta.Size = new System.Drawing.Size(15, 14);
            this.cbAlta.TabIndex = 12;
            this.cbAlta.UseVisualStyleBackColor = true;
            // 
            // cbBaja
            // 
            this.cbBaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbBaja.AutoSize = true;
            this.cbBaja.Location = new System.Drawing.Point(83, 123);
            this.cbBaja.Name = "cbBaja";
            this.cbBaja.Size = new System.Drawing.Size(15, 14);
            this.cbBaja.TabIndex = 13;
            this.cbBaja.UseVisualStyleBackColor = true;
            // 
            // cbModificacion
            // 
            this.cbModificacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbModificacion.AutoSize = true;
            this.cbModificacion.Location = new System.Drawing.Point(483, 123);
            this.cbModificacion.Name = "cbModificacion";
            this.cbModificacion.Size = new System.Drawing.Size(15, 14);
            this.cbModificacion.TabIndex = 14;
            this.cbModificacion.UseVisualStyleBackColor = true;
            // 
            // cbConsulta
            // 
            this.cbConsulta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbConsulta.AutoSize = true;
            this.cbConsulta.Location = new System.Drawing.Point(83, 175);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(15, 14);
            this.cbConsulta.TabIndex = 15;
            this.cbConsulta.UseVisualStyleBackColor = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // modulosTableAdapter
            // 
            this.modulosTableAdapter.ClearBeforeFill = true;
            // 
            // ModuloUsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.tlpModUsuario);
            this.Name = "ModuloUsuarioDesktop";
            this.Text = "ModuloUsuarioDesktop";
            this.Load += new System.EventHandler(this.ModuloUsuarioDesktop_Load);
            this.tlpModUsuario.ResumeLayout(false);
            this.tlpModUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpModUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbIdUsuario;
        private System.Windows.Forms.Label lbIdModulo;
        private System.Windows.Forms.Label lbAlta;
        private System.Windows.Forms.Label lbBaja;
        private System.Windows.Forms.Label lbModificacion;
        private System.Windows.Forms.Label lbConsulta;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.ComboBox cbModulo;
        private System.Windows.Forms.CheckBox cbAlta;
        private System.Windows.Forms.CheckBox cbBaja;
        private System.Windows.Forms.CheckBox cbModificacion;
        private System.Windows.Forms.CheckBox cbConsulta;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private tp2_netDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource modulosBindingSource;
        private tp2_netDataSetTableAdapters.modulosTableAdapter modulosTableAdapter;
    }
}