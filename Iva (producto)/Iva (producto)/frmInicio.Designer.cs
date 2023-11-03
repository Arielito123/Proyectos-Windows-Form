namespace Iva__producto_
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblPrecioOriginal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtPrecioOriginal = new System.Windows.Forms.TextBox();
            this.txtR_iva = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMostrarPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecioO = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrecioOriginal
            // 
            this.lblPrecioOriginal.AutoSize = true;
            this.lblPrecioOriginal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrecioOriginal.Location = new System.Drawing.Point(53, 87);
            this.lblPrecioOriginal.Name = "lblPrecioOriginal";
            this.lblPrecioOriginal.Size = new System.Drawing.Size(114, 20);
            this.lblPrecioOriginal.TabIndex = 0;
            this.lblPrecioOriginal.Text = "Precio Original:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(53, 166);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(164, 20);
            this.lblIva.TabIndex = 1;
            this.lblIva.Text = "Ingresar Iva a calcular";
            // 
            // txtPrecioOriginal
            // 
            this.txtPrecioOriginal.Location = new System.Drawing.Point(240, 84);
            this.txtPrecioOriginal.Name = "txtPrecioOriginal";
            this.txtPrecioOriginal.Size = new System.Drawing.Size(178, 26);
            this.txtPrecioOriginal.TabIndex = 2;
            this.txtPrecioOriginal.TextChanged += new System.EventHandler(this.txtPrecioOriginal_TextChanged);
            // 
            // txtR_iva
            // 
            this.txtR_iva.Location = new System.Drawing.Point(240, 163);
            this.txtR_iva.Name = "txtR_iva";
            this.txtR_iva.Size = new System.Drawing.Size(178, 26);
            this.txtR_iva.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(178, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 20);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Aplicacion Para calcular el iva de un producto";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(195, 229);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(223, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Su resultado ya procesado es:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCalcular.Location = new System.Drawing.Point(462, 96);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(163, 41);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Iva";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMostrarPrecio
            // 
            this.txtMostrarPrecio.Location = new System.Drawing.Point(240, 305);
            this.txtMostrarPrecio.Name = "txtMostrarPrecio";
            this.txtMostrarPrecio.Size = new System.Drawing.Size(178, 26);
            this.txtMostrarPrecio.TabIndex = 7;
            // 
            // lblPrecioO
            // 
            this.lblPrecioO.AutoSize = true;
            this.lblPrecioO.Location = new System.Drawing.Point(53, 311);
            this.lblPrecioO.Name = "lblPrecioO";
            this.lblPrecioO.Size = new System.Drawing.Size(106, 20);
            this.lblPrecioO.TabIndex = 8;
            this.lblPrecioO.Text = "PrecioOriginal";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(53, 357);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(76, 20);
            this.lblImpuesto.TabIndex = 9;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(240, 354);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(178, 26);
            this.txtImpuesto.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(53, 406);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total A Pagar";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(240, 403);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 26);
            this.txtTotal.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.Location = new System.Drawing.Point(462, 305);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(163, 40);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 486);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lblPrecioO);
            this.Controls.Add(this.txtMostrarPrecio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtR_iva);
            this.Controls.Add(this.txtPrecioOriginal);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblPrecioOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioOriginal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtPrecioOriginal;
        private System.Windows.Forms.TextBox txtR_iva;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMostrarPrecio;
        private System.Windows.Forms.Label lblPrecioO;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNuevo;
    }
}

