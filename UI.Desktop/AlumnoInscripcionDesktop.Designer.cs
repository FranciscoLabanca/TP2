namespace UI.Desktop
{
    partial class AlumnoInscripcionDesktop
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
            this.tlbAlIns = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbIdIns = new System.Windows.Forms.Label();
            this.lbIdAlumno = new System.Windows.Forms.Label();
            this.lbNota = new System.Windows.Forms.Label();
            this.tbIdIns = new System.Windows.Forms.TextBox();
            this.tbIdAlumno = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.tbCondicion = new System.Windows.Forms.TextBox();
            this.lbCondicion = new System.Windows.Forms.Label();
            this.lbMateria = new System.Windows.Forms.Label();
            this.lbComision = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.tlbAlIns.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlbAlIns
            // 
            this.tlbAlIns.ColumnCount = 4;
            this.tlbAlIns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlbAlIns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlbAlIns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlbAlIns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlbAlIns.Controls.Add(this.btnAceptar, 2, 3);
            this.tlbAlIns.Controls.Add(this.btnCancelar, 3, 3);
            this.tlbAlIns.Controls.Add(this.lbIdIns, 0, 0);
            this.tlbAlIns.Controls.Add(this.lbIdAlumno, 2, 0);
            this.tlbAlIns.Controls.Add(this.lbNota, 2, 1);
            this.tlbAlIns.Controls.Add(this.tbIdIns, 1, 0);
            this.tlbAlIns.Controls.Add(this.tbIdAlumno, 3, 0);
            this.tlbAlIns.Controls.Add(this.tbNota, 3, 1);
            this.tlbAlIns.Controls.Add(this.tbCondicion, 3, 2);
            this.tlbAlIns.Controls.Add(this.lbCondicion, 2, 2);
            this.tlbAlIns.Controls.Add(this.lbComision, 0, 1);
            this.tlbAlIns.Controls.Add(this.cbComision, 1, 1);
            this.tlbAlIns.Controls.Add(this.lbMateria, 0, 2);
            this.tlbAlIns.Controls.Add(this.cbMateria, 1, 2);
            this.tlbAlIns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbAlIns.Location = new System.Drawing.Point(0, 0);
            this.tlbAlIns.Name = "tlbAlIns";
            this.tlbAlIns.RowCount = 4;
            this.tlbAlIns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlbAlIns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlbAlIns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlbAlIns.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlbAlIns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbAlIns.Size = new System.Drawing.Size(736, 167);
            this.tlbAlIns.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(370, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(67, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(443, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbIdIns
            // 
            this.lbIdIns.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdIns.AutoSize = true;
            this.lbIdIns.Location = new System.Drawing.Point(12, 9);
            this.lbIdIns.Name = "lbIdIns";
            this.lbIdIns.Size = new System.Drawing.Size(58, 26);
            this.lbIdIns.TabIndex = 2;
            this.lbIdIns.Text = "Id Inscripcion";
            // 
            // lbIdAlumno
            // 
            this.lbIdAlumno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdAlumno.AutoSize = true;
            this.lbIdAlumno.Location = new System.Drawing.Point(383, 16);
            this.lbIdAlumno.Name = "lbIdAlumno";
            this.lbIdAlumno.Size = new System.Drawing.Size(54, 13);
            this.lbIdAlumno.TabIndex = 3;
            this.lbIdAlumno.Text = "Id Alumno";
            // 
            // lbNota
            // 
            this.lbNota.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNota.AutoSize = true;
            this.lbNota.Location = new System.Drawing.Point(407, 61);
            this.lbNota.Name = "lbNota";
            this.lbNota.Size = new System.Drawing.Size(30, 13);
            this.lbNota.TabIndex = 5;
            this.lbNota.Text = "Nota";
            // 
            // tbIdIns
            // 
            this.tbIdIns.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIdIns.Location = new System.Drawing.Point(76, 12);
            this.tbIdIns.Name = "tbIdIns";
            this.tbIdIns.ReadOnly = true;
            this.tbIdIns.Size = new System.Drawing.Size(100, 20);
            this.tbIdIns.TabIndex = 7;
            // 
            // tbIdAlumno
            // 
            this.tbIdAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIdAlumno.Location = new System.Drawing.Point(443, 12);
            this.tbIdAlumno.Name = "tbIdAlumno";
            this.tbIdAlumno.Size = new System.Drawing.Size(100, 20);
            this.tbIdAlumno.TabIndex = 8;
            // 
            // tbNota
            // 
            this.tbNota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNota.Location = new System.Drawing.Point(443, 57);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(100, 20);
            this.tbNota.TabIndex = 10;
            // 
            // tbCondicion
            // 
            this.tbCondicion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCondicion.Location = new System.Drawing.Point(443, 103);
            this.tbCondicion.Name = "tbCondicion";
            this.tbCondicion.Size = new System.Drawing.Size(100, 20);
            this.tbCondicion.TabIndex = 11;
            // 
            // lbCondicion
            // 
            this.lbCondicion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCondicion.AutoSize = true;
            this.lbCondicion.Location = new System.Drawing.Point(383, 106);
            this.lbCondicion.Name = "lbCondicion";
            this.lbCondicion.Size = new System.Drawing.Size(54, 13);
            this.lbCondicion.TabIndex = 6;
            this.lbCondicion.Text = "Condicion";
            // 
            // lbMateria
            // 
            this.lbMateria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMateria.AutoSize = true;
            this.lbMateria.Location = new System.Drawing.Point(28, 106);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(42, 13);
            this.lbMateria.TabIndex = 12;
            this.lbMateria.Text = "Materia";
            // 
            // lbComision
            // 
            this.lbComision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(21, 61);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(49, 13);
            this.lbComision.TabIndex = 14;
            this.lbComision.Text = "Comision";
            // 
            // cbMateria
            // 
            this.cbMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(76, 102);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 21);
            this.cbMateria.TabIndex = 15;
            // 
            // cbComision
            // 
            this.cbComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbComision.FormattingEnabled = true;
            this.cbComision.Location = new System.Drawing.Point(76, 57);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(121, 21);
            this.cbComision.TabIndex = 16;
            // 
            // AlumnoInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 167);
            this.Controls.Add(this.tlbAlIns);
            this.Name = "AlumnoInscripcionDesktop";
            this.Text = "AlumnoInscripcionDesktop";
            this.Load += new System.EventHandler(this.AlumnoInscripcionDesktop_Load);
            this.tlbAlIns.ResumeLayout(false);
            this.tlbAlIns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlbAlIns;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbIdIns;
        private System.Windows.Forms.Label lbIdAlumno;
        private System.Windows.Forms.Label lbNota;
        private System.Windows.Forms.Label lbCondicion;
        private System.Windows.Forms.TextBox tbIdIns;
        private System.Windows.Forms.TextBox tbIdAlumno;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.TextBox tbCondicion;
        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.ComboBox cbComision;
    }
}