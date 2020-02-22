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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbIdDictado = new System.Windows.Forms.Label();
            this.lbIdCurso = new System.Windows.Forms.Label();
            this.lbIdDocente = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.tbIdDictado = new System.Windows.Forms.TextBox();
            this.tbIdCurso = new System.Windows.Forms.TextBox();
            this.tbIdDocente = new System.Windows.Forms.TextBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
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
            this.tlpDocCurso.Controls.Add(this.lbIdCurso, 2, 0);
            this.tlpDocCurso.Controls.Add(this.lbIdDocente, 0, 1);
            this.tlpDocCurso.Controls.Add(this.lbCargo, 2, 1);
            this.tlpDocCurso.Controls.Add(this.btnAceptar, 2, 2);
            this.tlpDocCurso.Controls.Add(this.btnSalir, 3, 2);
            this.tlpDocCurso.Controls.Add(this.tbIdDictado, 1, 0);
            this.tlpDocCurso.Controls.Add(this.tbIdCurso, 3, 0);
            this.tlpDocCurso.Controls.Add(this.tbIdDocente, 1, 1);
            this.tlpDocCurso.Controls.Add(this.cbCargo, 3, 1);
            this.tlpDocCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDocCurso.Location = new System.Drawing.Point(0, 0);
            this.tlpDocCurso.Name = "tlpDocCurso";
            this.tlpDocCurso.RowCount = 3;
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDocCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDocCurso.Size = new System.Drawing.Size(800, 219);
            this.tlpDocCurso.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(403, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(483, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbIdDictado
            // 
            this.lbIdDictado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdDictado.AutoSize = true;
            this.lbIdDictado.Location = new System.Drawing.Point(19, 41);
            this.lbIdDictado.Name = "lbIdDictado";
            this.lbIdDictado.Size = new System.Drawing.Size(58, 13);
            this.lbIdDictado.TabIndex = 2;
            this.lbIdDictado.Text = "ID Dictado";
            // 
            // lbIdCurso
            // 
            this.lbIdCurso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdCurso.AutoSize = true;
            this.lbIdCurso.Location = new System.Drawing.Point(429, 41);
            this.lbIdCurso.Name = "lbIdCurso";
            this.lbIdCurso.Size = new System.Drawing.Size(48, 13);
            this.lbIdCurso.TabIndex = 3;
            this.lbIdCurso.Text = "ID Curso";
            // 
            // lbIdDocente
            // 
            this.lbIdDocente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdDocente.AutoSize = true;
            this.lbIdDocente.Location = new System.Drawing.Point(15, 136);
            this.lbIdDocente.Name = "lbIdDocente";
            this.lbIdDocente.Size = new System.Drawing.Size(62, 13);
            this.lbIdDocente.TabIndex = 4;
            this.lbIdDocente.Text = "ID Docente";
            // 
            // lbCargo
            // 
            this.lbCargo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(442, 136);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(35, 13);
            this.lbCargo.TabIndex = 5;
            this.lbCargo.Text = "Cargo";
            // 
            // tbIdDictado
            // 
            this.tbIdDictado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIdDictado.Location = new System.Drawing.Point(83, 37);
            this.tbIdDictado.Name = "tbIdDictado";
            this.tbIdDictado.ReadOnly = true;
            this.tbIdDictado.Size = new System.Drawing.Size(100, 20);
            this.tbIdDictado.TabIndex = 6;
            // 
            // tbIdCurso
            // 
            this.tbIdCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIdCurso.Location = new System.Drawing.Point(483, 37);
            this.tbIdCurso.Name = "tbIdCurso";
            this.tbIdCurso.Size = new System.Drawing.Size(100, 20);
            this.tbIdCurso.TabIndex = 7;
            // 
            // tbIdDocente
            // 
            this.tbIdDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIdDocente.Location = new System.Drawing.Point(83, 132);
            this.tbIdDocente.Name = "tbIdDocente";
            this.tbIdDocente.Size = new System.Drawing.Size(100, 20);
            this.tbIdDocente.TabIndex = 8;
            // 
            // cbCargo
            // 
            this.cbCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(483, 132);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 9;
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
        private System.Windows.Forms.Label lbIdCurso;
        private System.Windows.Forms.Label lbIdDocente;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.TextBox tbIdDictado;
        private System.Windows.Forms.TextBox tbIdCurso;
        private System.Windows.Forms.TextBox tbIdDocente;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.BindingSource tiposCargoBindingSource;
    }
}