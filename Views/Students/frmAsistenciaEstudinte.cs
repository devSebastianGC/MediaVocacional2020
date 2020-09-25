using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace colegio2020media.Views.Students
{
    public partial class frmAsistenciaEstudinte : colegio2020media.frmPrincipalMDI
    {
        public frmAsistenciaEstudinte()
        {
            InitializeComponent();
        }

        private void frmAsistenciaEstudinte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet7.Schedule' Puede moverla o quitarla según sea necesario.
            this.scheduleTableAdapter.Fill(this.collegeDataSet7.Schedule);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet6.StuAttendance' Puede moverla o quitarla según sea necesario.
            this.stuAttendanceTableAdapter.Fill(this.collegeDataSet6.StuAttendance);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet5.Semester' Puede moverla o quitarla según sea necesario.
            this.semesterTableAdapter.Fill(this.collegeDataSet5.Semester);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet4.Course' Puede moverla o quitarla según sea necesario.
            this.courseTableAdapter.Fill(this.collegeDataSet4.Course);

        }

        private void cmbNombreCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.semesterTableAdapter.FillBy(this.collegeDataSet5.Semester);
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
                this.courseTableAdapter.FillBy(this.collegeDataSet4.Course);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.stuAttendanceTableAdapter.FillBy(this.collegeDataSet6.StuAttendance);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.scheduleTableAdapter.FillBy(this.collegeDataSet7.Schedule);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
