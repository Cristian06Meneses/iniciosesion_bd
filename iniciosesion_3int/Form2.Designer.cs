namespace iniciosesion_3int
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_tituloreg = new System.Windows.Forms.Label();
            this.lbl_dig_usuario = new System.Windows.Forms.Label();
            this.lbl_dig_pass = new System.Windows.Forms.Label();
            this.txt_new_usuario = new System.Windows.Forms.TextBox();
            this.txt_new_pass = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tituloreg
            // 
            this.lbl_tituloreg.AutoSize = true;
            this.lbl_tituloreg.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloreg.Location = new System.Drawing.Point(334, 46);
            this.lbl_tituloreg.Name = "lbl_tituloreg";
            this.lbl_tituloreg.Size = new System.Drawing.Size(124, 23);
            this.lbl_tituloreg.TabIndex = 1;
            this.lbl_tituloreg.Text = "REGISTRO";
            // 
            // lbl_dig_usuario
            // 
            this.lbl_dig_usuario.AutoSize = true;
            this.lbl_dig_usuario.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dig_usuario.Location = new System.Drawing.Point(86, 145);
            this.lbl_dig_usuario.Name = "lbl_dig_usuario";
            this.lbl_dig_usuario.Size = new System.Drawing.Size(137, 14);
            this.lbl_dig_usuario.TabIndex = 4;
            this.lbl_dig_usuario.Text = "Digite el nombre usuario:";
            // 
            // lbl_dig_pass
            // 
            this.lbl_dig_pass.AutoSize = true;
            this.lbl_dig_pass.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dig_pass.Location = new System.Drawing.Point(506, 145);
            this.lbl_dig_pass.Name = "lbl_dig_pass";
            this.lbl_dig_pass.Size = new System.Drawing.Size(109, 14);
            this.lbl_dig_pass.TabIndex = 5;
            this.lbl_dig_pass.Text = "Digite la contraseña:";
            // 
            // txt_new_usuario
            // 
            this.txt_new_usuario.Location = new System.Drawing.Point(89, 162);
            this.txt_new_usuario.Name = "txt_new_usuario";
            this.txt_new_usuario.Size = new System.Drawing.Size(204, 20);
            this.txt_new_usuario.TabIndex = 6;
            // 
            // txt_new_pass
            // 
            this.txt_new_pass.Location = new System.Drawing.Point(509, 162);
            this.txt_new_pass.Name = "txt_new_pass";
            this.txt_new_pass.Size = new System.Drawing.Size(204, 20);
            this.txt_new_pass.TabIndex = 7;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(329, 298);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(162, 44);
            this.btn_registrar.TabIndex = 8;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(329, 264);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(162, 28);
            this.btn_volver.TabIndex = 9;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_new_pass);
            this.Controls.Add(this.txt_new_usuario);
            this.Controls.Add(this.lbl_dig_pass);
            this.Controls.Add(this.lbl_dig_usuario);
            this.Controls.Add(this.lbl_tituloreg);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tituloreg;
        private System.Windows.Forms.Label lbl_dig_usuario;
        private System.Windows.Forms.Label lbl_dig_pass;
        private System.Windows.Forms.TextBox txt_new_usuario;
        private System.Windows.Forms.TextBox txt_new_pass;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_volver;
    }
}