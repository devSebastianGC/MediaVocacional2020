using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace colegio2020media.Views.CourseDetails
{
    public partial class frmDetailStudents : colegio2020media.frmPrincipalMDI
    {
        public frmDetailStudents()
        {
            InitializeComponent();
        }

        private void frmDetailStudents_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet16.Course' Puede moverla o quitarla según sea necesario.
            this.courseTableAdapter1.Fill(this.collegeDataSet16.Course);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet15.TeacherRegister' Puede moverla o quitarla según sea necesario.
            this.teacherRegisterTableAdapter1.Fill(this.collegeDataSet15.TeacherRegister);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet14.Course' Puede moverla o quitarla según sea necesario.
            this.courseTableAdapter.Fill(this.collegeDataSet14.Course);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet2.RegStudent' Puede moverla o quitarla según sea necesario.
            this.regStudentTableAdapter.Fill(this.collegeDataSet2.RegStudent);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet.TeacherRegister' Puede moverla o quitarla según sea necesario.
            this.teacherRegisterTableAdapter.Fill(this.collegeDataSet.TeacherRegister);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherRegisterTableAdapter.FillBy(this.collegeDataSet.TeacherRegister);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter.FillBy(this.collegeDataSet14.Course);
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
                this.teacherRegisterTableAdapter1.FillBy(this.collegeDataSet15.TeacherRegister);
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
                this.courseTableAdapter1.FillBy(this.collegeDataSet16.Course);
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
                this.regStudentTableAdapter.FillBy(this.collegeDataSet2.RegStudent);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
