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
    /// Esta es la pantalla principal para iniciar sesion solo con tres intentos
    /// haciendo la verificacion en la base de datos.
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

                txt_usuario.Clear();
                txt_pass.Clear();
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
