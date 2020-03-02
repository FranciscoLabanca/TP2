namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            this.tlpDocCurso = new System.Windows.Forms.TableLayoutPanel();
            this.lbIdDictado = new System.Windows.Forms.Label();
            this.lbIdDocente = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbIdDictado = new System.Windows.Forms.TextBox();
            this.cbDocente = new System.Windows.Forms.ComboBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lbMateria = new System.Windows.Forms.Label();
            this.lbComision = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.tiposCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpDocCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpDocCurso
            // 
            this.tlpDocCurso.ColumnCount = 4;
            this.tlpDocCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDocCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDocCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDocCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpDocCurso.Controls.Add(this.lbIdDictado, 0, 0);
            this.tlpDocCurso.Controls.Add(this.lbIdDocente, 0, 1);
            this.tlpDocCurso.Controls.Add(this.btnAceptar, 2, 3);
            this.tlpDocCurso.Controls.Add(this.btnSalir, 3, 3);
            this.tlpDocCurso.Controls.Add(this.tbIdDictado, 1, 0);
            this.tlpDocCurso.Controls.Add(this.cbDocente, 1, 1);
            this.tlpDocCurso.Controls.Add(this.lbCargo, 0, 2);
            this.tlpDocCurso.Controls.Add(this.cbCargo, 1, 2);
            this.tlpDocCurso.Controls.Add(this.lbMateria, 2, 0);
            this.tlpDocCurso.Controls.Add(this.lbComision, 2, 1);
            this.tlpDocCurso.Controls.Add(this.cbMateria, 3, 0);
            this.tlpDocCurso.Controls.Add(this.cbComision, 3, 1);
            this.tlpDocCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDocCurso.Location = new System.Drawing.Point(0, 0);
            this.tlpDocCurso.Name = "tlpDocCurso";
            this.tlpDocCurso.RowCount = 4;
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDocCurso.Size = new System.Drawing.Size(800, 219);
            this.tlpDocCurso.TabIndex = 0;
            // 
            // lbIdDictado
            // 
            this.lbIdDictado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdDictado.AutoSize = true;
            this.lbIdDictado.Location = new System.Drawing.Point(19, 25);
            this.lbIdDictado.Name = "lbIdDictado";
            this.lbIdDictado.Size = new System.Drawing.Size(58, 13);
            this.lbIdDictado.TabIndex = 2;
            this.lbIdDictado.Text = "ID Dictado";
            // 
            // lbIdDocente
            // 
            this.lbIdDocente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdDocente.AutoSize = true;
            this.lbIdDocente.Location = new System.Drawing.Point(15, 88);
            this.lbIdDocente.Name = "lbIdDocente";
            this.lbIdDocente.Size = new System.Drawing.Size(62, 13);
            this.lbIdDocente.TabIndex = 4;
            this.lbIdDocente.Text = "ID Docente";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(403, 192);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(483, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbIdDictado
            // 
            this.tbIdDictado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIdDictado.Location = new System.Drawing.Point(83, 21);
            this.tbIdDictado.Name = "tbIdDictado";
            this.tbIdDictado.ReadOnly = true;
            this.tbIdDictado.Size = new System.Drawing.Size(100, 20);
            this.tbIdDictado.TabIndex = 6;
            // 
            // cbDocente
            // 
            this.cbDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDocente.FormattingEnabled = true;
            this.cbDocente.Location = new System.Drawing.Point(83, 84);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(100, 21);
            this.cbDocente.TabIndex = 10;
            this.cbDocente.SelectedIndexChanged += new System.EventHandler(this.cbDocente_SelectedIndexChanged);
            // 
            // lbCargo
            // 
            this.lbCargo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(42, 151);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(35, 13);
            this.lbCargo.TabIndex = 5;
            this.lbCargo.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cbCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(83, 147);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 9;
            // 
            // lbMateria
            // 
            this.lbMateria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMateria.AutoSize = true;
            this.lbMateria.Location = new System.Drawing.Point(435, 25);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(42, 13);
            this.lbMateria.TabIndex = 11;
            this.lbMateria.Text = "Materia";
            // 
            // lbComision
            // 
            this.lbComision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(428, 88);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(49, 13);
            this.lbComision.TabIndex = 12;
            this.lbComision.Text = "Comision";
            // 
            // cbMateria
            // 
            this.cbMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(483, 21);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 21);
            this.cbMateria.TabIndex = 13;
            // 
            // cbComision
            // 
            this.cbComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbComision.FormattingEnabled = true;
            this.cbComision.Location = new System.Drawing.Point(483, 84);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(121, 21);
            this.cbComision.TabIndex = 14;
            // 
            // tiposCargoBindingSource
            // 
            this.tiposCargoBindingSource.DataSource = typeof(Business.Entities.DocenteCurso.TiposCargo);
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 219);
            this.Controls.Add(this.tlpDocCurso);
            this.Name = "DocenteCursoDesktop";
            this.Text = "DocenteCursoDesktop";
            this.Load += new System.EventHandler(this.DocenteCursoDesktop_Load);
            this.tlpDocCurso.ResumeLayout(false);
            this.tlpDocCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tiposCargoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDocCurso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbIdDictado;
        private System.Windows.Forms.Label lbIdDocente;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.TextBox tbIdDictado;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.BindingSource tiposCargoBindingSource;
        private System.Windows.Forms.ComboBox cbDocente;
        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.ComboBox cbComision;
    }
}