namespace ejemploPersona
{
    partial class frmEmpleado
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
            this.BtnPersona2 = new System.Windows.Forms.Button();
            this.BtnCrearPersona = new System.Windows.Forms.Button();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.TxtLegajo = new System.Windows.Forms.TextBox();
            this.lblHora_trabajada = new System.Windows.Forms.Label();
            this.TxtHora_trabajada = new System.Windows.Forms.TextBox();
            this.lblValor_horas = new System.Windows.Forms.Label();
            this.TxtValor_horas = new System.Windows.Forms.TextBox();
            this.dtpFecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.lblFecha_ingreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPersona2
            // 
            this.BtnPersona2.Location = new System.Drawing.Point(536, 157);
            this.BtnPersona2.Name = "BtnPersona2";
            this.BtnPersona2.Size = new System.Drawing.Size(288, 72);
            this.BtnPersona2.TabIndex = 23;
            this.BtnPersona2.Text = "Crear Persona constructor parametrisado";
            this.BtnPersona2.UseVisualStyleBackColor = true;
            this.BtnPersona2.Click += new System.EventHandler(this.BtnPersona2_Click);
            // 
            // BtnCrearPersona
            // 
            this.BtnCrearPersona.Location = new System.Drawing.Point(536, 29);
            this.BtnCrearPersona.Name = "BtnCrearPersona";
            this.BtnCrearPersona.Size = new System.Drawing.Size(288, 69);
            this.BtnCrearPersona.TabIndex = 22;
            this.BtnCrearPersona.Text = "Crear Persona";
            this.BtnCrearPersona.UseVisualStyleBackColor = true;
            this.BtnCrearPersona.Click += new System.EventHandler(this.BtnCrearPersona_Click);
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(151, 157);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(196, 29);
            this.TxtDni.TabIndex = 21;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(151, 87);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(196, 29);
            this.TxtApellido.TabIndex = 20;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(151, 29);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(196, 29);
            this.TxtNombre.TabIndex = 19;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(42, 161);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(47, 25);
            this.LblDni.TabIndex = 18;
            this.LblDni.Text = "Dni:";
            this.LblDni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(42, 91);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(88, 25);
            this.LblApellido.TabIndex = 17;
            this.LblApellido.Text = "Apellido:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(42, 29);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(87, 25);
            this.LblNombre.TabIndex = 16;
            this.LblNombre.Text = "Nombre:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(42, 236);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(71, 25);
            this.lblLegajo.TabIndex = 24;
            this.lblLegajo.Text = "Legajo";
            // 
            // TxtLegajo
            // 
            this.TxtLegajo.Location = new System.Drawing.Point(151, 232);
            this.TxtLegajo.Name = "TxtLegajo";
            this.TxtLegajo.Size = new System.Drawing.Size(196, 29);
            this.TxtLegajo.TabIndex = 25;
            // 
            // lblHora_trabajada
            // 
            this.lblHora_trabajada.AutoSize = true;
            this.lblHora_trabajada.Location = new System.Drawing.Point(24, 320);
            this.lblHora_trabajada.Name = "lblHora_trabajada";
            this.lblHora_trabajada.Size = new System.Drawing.Size(168, 25);
            this.lblHora_trabajada.TabIndex = 26;
            this.lblHora_trabajada.Text = "Horas Trabajadas";
            // 
            // TxtHora_trabajada
            // 
            this.TxtHora_trabajada.Location = new System.Drawing.Point(207, 317);
            this.TxtHora_trabajada.Name = "TxtHora_trabajada";
            this.TxtHora_trabajada.Size = new System.Drawing.Size(140, 29);
            this.TxtHora_trabajada.TabIndex = 27;
            // 
            // lblValor_horas
            // 
            this.lblValor_horas.AutoSize = true;
            this.lblValor_horas.Location = new System.Drawing.Point(24, 378);
            this.lblValor_horas.Name = "lblValor_horas";
            this.lblValor_horas.Size = new System.Drawing.Size(118, 25);
            this.lblValor_horas.TabIndex = 28;
            this.lblValor_horas.Text = "Valor_horas";
            this.lblValor_horas.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtValor_horas
            // 
            this.TxtValor_horas.Location = new System.Drawing.Point(207, 378);
            this.TxtValor_horas.Name = "TxtValor_horas";
            this.TxtValor_horas.Size = new System.Drawing.Size(140, 29);
            this.TxtValor_horas.TabIndex = 29;
            // 
            // dtpFecha_ingreso
            // 
            this.dtpFecha_ingreso.Location = new System.Drawing.Point(207, 452);
            this.dtpFecha_ingreso.Name = "dtpFecha_ingreso";
            this.dtpFecha_ingreso.Size = new System.Drawing.Size(200, 29);
            this.dtpFecha_ingreso.TabIndex = 30;
            // 
            // lblFecha_ingreso
            // 
            this.lblFecha_ingreso.AutoSize = true;
            this.lblFecha_ingreso.Location = new System.Drawing.Point(12, 452);
            this.lblFecha_ingreso.Name = "lblFecha_ingreso";
            this.lblFecha_ingreso.Size = new System.Drawing.Size(143, 25);
            this.lblFecha_ingreso.TabIndex = 31;
            this.lblFecha_ingreso.Text = "Fecha_Ingreso";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 598);
            this.Controls.Add(this.lblFecha_ingreso);
            this.Controls.Add(this.dtpFecha_ingreso);
            this.Controls.Add(this.TxtValor_horas);
            this.Controls.Add(this.lblValor_horas);
            this.Controls.Add(this.TxtHora_trabajada);
            this.Controls.Add(this.lblHora_trabajada);
            this.Controls.Add(this.TxtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.BtnPersona2);
            this.Controls.Add(this.BtnCrearPersona);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
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
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox TxtLegajo;
        private System.Windows.Forms.Label lblHora_trabajada;
        private System.Windows.Forms.TextBox TxtHora_trabajada;
        private System.Windows.Forms.Label lblValor_horas;
        private System.Windows.Forms.TextBox TxtValor_horas;
        private System.Windows.Forms.DateTimePicker dtpFecha_ingreso;
        private System.Windows.Forms.Label lblFecha_ingreso;
    }
}