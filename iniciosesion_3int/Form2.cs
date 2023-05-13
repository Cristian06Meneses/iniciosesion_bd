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
    /// Formulario dos de registro, aqui se crean los nuevos usuarios.
    /// </summary>
    
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro que desea crear el usuario con nombre " + txt_new_usuario.Text + " y con la contraseña " + txt_new_pass.Text + " ??"
                , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (r == DialogResult.Yes)
            {
                Conexion co = new Conexion();
                co.registrar(txt_new_usuario.Text, txt_new_pass.Text);
                
                txt_new_usuario.Clear();
                txt_new_pass.Clear();
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();
            ventana1.Show();
            this.Hide();
        }
    }
}
