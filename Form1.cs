using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using colegio2020media.Model;

namespace colegio2020media
{
    public partial class Form1 : Form
    {
        Conexion conn = new Conexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conn.Conector();

            String consulta = "insert into PersonaAdministrador (nombre_administrador, apellido_administrador, edad_administrador)";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            conn.ActualizarGrid(this.dataGridView1, "Select * from PersonaAdministrador");
        }
    }
}
