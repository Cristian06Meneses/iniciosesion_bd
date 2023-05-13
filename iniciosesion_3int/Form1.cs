using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iniciosesion_3int
{
    /// <summary>
    /// Esta es la pantalla principal para iniciar sesion solo con tres intentos.
    /// </summary>

    public partial class Form1 : Form
    {
        int tiempo = 0;
        bool entrar = false;
        int contador = 0;

        public Form1()
        {
            InitializeComponent();

            Conexion c = new Conexion();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            entrar = c.check(txt_usuario.Text, txt_pass.Text);
            
            if (entrar == true)
            {
                MessageBox.Show("Usuario ingresado correctamente :D");

                contador = 0;

                lbl_mensaje.Visible = false;
            }
            else
            {
                contador = contador + 1;
                MessageBox.Show("Usuario o contraseña incorrectos D:",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lbl_mensaje.Text = "Numero de intentos: " + contador;
                lbl_mensaje.Visible = true;
            }

            if (contador == 3)
            {
                MessageBox.Show("Has excedido el numero de intentos D:");

                this.Close();
            }

            /*try
            {
                bool test = datareader_sqlite.Read();

                MessageBox.Show("Usuario ingresado correctamente :D");

                contador = 0;

                lbl_mensaje.Visible = false;
            }
            catch(Exception ex)
            {
                contador = contador + 1;
                MessageBox.Show("Usuario o contraseña incorrectos D:",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lbl_mensaje.Text = "Numero de intentos: " + contador;
                lbl_mensaje.Visible = true;

                if (contador == 3)
                {
                    MessageBox.Show("Has excedido el numero de intentos D:");

                    this.Close();
                }
            }
            bool test = datareader_sqlite;

            if (test == true)
            {
                MessageBox.Show("Usuario ingresado correctamente :D");

                contador = 0;

                lbl_mensaje.Visible = false;
            }
            else
            {
                contador = contador + 1;
                MessageBox.Show("Usuario o contraseña incorrectos D:",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lbl_mensaje.Text = "Numero de intentos: " + contador;
                lbl_mensaje.Visible = true;

                if (contador == 3)
                {
                    MessageBox.Show("Has excedido el numero de intentos D:");

                    this.Close();
                }
            }

            conexion_sqlite.Close();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i] == txt_usuario.Text && pass[i] == txt_pass.Text)
                {
                    MessageBox.Show("Usuario ingresado correctamente :D");

                    contador = 0;

                    lbl_mensaje.Visible = false;
                    break;
                }

                if (i == (usuarios.Count - 1))
                {
                    contador = contador + 1;
                    MessageBox.Show("Usuario o contraseña incorrectos D:",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lbl_mensaje.Text = "Numero de intentos: " + contador;
                    lbl_mensaje.Visible = true;
                }

                if (contador == 3)
                {
                    MessageBox.Show("Has excedido el numero de intentos D:");

                    this.Close();
                }
            }*/
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();
            ventana2.Show();
            this.Hide();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            tiempo = tiempo + 1;

            if (tiempo == 15)
            {
                lbl_mensaje.Visible = false;
            }
        }
    }
}

            /*SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteDataReader datareader_sqlite;

            conexion_sqlite = new SQLiteConnection("Data Source=DB_fact.db;Version=3;Compress=False;");

            conexion_sqlite.Open();

            cmd_sqlite = conexion_sqlite.CreateCommand();

            El objeto SQLiteCommando va a conocer la consulta de SQL
            cmd_sqlite.CommandText = "CREATE TABLE demo(id integer primary key, texto varchar(100));";

            Ejecutaremos la consulta que hemos creado
            cmd_sqlite.ExecuteNonQuery();

            Insertando datos en la tabla
            cmd_sqlite.CommandText = "INSERT INTO demo(id, texto) VALUES (72786546, 'Sacarias Piedras del rio');";
            cmd_sqlite.ExecuteNonQuery();

            cmd_sqlite.CommandText = "INSERT INTO demo(id, texto) VALUES (2, 'Este es el segundo texto');";

            Ejecutamos nuevamente la consulta
            cmd_sqlite.ExecuteNonQuery();

            cmd_sqlite.CommandText = "SELECT id,texto FROM demo";

            datareader_sqlite = cmd_sqlite.ExecuteReader();

            while (datareader_sqlite.Read())
            {
                Mostrando los datos

                string lectura = datareader_sqlite.GetString(0);
                lectura = lectura + datareader_sqlite.GetString(1);
                MessageBox.Show(lectura);

            }


            conexion_sqlite.Close();*/