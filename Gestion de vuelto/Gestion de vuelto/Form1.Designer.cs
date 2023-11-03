namespace Gestion_de_vuelto
{
    partial class Form1
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
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblGestorVuelto = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(62, 92);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblGestorVuelto
            // 
            this.lblGestorVuelto.AutoSize = true;
            this.lblGestorVuelto.Location = new System.Drawing.Point(29, 9);
            this.lblGestorVuelto.Name = "lblGestorVuelto";
            this.lblGestorVuelto.Size = new System.Drawing.Size(273, 20);
            this.lblGestorVuelto.TabIndex = 1;
            this.lblGestorVuelto.Text = "Gestor de vuelto,para facilitar la tarea";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(62, 160);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(50, 20);
            this.lblPago.TabIndex = 2;
            this.lblPago.Text = "Pago:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(125, 86);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(82, 26);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(125, 157);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(82, 26);
            this.txtPago.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(33, 226);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(269, 41);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Vuelto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 296);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblGestorVuelto);
            this.Controls.Add(this.lblPrecio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestion de vuelto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblGestorVuelto;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Button btnCalcular;
    }
}

