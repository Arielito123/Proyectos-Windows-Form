using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_vuelto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Gestion de vuelto" +" "+ DateTime.Now.ToShortDateString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           //un mensaje evento pára cuando se cierre la aplicacion
            DialogResult resp = MessageBox.Show("¿deseas salir?","salir",MessageBoxButtons.YesNo);

            if (resp == DialogResult.No) 
            {
                e.Cancel = true;
            }
           
            
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
          


        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int vuelto = 0;
            Vuelto Ovuelto = new Vuelto();

            Ovuelto.Precio = Convert.ToInt32(txtPrecio.Text);
            Ovuelto.Pago = Convert.ToInt32(txtPago.Text);

            int total = Ovuelto.DarVuelto(vuelto);

            MessageBox.Show("El vuelto que debes dar es de:" + " " + total + " Pesos ");

        }
    }
}
