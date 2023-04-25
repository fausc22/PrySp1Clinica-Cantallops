namespace PrySp1Clinica_Cantallops
{
    partial class frmConsulta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEspecial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.lblNroEspecialidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(85, 21);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 1;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dgvInfo.Location = new System.Drawing.Point(3, 67);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.Size = new System.Drawing.Size(290, 150);
            this.dgvInfo.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nro. Matricula";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(218, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEspecial
            // 
            this.btnEspecial.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEspecial.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnEspecial.Location = new System.Drawing.Point(4, 223);
            this.btnEspecial.Name = "btnEspecial";
            this.btnEspecial.Size = new System.Drawing.Size(75, 51);
            this.btnEspecial.TabIndex = 4;
            this.btnEspecial.Text = "Nueva Especialidad";
            this.btnEspecial.UseVisualStyleBackColor = false;
            this.btnEspecial.Click += new System.EventHandler(this.btnEspecial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(218, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 21);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMedico.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMedico.Location = new System.Drawing.Point(85, 224);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(75, 50);
            this.btnMedico.TabIndex = 6;
            this.btnMedico.Text = "Nuevo Médico";
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // lblNroEspecialidad
            // 
            this.lblNroEspecialidad.AutoSize = true;
            this.lblNroEspecialidad.Location = new System.Drawing.Point(206, 224);
            this.lblNroEspecialidad.Name = "lblNroEspecialidad";
            this.lblNroEspecialidad.Size = new System.Drawing.Size(35, 13);
            this.lblNroEspecialidad.TabIndex = 7;
            this.lblNroEspecialidad.Text = "label2";
            this.lblNroEspecialidad.Visible = false;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(303, 280);
            this.Controls.Add(this.lblNroEspecialidad);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEspecial);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.Text = "CLINICA - Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEspecial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Label lblNroEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

