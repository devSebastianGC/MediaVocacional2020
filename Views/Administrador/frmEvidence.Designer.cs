namespace colegio2020media.Views.Administrador
{
    partial class frmEvidence
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idevidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreevidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileurlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoevidenciaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsujetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet10 = new colegio2020media.CollegeDataSet10();
            this.btnMostrarEvidencia = new System.Windows.Forms.Button();
            this.gbDescripcion = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaEvidencia = new System.Windows.Forms.DateTimePicker();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet9 = new colegio2020media.CollegeDataSet9();
            this.cmbColegio = new System.Windows.Forms.ComboBox();
            this.colegioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet8 = new colegio2020media.CollegeDataSet8();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.teacherRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet3 = new colegio2020media.CollegeDataSet3();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.lblNombreColegio = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.subjectDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evidenciaDataSet = new colegio2020media.EvidenciaDataSet();
            this.collegeDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet2 = new colegio2020media.CollegeDataSet2();
            this.teacherRegisterTableAdapter = new colegio2020media.CollegeDataSet3TableAdapters.TeacherRegisterTableAdapter();
            this.nombreCursoDataSet = new colegio2020media.NombreCursoDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new colegio2020media.NombreCursoDataSetTableAdapters.CourseTableAdapter();
            this.subjectDetailsTableAdapter = new colegio2020media.EvidenciaDataSetTableAdapters.SubjectDetailsTableAdapter();
            this.colegioTableAdapter = new colegio2020media.CollegeDataSet8TableAdapters.colegioTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.courseTableAdapter1 = new colegio2020media.CollegeDataSet9TableAdapters.CourseTableAdapter();
            this.fillByToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.evidenciaTableAdapter = new colegio2020media.CollegeDataSet10TableAdapters.EvidenciaTableAdapter();
            this.fillByToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet10)).BeginInit();
            this.gbDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colegioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreCursoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillByToolStrip1.SuspendLayout();
            this.fillByToolStrip2.SuspendLayout();
            this.fillByToolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnMostrarEvidencia);
            this.panel1.Controls.Add(this.gbDescripcion);
            this.panel1.Location = new System.Drawing.Point(13, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 395);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(512, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(144, 352);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idevidenciaDataGridViewTextBoxColumn,
            this.nombreevidenciaDataGridViewTextBoxColumn,
            this.fileurlDataGridViewTextBoxColumn,
            this.tiempoevidenciaDataGridViewImageColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.idsujetoDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evidenciaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 161);
            this.dataGridView1.TabIndex = 2;
            // 
            // idevidenciaDataGridViewTextBoxColumn
            // 
            this.idevidenciaDataGridViewTextBoxColumn.DataPropertyName = "id_evidencia";
            this.idevidenciaDataGridViewTextBoxColumn.HeaderText = "id_evidencia";
            this.idevidenciaDataGridViewTextBoxColumn.Name = "idevidenciaDataGridViewTextBoxColumn";
            this.idevidenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreevidenciaDataGridViewTextBoxColumn
            // 
            this.nombreevidenciaDataGridViewTextBoxColumn.DataPropertyName = "nombre_evidencia";
            this.nombreevidenciaDataGridViewTextBoxColumn.HeaderText = "nombre_evidencia";
            this.nombreevidenciaDataGridViewTextBoxColumn.Name = "nombreevidenciaDataGridViewTextBoxColumn";
            // 
            // fileurlDataGridViewTextBoxColumn
            // 
            this.fileurlDataGridViewTextBoxColumn.DataPropertyName = "file_url";
            this.fileurlDataGridViewTextBoxColumn.HeaderText = "file_url";
            this.fileurlDataGridViewTextBoxColumn.Name = "fileurlDataGridViewTextBoxColumn";
            // 
            // tiempoevidenciaDataGridViewImageColumn
            // 
            this.tiempoevidenciaDataGridViewImageColumn.DataPropertyName = "tiempo_evidencia";
            this.tiempoevidenciaDataGridViewImageColumn.HeaderText = "tiempo_evidencia";
            this.tiempoevidenciaDataGridViewImageColumn.Name = "tiempoevidenciaDataGridViewImageColumn";
            this.tiempoevidenciaDataGridViewImageColumn.ReadOnly = true;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            // 
            // idsujetoDataGridViewTextBoxColumn
            // 
            this.idsujetoDataGridViewTextBoxColumn.DataPropertyName = "id_sujeto";
            this.idsujetoDataGridViewTextBoxColumn.HeaderText = "id_sujeto";
            this.idsujetoDataGridViewTextBoxColumn.Name = "idsujetoDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            // 
            // evidenciaBindingSource
            // 
            this.evidenciaBindingSource.DataMember = "Evidencia";
            this.evidenciaBindingSource.DataSource = this.collegeDataSet10;
            // 
            // collegeDataSet10
            // 
            this.collegeDataSet10.DataSetName = "CollegeDataSet10";
            this.collegeDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMostrarEvidencia
            // 
            this.btnMostrarEvidencia.Location = new System.Drawing.Point(276, 132);
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
            this.cmbGrupo.DataSource = this.courseBindingSource1;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(614, 28);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupo.TabIndex = 5;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.collegeDataSet9;
            // 
            // collegeDataSet9
            // 
            this.collegeDataSet9.DataSetName = "CollegeDataSet9";
            this.collegeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbColegio
            // 
            this.cmbColegio.DataSource = this.colegioBindingSource;
            this.cmbColegio.FormattingEnabled = true;
            this.cmbColegio.Location = new System.Drawing.Point(369, 29);
            this.cmbColegio.Name = "cmbColegio";
            this.cmbColegio.Size = new System.Drawing.Size(121, 21);
            this.cmbColegio.TabIndex = 4;
            // 
            // colegioBindingSource
            // 
            this.colegioBindingSource.DataMember = "colegio";
            this.colegioBindingSource.DataSource = this.collegeDataSet8;
            // 
            // collegeDataSet8
            // 
            this.collegeDataSet8.DataSetName = "CollegeDataSet8";
            this.collegeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DataSource = this.teacherRegisterBindingSource;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(110, 29);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(145, 21);
            this.cmbProfesor.TabIndex = 3;
            // 
            // teacherRegisterBindingSource
            // 
            this.teacherRegisterBindingSource.DataMember = "TeacherRegister";
            this.teacherRegisterBindingSource.DataSource = this.collegeDataSet3;
            // 
            // collegeDataSet3
            // 
            this.collegeDataSet3.DataSetName = "CollegeDataSet3";
            this.collegeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // subjectDetailsBindingSource
            // 
            this.subjectDetailsBindingSource.DataMember = "SubjectDetails";
            this.subjectDetailsBindingSource.DataSource = this.evidenciaDataSet;
            // 
            // evidenciaDataSet
            // 
            this.evidenciaDataSet.DataSetName = "EvidenciaDataSet";
            this.evidenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collegeDataSet2BindingSource
            // 
            this.collegeDataSet2BindingSource.DataSource = this.collegeDataSet2;
            this.collegeDataSet2BindingSource.Position = 0;
            // 
            // collegeDataSet2
            // 
            this.collegeDataSet2.DataSetName = "CollegeDataSet2";
            this.collegeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherRegisterTableAdapter
            // 
            this.teacherRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // nombreCursoDataSet
            // 
            this.nombreCursoDataSet.DataSetName = "NombreCursoDataSet";
            this.nombreCursoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.nombreCursoDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // subjectDetailsTableAdapter
            // 
            this.subjectDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // colegioTableAdapter
            // 
            this.colegioTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 49);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(801, 25);
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
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 74);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(801, 25);
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
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip2
            // 
            this.fillByToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton2});
            this.fillByToolStrip2.Location = new System.Drawing.Point(0, 99);
            this.fillByToolStrip2.Name = "fillByToolStrip2";
            this.fillByToolStrip2.Size = new System.Drawing.Size(801, 25);
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
            // evidenciaTableAdapter
            // 
            this.evidenciaTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip3
            // 
            this.fillByToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton3});
            this.fillByToolStrip3.Location = new System.Drawing.Point(0, 124);
            this.fillByToolStrip3.Name = "fillByToolStrip3";
            this.fillByToolStrip3.Size = new System.Drawing.Size(801, 25);
            this.fillByToolStrip3.TabIndex = 8;
            this.fillByToolStrip3.Text = "fillByToolStrip3";
            // 
            // fillByToolStripButton3
            // 
            this.fillByToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton3.Name = "fillByToolStripButton3";
            this.fillByToolStripButton3.Size = new System.Drawing.Size(35, 22);
            this.fillByToolStripButton3.Text = "FillBy";
            this.fillByToolStripButton3.Click += new System.EventHandler(this.fillByToolStripButton3_Click);
            // 
            // frmEvidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(801, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fillByToolStrip3);
            this.Controls.Add(this.fillByToolStrip2);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "frmEvidence";
            this.Load += new System.EventHandler(this.frmEvidence_Load);
            this.Controls.SetChildIndex(this.fillByToolStrip, 0);
            this.Controls.SetChildIndex(this.fillByToolStrip1, 0);
            this.Controls.SetChildIndex(this.fillByToolStrip2, 0);
            this.Controls.SetChildIndex(this.fillByToolStrip3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet10)).EndInit();
            this.gbDescripcion.ResumeLayout(false);
            this.gbDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colegioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreCursoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.fillByToolStrip2.ResumeLayout(false);
            this.fillByToolStrip2.PerformLayout();
            this.fillByToolStrip3.ResumeLayout(false);
            this.fillByToolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDescripcion;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Label lblNombreColegio;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private CollegeDataSet3 collegeDataSet3;
        private System.Windows.Forms.BindingSource teacherRegisterBindingSource;
        private CollegeDataSet3TableAdapters.TeacherRegisterTableAdapter teacherRegisterTableAdapter;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.ComboBox cmbColegio;
        private NombreCursoDataSet nombreCursoDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private NombreCursoDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrarEvidencia;
        private EvidenciaDataSet evidenciaDataSet;
        private System.Windows.Forms.BindingSource subjectDetailsBindingSource;
        private EvidenciaDataSetTableAdapters.SubjectDetailsTableAdapter subjectDetailsTableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaEvidencia;
        private System.Windows.Forms.BindingSource collegeDataSet2BindingSource;
        private CollegeDataSet2 collegeDataSet2;
        private CollegeDataSet8 collegeDataSet8;
        private System.Windows.Forms.BindingSource colegioBindingSource;
        private CollegeDataSet8TableAdapters.colegioTableAdapter colegioTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private CollegeDataSet9 collegeDataSet9;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private CollegeDataSet9TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip2;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton2;
        private CollegeDataSet10 collegeDataSet10;
        private System.Windows.Forms.BindingSource evidenciaBindingSource;
        private CollegeDataSet10TableAdapters.EvidenciaTableAdapter evidenciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idevidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreevidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileurlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn tiempoevidenciaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsujetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip3;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton3;
    }
}
