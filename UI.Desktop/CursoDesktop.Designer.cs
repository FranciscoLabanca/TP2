namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tlpCurso = new System.Windows.Forms.TableLayoutPanel();
            this.lbId = new System.Windows.Forms.Label();
            this.lbAnioCalendario = new System.Windows.Forms.Label();
            this.lbCupo = new System.Windows.Forms.Label();
            this.lbEspecialidad = new System.Windows.Forms.Label();
            this.lbPlan = new System.Windows.Forms.Label();
            this.lbComision = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbAnioCalendario = new System.Windows.Forms.TextBox();
            this.tbCupo = new System.Windows.Forms.TextBox();
            this.lbMateria = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.especialidadesTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.especialidadesTableAdapter();
            this.tlpCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpCurso
            // 
            this.tlpCurso.ColumnCount = 4;
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpCurso.Controls.Add(this.lbId, 0, 0);
            this.tlpCurso.Controls.Add(this.lbAnioCalendario, 2, 0);
            this.tlpCurso.Controls.Add(this.lbCupo, 0, 1);
            this.tlpCurso.Controls.Add(this.lbEspecialidad, 2, 1);
            this.tlpCurso.Controls.Add(this.lbPlan, 0, 2);
            this.tlpCurso.Controls.Add(this.lbComision, 2, 2);
            this.tlpCurso.Controls.Add(this.tbId, 1, 0);
            this.tlpCurso.Controls.Add(this.tbAnioCalendario, 3, 0);
            this.tlpCurso.Controls.Add(this.tbCupo, 1, 1);
            this.tlpCurso.Controls.Add(this.lbMateria, 0, 3);
            this.tlpCurso.Controls.Add(this.cbEspecialidad, 3, 1);
            this.tlpCurso.Controls.Add(this.cbPlan, 1, 2);
            this.tlpCurso.Controls.Add(this.cbComision, 3, 2);
            this.tlpCurso.Controls.Add(this.cbMateria, 1, 3);
            this.tlpCurso.Controls.Add(this.btnAceptar, 2, 4);
            this.tlpCurso.Controls.Add(this.btnCancelar, 3, 4);
            this.tlpCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCurso.Location = new System.Drawing.Point(0, 0);
            this.tlpCurso.Name = "tlpCurso";
            this.tlpCurso.RowCount = 5;
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCurso.Size = new System.Drawing.Size(800, 259);
            this.tlpCurso.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(59, 22);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "ID";
            // 
            // lbAnioCalendario
            // 
            this.lbAnioCalendario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbAnioCalendario.AutoSize = true;
            this.lbAnioCalendario.Location = new System.Drawing.Point(420, 15);
            this.lbAnioCalendario.Name = "lbAnioCalendario";
            this.lbAnioCalendario.Size = new System.Drawing.Size(57, 26);
            this.lbAnioCalendario.TabIndex = 3;
            this.lbAnioCalendario.Text = "Año Calendario";
            // 
            // lbCupo
            // 
            this.lbCupo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCupo.AutoSize = true;
            this.lbCupo.Location = new System.Drawing.Point(45, 79);
            this.lbCupo.Name = "lbCupo";
            this.lbCupo.Size = new System.Drawing.Size(32, 13);
            this.lbCupo.TabIndex = 4;
            this.lbCupo.Text = "Cupo";
            // 
            // lbEspecialidad
            // 
            this.lbEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbEspecialidad.AutoSize = true;
            this.lbEspecialidad.Location = new System.Drawing.Point(410, 79);
            this.lbEspecialidad.Name = "lbEspecialidad";
            this.lbEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lbEspecialidad.TabIndex = 5;
            this.lbEspecialidad.Text = "Especialidad";
            // 
            // lbPlan
            // 
            this.lbPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbPlan.AutoSize = true;
            this.lbPlan.Location = new System.Drawing.Point(49, 136);
            this.lbPlan.Name = "lbPlan";
            this.lbPlan.Size = new System.Drawing.Size(28, 13);
            this.lbPlan.TabIndex = 6;
            this.lbPlan.Text = "Plan";
            // 
            // lbComision
            // 
            this.lbComision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbComision.AutoSize = true;
            this.lbComision.Location = new System.Drawing.Point(428, 136);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(49, 13);
            this.lbComision.TabIndex = 7;
            this.lbComision.Text = "Comision";
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbId.Location = new System.Drawing.Point(83, 18);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 8;
            // 
            // tbAnioCalendario
            // 
            this.tbAnioCalendario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAnioCalendario.Location = new System.Drawing.Point(483, 18);
            this.tbAnioCalendario.Name = "tbAnioCalendario";
            this.tbAnioCalendario.Size = new System.Drawing.Size(100, 20);
            this.tbAnioCalendario.TabIndex = 9;
            // 
            // tbCupo
            // 
            this.tbCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCupo.Location = new System.Drawing.Point(83, 75);
            this.tbCupo.Name = "tbCupo";
            this.tbCupo.Size = new System.Drawing.Size(100, 20);
            this.tbCupo.TabIndex = 10;
            // 
            // lbMateria
            // 
            this.lbMateria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMateria.AutoSize = true;
            this.lbMateria.Location = new System.Drawing.Point(35, 193);
            this.lbMateria.Name = "lbMateria";
            this.lbMateria.Size = new System.Drawing.Size(42, 13);
            this.lbMateria.TabIndex = 11;
            this.lbMateria.Text = "Materia";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(483, 75);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidad.TabIndex = 12;
            this.cbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidad_SelectedIndexChanged);
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbPlan
            // 
            this.cbPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(83, 132);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(121, 21);
            this.cbPlan.TabIndex = 13;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // cbComision
            // 
            this.cbComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbComision.FormattingEnabled = true;
            this.cbComision.Location = new System.Drawing.Point(483, 132);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(121, 21);
            this.cbComision.TabIndex = 14;
            // 
            // cbMateria
            // 
            this.cbMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(83, 189);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(121, 21);
            this.cbMateria.TabIndex = 15;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(403, 231);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(483, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.tlpCurso);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.Load += new System.EventHandler(this.CursoDesktop_Load);
            this.tlpCurso.ResumeLayout(false);
            this.tlpCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCurso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbAnioCalendario;
        private System.Windows.Forms.Label lbCupo;
        private System.Windows.Forms.Label lbEspecialidad;
        private System.Windows.Forms.Label lbPlan;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbAnioCalendario;
        private System.Windows.Forms.TextBox tbCupo;
        private System.Windows.Forms.Label lbMateria;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.ComboBox cbComision;
        private System.Windows.Forms.ComboBox cbMateria;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private tp2_netDataSetTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
    }
}