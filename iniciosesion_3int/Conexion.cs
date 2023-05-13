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
    internal class Conexion
    {
        SqlConnection conec;
        SqlCommand cmd;
        SqlDataReader dr_lector;
        string estado = "";

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

        public string registrar(string usuario, string pass)
        {
            string resultado = "Registrado correctamente";

            try
            {
                cmd = new SqlCommand("insert into tbl_usuarios values('"+ usuario + "', '" + pass + "' )");
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario creado :D");
            }
            catch(Exception ex)
            {
                resultado = "No se pudo registrar: " + ex.ToString();
            }

            return resultado;
        }

        public bool check(string usuario, string pass)
        {
            bool verificar_nom = false;
            bool verificar_ps = false;
            bool resultado = false;

            try
            {
                cmd = new SqlCommand("select nom_usu from tbl_usuarios where nom_usu = " + usuario + "");
                dr_lector = cmd.ExecuteReader();
                while (dr_lector.Read())
                {
                    
                    verificar_nom = true;
                }
            }
            catch(Exception ex)
            {
                verificar_nom = false;
            }

            try
            {
                cmd = new SqlCommand("select pass from tbl_usuarios where pass = " + pass + "");
                dr_lector = cmd.ExecuteReader();
                while (dr_lector.Read())
                {
                    verificar_ps = true;
                }
            }
            catch (Exception ex)
            {
                verificar_ps = false;
            }

            if (verificar_nom == true && verificar_ps == true)
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
