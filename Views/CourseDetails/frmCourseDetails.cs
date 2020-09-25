using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colegio2020media.Views.CourseDetails
{
    public partial class frmCourseDetails : colegio2020media.frmPrincipalMDI
    {
        private static string CourseName;
        private static string Semester;

        public object CourseId { get; private set; }

        public frmCourseDetails()
        {
            InitializeComponent();
        }

        private void frmCourseDetails_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet13.Course' Puede moverla o quitarla según sea necesario.
            this.courseTableAdapter2.Fill(this.collegeDataSet13.Course);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet12.Course' Puede moverla o quitarla según sea necesario.
            this.courseTableAdapter1.Fill(this.collegeDataSet12.Course);
            // TODO: esta línea de código carga datos en la tabla 'collegeDataSet11.Course' Puede moverla o quitarla según sea necesario.
            this.courseTableAdapter.Fill(this.collegeDataSet11.Course);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValidation())
                {
                    return;
                }

                //frmCourseDetails.Id = CourseId;
                frmCourseDetails.CourseName = cmbNombreCurso.Text;
                frmCourseDetails.Semester = cmbSemestre.Text;

                MessageBox.Show("Saved Successfully.", Global.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvDetallesCurso.Rows.Clear();
                BindData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Global.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckValidation()
        {
            throw new NotImplementedException();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void BindData()
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DResult;
                DResult = MessageBox.Show("¿Seguro quieres eliminar el registro?", Global.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                    //frmCourseDetails.Id = CourseId;
                    frmCourseDetails.CourseName = cmbNombreCurso.Text;
                    frmCourseDetails.Semester = cmbSemestre.Text;
                    MessageBox.Show("Eliminado correctamente.", Global.Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    dgvDetallesCurso.Rows.Clear();
                    BindData();
                    this.btnAgregar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Global.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter.FillBy(this.collegeDataSet11.Course);
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
                this.courseTableAdapter1.FillBy(this.collegeDataSet12.Course);
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
                this.courseTableAdapter2.FillBy(this.collegeDataSet13.Course);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgvDetallesCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
