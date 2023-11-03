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
            this.BtnPersona2 = new System.Windows.Forms.Button();
            this.BtnCrearPersona = new System.Windows.Forms.Button();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPersona2
            // 
            this.BtnPersona2.Location = new System.Drawing.Point(155, 462);
            this.BtnPersona2.Name = "BtnPersona2";
            this.BtnPersona2.Size = new System.Drawing.Size(288, 72);
            this.BtnPersona2.TabIndex = 15;
            this.BtnPersona2.Text = "Crear Persona constructor parametrisado";
            this.BtnPersona2.UseVisualStyleBackColor = true;
            // 
            // BtnCrearPersona
            // 
            this.BtnCrearPersona.Location = new System.Drawing.Point(155, 321);
            this.BtnCrearPersona.Name = "BtnCrearPersona";
            this.BtnCrearPersona.Size = new System.Drawing.Size(288, 69);
            this.BtnCrearPersona.TabIndex = 14;
            this.BtnCrearPersona.Text = "Crear Persona";
            this.BtnCrearPersona.UseVisualStyleBackColor = true;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(192, 228);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(196, 29);
            this.TxtDni.TabIndex = 13;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(192, 158);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(196, 29);
            this.TxtApellido.TabIndex = 12;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(192, 100);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(196, 29);
            this.TxtNombre.TabIndex = 11;
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(83, 232);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(47, 25);
            this.LblDni.TabIndex = 10;
            this.LblDni.Text = "Dni:";
            this.LblDni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(83, 162);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(88, 25);
            this.LblApellido.TabIndex = 9;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(83, 100);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(87, 25);
            this.LblNombre.TabIndex = 8;
            this.LblNombre.Text = "Nombre:";
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

        private System.Windows.Forms.Button BtnPersona2;
        private System.Windows.Forms.Button BtnCrearPersona;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;

    }
}

