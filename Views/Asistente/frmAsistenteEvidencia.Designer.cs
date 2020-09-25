namespace colegio2020media.Views.Asistente
{
    partial class frmAsistenteEvidencia
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrarEvidencia = new System.Windows.Forms.Button();
            this.gbDescripcion = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaEvidencia = new System.Windows.Forms.DateTimePicker();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.cmbColegio = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.lblNombreColegio = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnMostrarEvidencia);
            this.panel1.Controls.Add(this.gbDescripcion);
            this.panel1.Location = new System.Drawing.Point(10, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 395);
            this.panel1.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(338, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(240, 132);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 161);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnMostrarEvidencia
            // 
            this.btnMostrarEvidencia.Location = new System.Drawing.Point(382, 132);
            this.btnMostrarEvidencia.Name = "btnMostrarEvidencia";
            this.btnMostrarEvidencia.Size = new System.Drawing.Size(179, 23);
            this.btnMostrarEvidencia.TabIndex = 1;
            this.btnMostrarEvidencia.Text = "Mostrar Evidencia";
            this.btnMostrarEvidencia.UseVisualStyleBackColor = true;
            // 
            // gbDescripcion
            // 
            this.gbDescripcion.Controls.Add(this.lblFecha);
            this.gbDescripcion.Controls.Add(this.dtpFechaEvidencia);
            this.gbDescripcion.Controls.Add(this.cmbGrupo);
            this.gbDescripcion.Controls.Add(this.cmbColegio);
            this.gbDescripcion.Controls.Add(this.cmbProfesor);
            this.gbDescripcion.Controls.Add(this.lblNombreGrupo);
            this.gbDescripcion.Controls.Add(this.lblNombreColegio);
            this.gbDescripcion.Controls.Add(this.lblNombreProfesor);
            this.gbDescripcion.Location = new System.Drawing.Point(13, 16);
            this.gbDescripcion.Name = "gbDescripcion";
            this.gbDescripcion.Size = new System.Drawing.Size(755, 110);
            this.gbDescripcion.TabIndex = 0;
            this.gbDescripcion.TabStop = false;
            this.gbDescripcion.Text = "Descripcion de evidencias por profesor";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(176, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Seleccione la fecha de la evidencia";
            // 
            // dtpFechaEvidencia
            // 
            this.dtpFechaEvidencia.Location = new System.Drawing.Point(227, 70);
            this.dtpFechaEvidencia.Name = "dtpFechaEvidencia";
            this.dtpFechaEvidencia.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEvidencia.TabIndex = 6;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(614, 28);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupo.TabIndex = 5;
            // 
            // cmbColegio
            // 
            this.cmbColegio.FormattingEnabled = true;
            this.cmbColegio.Location = new System.Drawing.Point(369, 29);
            this.cmbColegio.Name = "cmbColegio";
            this.cmbColegio.Size = new System.Drawing.Size(121, 21);
            this.cmbColegio.TabIndex = 4;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(110, 29);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(145, 21);
            this.cmbProfesor.TabIndex = 3;
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(517, 32);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(76, 13);
            this.lblNombreGrupo.TabIndex = 2;
            this.lblNombreGrupo.Text = "Nombre Grupo";
            // 
            // lblNombreColegio
            // 
            this.lblNombreColegio.AutoSize = true;
            this.lblNombreColegio.Location = new System.Drawing.Point(272, 32);
            this.lblNombreColegio.Name = "lblNombreColegio";
            this.lblNombreColegio.Size = new System.Drawing.Size(82, 13);
            this.lblNombreColegio.TabIndex = 1;
            this.lblNombreColegio.Text = "Nombre Colegio";
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Location = new System.Drawing.Point(18, 32);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(86, 13);
            this.lblNombreProfesor.TabIndex = 0;
            this.lblNombreProfesor.Text = "Nombre Profesor";
            // 
            // frmAsistenteEvidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(818, 481);
            this.Controls.Add(this.panel1);
            this.Name = "frmAsistenteEvidencia";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDescripcion.ResumeLayout(false);
            this.gbDescripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrarEvidencia;
        private System.Windows.Forms.GroupBox gbDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaEvidencia;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.ComboBox cmbColegio;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Label lblNombreColegio;
        private System.Windows.Forms.Label lblNombreProfesor;
    }
}
