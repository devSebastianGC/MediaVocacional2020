namespace colegio2020media.Views.CourseDetails
{
    partial class frmDetailStudents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.regStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet2 = new colegio2020media.CollegeDataSet2();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbDetalleEstudiante = new System.Windows.Forms.GroupBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet16 = new colegio2020media.CollegeDataSet16();
            this.cmbNombreProfesor = new System.Windows.Forms.ComboBox();
            this.teacherRegisterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet15 = new colegio2020media.CollegeDataSet15();
            this.cmbNombreGrupo = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet14 = new colegio2020media.CollegeDataSet14();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.teacherRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet = new colegio2020media.CollegeDataSet();
            this.teacherRegisterTableAdapter = new colegio2020media.CollegeDataSetTableAdapters.TeacherRegisterTableAdapter();
            this.regStudentTableAdapter = new colegio2020media.CollegeDataSet2TableAdapters.RegStudentTableAdapter();
            this.courseTableAdapter = new colegio2020media.CollegeDataSet14TableAdapters.CourseTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.teacherRegisterTableAdapter1 = new colegio2020media.CollegeDataSet15TableAdapters.TeacherRegisterTableAdapter();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.courseTableAdapter1 = new colegio2020media.CollegeDataSet16TableAdapters.CourseTableAdapter();
            this.fillByToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet2)).BeginInit();
            this.gbDetalleEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherRegisterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet14)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.teacherRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillByToolStrip1.SuspendLayout();
            this.fillByToolStrip2.SuspendLayout();
            this.fillByToolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.gbDetalleEstudiante);
            this.panel1.Location = new System.Drawing.Point(13, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 364);
            this.panel1.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(399, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.studentPicDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.regStudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // studentPicDataGridViewImageColumn
            // 
            this.studentPicDataGridViewImageColumn.DataPropertyName = "StudentPic";
            this.studentPicDataGridViewImageColumn.HeaderText = "StudentPic";
            this.studentPicDataGridViewImageColumn.Name = "studentPicDataGridViewImageColumn";
            // 
            // regStudentBindingSource
            // 
            this.regStudentBindingSource.DataMember = "RegStudent";
            this.regStudentBindingSource.DataSource = this.collegeDataSet2;
            // 
            // collegeDataSet2
            // 
            this.collegeDataSet2.DataSetName = "CollegeDataSet2";
            this.collegeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(390, 115);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(139, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // gbDetalleEstudiante
            // 
            this.gbDetalleEstudiante.Controls.Add(this.cmbSemestre);
            this.gbDetalleEstudiante.Controls.Add(this.cmbNombreProfesor);
            this.gbDetalleEstudiante.Controls.Add(this.cmbNombreGrupo);
            this.gbDetalleEstudiante.Controls.Add(this.lblSemestre);
            this.gbDetalleEstudiante.Controls.Add(this.lblNombreProfesor);
            this.gbDetalleEstudiante.Controls.Add(this.lblNombreGrupo);
            this.gbDetalleEstudiante.Location = new System.Drawing.Point(22, 15);
            this.gbDetalleEstudiante.Name = "gbDetalleEstudiante";
            this.gbDetalleEstudiante.Size = new System.Drawing.Size(843, 81);
            this.gbDetalleEstudiante.TabIndex = 0;
            this.gbDetalleEstudiante.TabStop = false;
            this.gbDetalleEstudiante.Text = "Detalle estudiante por grupo";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.DataSource = this.courseBindingSource1;
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(654, 28);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(121, 21);
            this.cmbSemestre.TabIndex = 5;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.collegeDataSet16;
            // 
            // collegeDataSet16
            // 
            this.collegeDataSet16.DataSetName = "CollegeDataSet16";
            this.collegeDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNombreProfesor
            // 
            this.cmbNombreProfesor.DataSource = this.teacherRegisterBindingSource1;
            this.cmbNombreProfesor.FormattingEnabled = true;
            this.cmbNombreProfesor.Location = new System.Drawing.Point(377, 28);
            this.cmbNombreProfesor.Name = "cmbNombreProfesor";
            this.cmbNombreProfesor.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreProfesor.TabIndex = 4;
            // 
            // teacherRegisterBindingSource1
            // 
            this.teacherRegisterBindingSource1.DataMember = "TeacherRegister";
            this.teacherRegisterBindingSource1.DataSource = this.collegeDataSet15;
            // 
            // collegeDataSet15
            // 
            this.collegeDataSet15.DataSetName = "CollegeDataSet15";
            this.collegeDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNombreGrupo
            // 
            this.cmbNombreGrupo.DataSource = this.courseBindingSource;
            this.cmbNombreGrupo.FormattingEnabled = true;
            this.cmbNombreGrupo.Location = new System.Drawing.Point(102, 29);
            this.cmbNombreGrupo.Name = "cmbNombreGrupo";
            this.cmbNombreGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbNombreGrupo.TabIndex = 3;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.collegeDataSet14;
            // 
            // collegeDataSet14
            // 
            this.collegeDataSet14.DataSetName = "CollegeDataSet14";
            this.collegeDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(581, 29);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(51, 13);
            this.lblSemestre.TabIndex = 2;
            this.lblSemestre.Text = "Semestre";
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.Location = new System.Drawing.Point(272, 29);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(86, 13);
            this.lblNombreProfesor.TabIndex = 1;
            this.lblNombreProfesor.Text = "Nombre Profesor";
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(7, 29);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(76, 13);
            this.lblNombreGrupo.TabIndex = 0;
            this.lblNombreGrupo.Text = "Nombre Grupo";
            
            // 
            // teacherRegisterBindingSource
            // 
            this.teacherRegisterBindingSource.DataMember = "TeacherRegister";
            this.teacherRegisterBindingSource.DataSource = this.collegeDataSet;
            // 
            // collegeDataSet
            // 
            this.collegeDataSet.DataSetName = "CollegeDataSet";
            this.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherRegisterTableAdapter
            // 
            this.teacherRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // regStudentTableAdapter
            // 
            this.regStudentTableAdapter.ClearBeforeFill = true;
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
            this.fillByToolStrip.Size = new System.Drawing.Size(906, 25);
            this.fillByToolStrip.TabIndex = 5;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(35, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // teacherRegisterTableAdapter1
            // 
            this.teacherRegisterTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 74);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(906, 25);
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
            this.fillByToolStrip2.Size = new System.Drawing.Size(906, 25);
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
            // fillByToolStrip3
            // 
            this.fillByToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton3});
            this.fillByToolStrip3.Location = new System.Drawing.Point(0, 124);
            this.fillByToolStrip3.Name = "fillByToolStrip3";
            this.fillByToolStrip3.Size = new System.Drawing.Size(906, 25);
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
            // frmDetailStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(906, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fillByToolStrip3);
            this.Controls.Add(this.fillByToolStrip2);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "frmDetailStudents";
            this.Load += new System.EventHandler(this.frmDetailStudents_Load);
            this.Controls.SetChildIndex(this.fillByToolStrip, 0);
            this.Controls.SetChildIndex(this.fillByToolStrip1, 0);
            this.Controls.SetChildIndex(this.fillByToolStrip2, 0);
            this.Controls.SetChildIndex(this.fillByToolStrip3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet2)).EndInit();
            this.gbDetalleEstudiante.ResumeLayout(false);
            this.gbDetalleEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherRegisterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
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
        private System.Windows.Forms.GroupBox gbDetalleEstudiante;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblNombreProfesor;
        private System.Windows.Forms.Label lblNombreGrupo;
        private CollegeDataSet collegeDataSet;
        private System.Windows.Forms.BindingSource teacherRegisterBindingSource;
        private CollegeDataSetTableAdapters.TeacherRegisterTableAdapter teacherRegisterTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultar;
        private CollegeDataSet2 collegeDataSet2;
        private System.Windows.Forms.BindingSource regStudentBindingSource;
        private CollegeDataSet2TableAdapters.RegStudentTableAdapter regStudentTableAdapter;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn studentPicDataGridViewImageColumn;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.ComboBox cmbNombreProfesor;
        private System.Windows.Forms.ComboBox cmbNombreGrupo;
        private CollegeDataSet14 collegeDataSet14;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CollegeDataSet14TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private CollegeDataSet15 collegeDataSet15;
        private System.Windows.Forms.BindingSource teacherRegisterBindingSource1;
        private CollegeDataSet15TableAdapters.TeacherRegisterTableAdapter teacherRegisterTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private CollegeDataSet16 collegeDataSet16;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private CollegeDataSet16TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip2;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton2;
        private System.Windows.Forms.ToolStrip fillByToolStrip3;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton3;
    }
}
