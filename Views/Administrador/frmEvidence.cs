using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace colegio2020media.Views.Administrador
{
    public partial class frmEvidence : colegio2020media.frmPrincipalMDI
    {
        public frmEvidence()
        {
            InitializeComponent();
        }

        private void frmEvidence_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet10.Evidencia' Puede moverla o quitarla según sea necesario.
            this.evidenciaTableAdapter.Fill(this.collegeDataSet10.Evidencia);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet9.Course' Puede moverla o quitarla según sea necesario.
            this.courseTableAdapter1.Fill(this.collegeDataSet9.Course);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet8.colegio' Puede moverla o quitarla según sea necesario.
            this.colegioTableAdapter.Fill(this.collegeDataSet8.colegio);
            // TODO: esta línea de código carga datos en la tabla 'evidenciaDataSet.SubjectDetails' Puede moverla o quitarla según sea necesario.
            this.subjectDetailsTableAdapter.Fill(this.evidenciaDataSet.SubjectDetails);
            // TODO: esta línea de código carga datos en la tabla 'nombreCursoDataSet.Course' Puede moverla o quitarla según sea necesario.
            this.courseTableAdapter.Fill(this.nombreCursoDataSet.Course);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet3.TeacherRegister' Puede moverla o quitarla según sea necesario.
            this.teacherRegisterTableAdapter.Fill(this.collegeDataSet3.TeacherRegister);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.colegioTableAdapter.FillBy(this.collegeDataSet8.colegio);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherRegisterTableAdapter.FillBy(this.collegeDataSet3.TeacherRegister);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter1.FillBy(this.collegeDataSet9.Course);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.evidenciaTableAdapter.FillBy(this.collegeDataSet10.Evidencia);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
