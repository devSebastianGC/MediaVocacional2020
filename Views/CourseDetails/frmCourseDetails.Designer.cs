namespace colegio2020media.Views.CourseDetails
{
    partial class frmCourseDetails
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvDetallesCurso = new System.Windows.Forms.DataGridView();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet13 = new colegio2020media.CollegeDataSet13();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbDetallesCurso = new System.Windows.Forms.GroupBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet12 = new colegio2020media.CollegeDataSet12();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.cmbNombreCurso = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet11 = new colegio2020media.CollegeDataSet11();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.dataconexionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new colegio2020media.CollegeDataSet11TableAdapters.CourseTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.courseTableAdapter1 = new colegio2020media.CollegeDataSet12TableAdapters.CourseTableAdapter();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.courseTableAdapter2 = new colegio2020media.CollegeDataSet13TableAdapters.CourseTableAdapter();
            this.fillByToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet13)).BeginInit();
            this.gbDetallesCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet11)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillByToolStrip1.SuspendLayout();
            this.fillByToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.dgvDetallesCurso);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.gbDetallesCurso);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 357);
            this.panel1.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(468, 313);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvDetallesCurso
            // 
            this.dgvDetallesCurso.AutoGenerateColumns = false;
            this.dgvDetallesCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.Semestre,
            this.courseNameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dgvDetallesCurso.DataSource = this.courseBindingSource2;
            this.dgvDetallesCurso.Location = new System.Drawing.Point(162, 152);
            this.dgvDetallesCurso.Name = "dgvDetallesCurso";
            this.dgvDetallesCurso.Size = new System.Drawing.Size(244, 150);
            this.dgvDetallesCurso.TabIndex = 4;
            this.dgvDetallesCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesCurso_CellContentClick);
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Nombre Curso";
            this.Curso.Name = "Curso";
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Nombre Semestre";
            this.Semestre.Name = "Semestre";
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.collegeDataSet13;
            // 
            // collegeDataSet13
            // 
            this.collegeDataSet13.DataSetName = "CollegeDataSet13";
            this.collegeDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(398, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(257, 99);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(110, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "A&gregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbDetallesCurso
            // 
            this.gbDetallesCurso.Controls.Add(this.cmbSemestre);
            this.gbDetallesCurso.Controls.Add(this.lblSemestre);
            this.gbDetallesCurso.Controls.Add(this.cmbNombreCurso);
            this.gbDetallesCurso.Controls.Add(this.lblNombreCurso);
            this.gbDetallesCurso.Location = new System.Drawing.Point(20, 15);
            this.gbDetallesCurso.Name = "gbDetallesCurso";
            this.gbDetallesCurso.Size = new System.Drawing.Size(566, 63);
            this.gbDetallesCurso.TabIndex = 0;
            this.gbDetallesCurso.TabStop = false;
            this.gbDetallesCurso.Text = "Detalles de Curso";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.DataSource = this.courseBindingSource1;
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(366, 19);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(121, 21);
            this.cmbSemestre.TabIndex = 3;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.collegeDataSet12;
            // 
            // collegeDataSet12
            // 
            this.collegeDataSet12.DataSetName = "CollegeDataSet12";
            this.collegeDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(285, 20);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(51, 13);
            this.lblSemestre.TabIndex = 2;
            this.lblSemestre.Text = "Semestre";
            // 
            // cmbNombreCurso
            // 
            this.cmbNombreCurso.DataSource = this.courseBindingSource;
            this.cmbNombreCurso.FormattingEnabled = true;
            this.cmbNombreCurso.Location = new System.Drawing.Point(130, 20);
            this.cmbNombreCurso.Name = "cmbNombreCurso";
            this.cmbNombreCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreCurso.TabIndex = 1;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.collegeDataSet11;
            // 
            // collegeDataSet11
            // 
            this.collegeDataSet11.DataSetName = "CollegeDataSet11";
            this.collegeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(19, 20);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(88, 13);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre de curso";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 49);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(632, 25);
            this.fillByToolStrip.TabIndex = 5;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(35, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 74);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(632, 25);
            this.fillByToolStrip1.TabIndex = 6;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // courseTableAdapter2
            // 
            this.courseTableAdapter2.ClearBeforeFill = true;
            // 
            // fillByToolStrip2
            // 
            this.fillByToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton2});
            this.fillByToolStrip2.Location = new System.Drawing.Point(0, 99);
            this.fillByToolStrip2.Name = "fillByToolStrip2";
            this.fillByToolStrip2.Size = new System.Drawing.Size(632, 25);
            this.fillByToolStrip2.TabIndex = 7;
            this.fillByToolStrip2.Text = "fillByToolStrip2";
            // 
            // fillByToolStripButton2
            // 
            this.fillByToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton2.Name = "fillByToolStripButton2";
            this.fillByToolStripButton2.Size = new System.Drawing.Size(35, 22);
            this.fillByToolStripButton2.Text = "FillBy";
            this.fillByToolStripButton2.Click += new System.EventHandler(this.fillByToolStripButton2_Click);
            // 
            // frmCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fillByToolStrip2);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "frmCourseDetails";
            this.Load += new System.EventHandler(this.frmCourseDetails_Load);
            this.Controls.SetChildIndex(this.fillByToolStrip, 0);
            this.Controls.SetChildIndex(this.fillByToolStrip1, 0);
            this.Controls.SetChildIndex(this.fillByToolStrip2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet13)).EndInit();
            this.gbDetallesCurso.ResumeLayout(false);
            this.gbDetallesCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataconexionBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.fillByToolStrip2.ResumeLayout(false);
            this.fillByToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDetallesCurso;
        private System.Windows.Forms.ComboBox cmbNombreCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.BindingSource dataconexionBindingSource;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvDetallesCurso;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private CollegeDataSet11 collegeDataSet11;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CollegeDataSet11TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private CollegeDataSet12 collegeDataSet12;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private CollegeDataSet12TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private CollegeDataSet13 collegeDataSet13;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private CollegeDataSet13TableAdapters.CourseTableAdapter courseTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip2;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton2;
    }
}
