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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrearPersona_Click(object sender, EventArgs e)
        {
            Empleado Oempleado= new Empleado();
            Oempleado.Nombre = TxtNombre.Text;
            Oempleado.Apellido = TxtApellido.Text;
            Oempleado.Dni = Convert.ToInt32(TxtDni.Text);
            Oempleado.Legajo =Convert.ToInt32(TxtLegajo.Text);
            Oempleado.Horas_trabajadas = Convert.ToInt32(TxtHora_trabajada.Text);
            Oempleado.Valor_hora = Convert.ToDecimal(TxtValor_horas.Text);
            Oempleado.Fecha_de_ingreso = Convert.ToDateTime(dtpFecha_ingreso.Text);

             decimal resultado = Oempleado.sueldo();

             MessageBox.Show("sueldo es :" + resultado+" pesos argentino ");




        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPersona2_Click(object sender, EventArgs e)
        {
            Empleado Oempleado_parametrizado = new Empleado(TxtNombre.Text, TxtApellido.Text, Convert.ToInt32(TxtDni.Text), Convert.ToInt32(TxtLegajo.Text), Convert.ToInt32(TxtHora_trabajada.Text), Convert.ToDecimal(TxtValor_horas.Text), Convert.ToDateTime(dtpFecha_ingreso.Text));
            decimal resultado = Oempleado_parametrizado.sueldo();

            MessageBox.Show("su sueldo en pesos argentinos es : " + resultado);

        }
    }
}
