using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace colegio2020media.Model
{
    class Conexion
    {
        SqlConnection conn;

        public void Conector() 
        {
            conn = new SqlConnection(@"Data Source=FAMILIAGARCAR\SQLEXPRESS;Initial Catalog=College;Integrated Security=True");
            conn.Open();
        }

        public void Desconectar() 
        {
            conn.Close();
        }

        public void EjecutarSQL(String consulta) 
        {
            SqlCommand com = new SqlCommand(consulta, conn);

            int filasAfectadas = com.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Operacion realizada con exito",
                                "La base de datos ha sido actualizada", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("No se ha modificada la base de datos",
                                "error del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ActualizarGrid(DataGridView dg, String consulta)
        {
            this.Conector();

            System.Data.DataSet ds = new System.Data.DataSet();

            SqlDataAdapter da = new SqlDataAdapter(consulta, conn);

            da.Fill(ds, "PersonaAdministrador");
            dg.DataMember = "PersonaAdministrador";

            this.Desconectar();
        }




    }
}
