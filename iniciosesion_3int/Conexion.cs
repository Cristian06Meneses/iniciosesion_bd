using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace iniciosesion_3int
{
    /// <summary>
    /// Esta es la clase conexion donde se ejecuta todo lo necesario para la conexion
    /// con la base de datos conectar/agregar/verificar.
    /// </summary>
    internal class Conexion
    {
        SqlConnection conec;
        SqlCommand cmd;
        SqlDataReader dr_lector;

        public Conexion()
        {
            try
            {
                conec = new SqlConnection("Data Source=.;Initial Catalog=db_usuarios;Integrated Security=True");
                conec.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion: " + ex.ToString());
            }

        }

        public bool registrar(string usuario, string pass)
        {
            bool r = false;
            string resultado = "Registrado correctamente";
            string query = "insert into tbl_usuarios values('" + usuario + "', '" + pass + "' )";

            cmd = new SqlCommand(query, conec);

            try
            {
                cmd.ExecuteReader();

                r = true;

                MessageBox.Show(resultado);
            }
            catch(Exception ex)
            {
                resultado = "No se pudo registrar: " + ex.ToString();
                MessageBox.Show(resultado);
            }

            return r;
        }

        public bool check(string usuario, string pass)
        {
            bool resultado = false;
            string query = "Select nom_usu, pass from tbl_usuarios where nom_usu = '" + usuario + "' and pass = '" + pass + "'";

            cmd = new SqlCommand(query, conec);

            dr_lector = cmd.ExecuteReader();
            bool entrar = dr_lector.HasRows;

            if (entrar)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
