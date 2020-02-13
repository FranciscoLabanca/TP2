namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbHsTot = new System.Windows.Forms.Label();
            this.tbHsTot = new System.Windows.Forms.TextBox();
            this.lbIdPlan = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbHsSem = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbHsSem = new System.Windows.Forms.TextBox();
            this.cbIdPlan = new System.Windows.Forms.ComboBox();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.planesTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.planesTableAdapter();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.lbId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbHsTot, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbHsTot, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbIdPlan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbDesc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbHsSem, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbDesc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbHsSem, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbIdPlan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 212);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(59, 28);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbId.Location = new System.Drawing.Point(83, 25);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(121, 20);
            this.tbId.TabIndex = 1;
            // 
            // lbHsTot
            // 
            this.lbHsTot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbHsTot.AutoSize = true;
            this.lbHsTot.Location = new System.Drawing.Point(4, 98);
            this.lbHsTot.Name = "lbHsTot";
            this.lbHsTot.Size = new System.Drawing.Size(73, 13);
            this.lbHsTot.TabIndex = 2;
            this.lbHsTot.Text = "Horas Totales";
            // 
            // tbHsTot
            // 
            this.tbHsTot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbHsTot.Location = new System.Drawing.Point(83, 95);
            this.tbHsTot.Name = "tbHsTot";
            this.tbHsTot.Size = new System.Drawing.Size(100, 20);
            this.tbHsTot.TabIndex = 3;
            // 
            // lbIdPlan
            // 
            this.lbIdPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIdPlan.AutoSize = true;
            this.lbIdPlan.Location = new System.Drawing.Point(37, 169);
            this.lbIdPlan.Name = "lbIdPlan";
            this.lbIdPlan.Size = new System.Drawing.Size(40, 13);
            this.lbIdPlan.TabIndex = 4;
            this.lbIdPlan.Text = "Id Plan";
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(414, 28);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(63, 13);
            this.lbDesc.TabIndex = 5;
            this.lbDesc.Text = "Descripción";
            // 
            // lbHsSem
            // 
            this.lbHsSem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbHsSem.AutoSize = true;
            this.lbHsSem.Location = new System.Drawing.Point(418, 92);
            this.lbHsSem.Name = "lbHsSem";
            this.lbHsSem.Size = new System.Drawing.Size(59, 26);
            this.lbHsSem.TabIndex = 6;
            this.lbHsSem.Text = "Horas Semanales";
            // 
            // tbDesc
            // 
            this.tbDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbDesc.Location = new System.Drawing.Point(483, 25);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(100, 20);
            this.tbDesc.TabIndex = 7;
            // 
            // tbHsSem
            // 
            this.tbHsSem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbHsSem.Location = new System.Drawing.Point(483, 95);
            this.tbHsSem.Name = "tbHsSem";
            this.tbHsSem.Size = new System.Drawing.Size(100, 20);
            this.tbHsSem.TabIndex = 8;
            // 
            // cbIdPlan
            // 
            this.cbIdPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbIdPlan.DataSource = this.planesBindingSource;
            this.cbIdPlan.DisplayMember = "desc_plan";
            this.cbIdPlan.FormattingEnabled = true;
            this.cbIdPlan.Location = new System.Drawing.Point(83, 165);
            this.cbIdPlan.Name = "cbIdPlan";
            this.cbIdPlan.Size = new System.Drawing.Size(121, 21);
            this.cbIdPlan.TabIndex = 9;
            this.cbIdPlan.ValueMember = "id_plan";
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(403, 164);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(483, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 212);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDesktop";
            this.Text = "Materia";
            this.Load += new System.EventHandler(this.MateriaDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbHsTot;
        private System.Windows.Forms.TextBox tbHsTot;
        private System.Windows.Forms.Label lbIdPlan;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbHsSem;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbHsSem;
        private System.Windows.Forms.ComboBox cbIdPlan;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2_netDataSetTableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}