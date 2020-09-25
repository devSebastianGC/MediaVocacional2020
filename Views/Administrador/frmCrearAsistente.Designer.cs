namespace colegio2020media.Views.Administrador
{
    partial class frmCrearAsistente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreAsistente = new System.Windows.Forms.Label();
            this.txtNombreAsistente = new System.Windows.Forms.TextBox();
            this.lblNombreColegio = new System.Windows.Forms.Label();
            this.txtNombreColegio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblConsultarAsistente = new System.Windows.Forms.Label();
            this.txtConsultarAsistente = new System.Windows.Forms.TextBox();
            this.btnConsultarAsistente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnConsultarAsistente);
            this.panel1.Controls.Add(this.txtConsultarAsistente);
            this.panel1.Controls.Add(this.lblConsultarAsistente);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtNombreColegio);
            this.panel1.Controls.Add(this.lblNombreColegio);
            this.panel1.Controls.Add(this.txtNombreAsistente);
            this.panel1.Controls.Add(this.lblNombreAsistente);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 357);
            this.panel1.TabIndex = 4;
            // 
            // lblNombreAsistente
            // 
            this.lblNombreAsistente.AutoSize = true;
            this.lblNombreAsistente.Location = new System.Drawing.Point(46, 32);
            this.lblNombreAsistente.Name = "lblNombreAsistente";
            this.lblNombreAsistente.Size = new System.Drawing.Size(90, 13);
            this.lblNombreAsistente.TabIndex = 0;
            this.lblNombreAsistente.Text = "Nombre Asistente";
            // 
            // txtNombreAsistente
            // 
            this.txtNombreAsistente.Location = new System.Drawing.Point(190, 32);
            this.txtNombreAsistente.Name = "txtNombreAsistente";
            this.txtNombreAsistente.Size = new System.Drawing.Size(182, 20);
            this.txtNombreAsistente.TabIndex = 1;
            // 
            // lblNombreColegio
            // 
            this.lblNombreColegio.AutoSize = true;
            this.lblNombreColegio.Location = new System.Drawing.Point(46, 61);
            this.lblNombreColegio.Name = "lblNombreColegio";
            this.lblNombreColegio.Size = new System.Drawing.Size(82, 13);
            this.lblNombreColegio.TabIndex = 2;
            this.lblNombreColegio.Text = "Nombre Colegio";
            // 
            // txtNombreColegio
            // 
            this.txtNombreColegio.Location = new System.Drawing.Point(190, 58);
            this.txtNombreColegio.Name = "txtNombreColegio";
            this.txtNombreColegio.Size = new System.Drawing.Size(182, 20);
            this.txtNombreColegio.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(444, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblConsultarAsistente
            // 
            this.lblConsultarAsistente.AutoSize = true;
            this.lblConsultarAsistente.Location = new System.Drawing.Point(46, 87);
            this.lblConsultarAsistente.Name = "lblConsultarAsistente";
            this.lblConsultarAsistente.Size = new System.Drawing.Size(97, 13);
            this.lblConsultarAsistente.TabIndex = 5;
            this.lblConsultarAsistente.Text = "Consultar Asistente";
            // 
            // txtConsultarAsistente
            // 
            this.txtConsultarAsistente.Location = new System.Drawing.Point(190, 84);
            this.txtConsultarAsistente.Name = "txtConsultarAsistente";
            this.txtConsultarAsistente.Size = new System.Drawing.Size(182, 20);
            this.txtConsultarAsistente.TabIndex = 6;
            // 
            // btnConsultarAsistente
            // 
            this.btnConsultarAsistente.Location = new System.Drawing.Point(421, 82);
            this.btnConsultarAsistente.Name = "btnConsultarAsistente";
            this.btnConsultarAsistente.Size = new System.Drawing.Size(123, 23);
            this.btnConsultarAsistente.TabIndex = 7;
            this.btnConsultarAsistente.Text = "&Consultar Asistente";
            this.btnConsultarAsistente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 165);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(261, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmCrearAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.panel1);
            this.Name = "frmCrearAsistente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreAsistente;
        private System.Windows.Forms.Label lblNombreAsistente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultarAsistente;
        private System.Windows.Forms.TextBox txtConsultarAsistente;
        private System.Windows.Forms.Label lblConsultarAsistente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreColegio;
        private System.Windows.Forms.Label lblNombreColegio;
        private System.Windows.Forms.Button btnSalir;
    }
}
