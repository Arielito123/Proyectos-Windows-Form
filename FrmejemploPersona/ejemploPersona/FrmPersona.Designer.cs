namespace ejemploPersona
{
    partial class FrmPersona
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.BtnCrearPersona = new System.Windows.Forms.Button();
            this.BtnPersona2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(56, 41);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(87, 25);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(56, 103);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(88, 25);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido:";
            this.LblApellido.Click += new System.EventHandler(this.LblApellido_Click);
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(56, 173);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(47, 25);
            this.LblDni.TabIndex = 2;
            this.LblDni.Text = "Dni:";
            this.LblDni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(165, 41);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(196, 29);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(165, 99);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(196, 29);
            this.TxtApellido.TabIndex = 4;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(165, 169);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(196, 29);
            this.TxtDni.TabIndex = 5;
            this.TxtDni.TextChanged += new System.EventHandler(this.TxtDni_TextChanged);
            // 
            // BtnCrearPersona
            // 
            this.BtnCrearPersona.Location = new System.Drawing.Point(128, 262);
            this.BtnCrearPersona.Name = "BtnCrearPersona";
            this.BtnCrearPersona.Size = new System.Drawing.Size(288, 69);
            this.BtnCrearPersona.TabIndex = 6;
            this.BtnCrearPersona.Text = "Crear Persona";
            this.BtnCrearPersona.UseVisualStyleBackColor = true;
            this.BtnCrearPersona.Click += new System.EventHandler(this.BtnCrearPersona_Click);
            // 
            // BtnPersona2
            // 
            this.BtnPersona2.Location = new System.Drawing.Point(128, 403);
            this.BtnPersona2.Name = "BtnPersona2";
            this.BtnPersona2.Size = new System.Drawing.Size(288, 72);
            this.BtnPersona2.TabIndex = 7;
            this.BtnPersona2.Text = "Crear Persona constructor parametrisado";
            this.BtnPersona2.UseVisualStyleBackColor = true;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(527, 635);
            this.Controls.Add(this.BtnPersona2);
            this.Controls.Add(this.BtnCrearPersona);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Name = "FrmPersona";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Button BtnCrearPersona;
        private System.Windows.Forms.Button BtnPersona2;
    }
}

