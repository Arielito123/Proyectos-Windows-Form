using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploPersona
{
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblApellido_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona opersona1 = new Persona();
            opersona1.Nombre = TxtNombre.Text;
            opersona1.Apellido = TxtApellido.Text;
            opersona1.Dni =Convert.ToInt32((TxtDni.Text));

            MessageBox.Show(" opersona1 tiene cargado Nombre: "+opersona1.Nombre+" apellido "+opersona1.Apellido+" dni "+opersona1.Dni);

        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
