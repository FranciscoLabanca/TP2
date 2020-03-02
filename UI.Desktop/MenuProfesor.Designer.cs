namespace UI.Desktop
{
    partial class MenuProfesor
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
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.lbSubTitulo = new System.Windows.Forms.Label();
            this.tlpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 2;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Controls.Add(this.lbTitulo, 0, 0);
            this.tlpMenu.Controls.Add(this.btnCursos, 1, 2);
            this.tlpMenu.Controls.Add(this.btnSalir, 1, 3);
            this.tlpMenu.Controls.Add(this.btnNotas, 0, 2);
            this.tlpMenu.Controls.Add(this.cbCurso, 1, 1);
            this.tlpMenu.Controls.Add(this.lbSubTitulo, 0, 1);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 4;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMenu.Size = new System.Drawing.Size(800, 350);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSalir.Location = new System.Drawing.Point(403, 294);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCursos.Location = new System.Drawing.Point(403, 199);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(84, 36);
            this.btnCursos.TabIndex = 1;
            this.btnCursos.Text = "Reportes de Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            // 
            // btnNotas
            // 
            this.btnNotas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNotas.Location = new System.Drawing.Point(305, 206);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(92, 23);
            this.btnNotas.TabIndex = 0;
            this.btnNotas.Text = "Asignar Notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.tlpMenu.SetColumnSpan(this.lbTitulo, 2);
            this.lbTitulo.Location = new System.Drawing.Point(307, 37);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(185, 13);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Bienvenido al Sistema de Autogestion";
            // 
            // cbCurso
            // 
            this.cbCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCurso.Location = new System.Drawing.Point(403, 120);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(121, 21);
            this.cbCurso.TabIndex = 0;
            // 
            // lbSubTitulo
            // 
            this.lbSubTitulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSubTitulo.AutoSize = true;
            this.lbSubTitulo.Location = new System.Drawing.Point(293, 124);
            this.lbSubTitulo.Name = "lbSubTitulo";
            this.lbSubTitulo.Size = new System.Drawing.Size(104, 13);
            this.lbSubTitulo.TabIndex = 4;
            this.lbSubTitulo.Text = "Seleccione un curso";
            // 
            // MenuProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.tlpMenu);
            this.Name = "MenuProfesor";
            this.Text = "MenuProfesor";
            this.Load += new System.EventHandler(this.MenuProfesor_Load);
            this.tlpMenu.ResumeLayout(false);
            this.tlpMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label lbSubTitulo;
    }
}