using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iva__producto_
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿deseas salir?", "salir", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No) 
            {
                e.Cancel = true;
            }

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.Text = " sacar iva " + DateTime.Now.ToShortDateString()+" "+DateTime.Now.ToShortTimeString();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void txtPrecioOriginal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            iva oiva = new iva();
            int recibiriva=0;
            oiva.PrecioOriginal = Convert.ToInt32(txtPrecioOriginal.Text);
            oiva.R_Iva = Convert.ToInt32(txtR_iva.Text);

            int precio_iva = oiva.calcularPrecioIva(recibiriva);

            txtMostrarPrecio.Text = Convert.ToString(oiva.PrecioOriginal);
            txtImpuesto.Text = Convert.ToString(precio_iva);

            int total = precio_iva + oiva.PrecioOriginal;

            txtTotal.Text = Convert.ToString(total);



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPrecioOriginal.Clear();
            txtR_iva.Clear();
            txtImpuesto.Clear();
            txtMostrarPrecio.Clear();
            txtTotal.Clear();
        }
    }
}
