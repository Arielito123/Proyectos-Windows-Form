using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTi
{
    public partial class Form1 : Form
    {
        List<Button> listaBotones = new List<Button>();//instanciamos una lista de botones
        int Turno = 0,Movimientos=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ta Te Ti " + DateTime.Now.ToShortDateString();
            CrearBotones();
            ActualizarLabelTurno();
        }

        //funcion para crear botones en automatico
        void CrearBotones() 
        {
            int left=50, top=50;

            //ciclo de repeticion para poder crear los botones
            for (int index = 0; index < 9; index++) 
            {
                var boton = new Button();//var boton  intanciamos boton
                //usamos propiedad width y heigth para darle forma al boton
                boton.Width = 80;
                boton.Height = 80;
                //propieda font para cambiarle la fuente y el tamaño
                boton.Font = new Font(new FontFamily("Verdana"),18);
                
                //darle visibilidad
                boton.Visible = true;

                //asignando el left y el top al boton
                boton.Left = left;
                boton.Top = top;

                boton.Click += OnClickBoton;//llamar al evento onclick boton
                
                //sumando el left cada ves que corre el for
                left += 150;

                //si el index es 2 o 5 se reinicia el lef y el top
                if(index==2||index==5)
                {
                    top += 150;
                    left = 50;
                }

                //agregamos el boton a la lista y el control tambien
                listaBotones.Add(boton);
                this.Controls.Add(boton);

            }
    
           

        }

        void OnClickBoton(object sender,EventArgs eventArgs)
        {
            Button boton = (Button)sender;//enviar señal del boton seleccionado

            //si el string es nulo o vacio entonces puedo clickearle con una x
            if (string.IsNullOrEmpty(boton.Text)&&!ChequeaGanador()) 
            {
                //condicional ternario
                boton.Text = Turno == 0 ? "X" : "O";

                if (ChequeaGanador())
                {
                    DialogResult result = MessageBox.Show("Gano el jugador " + (Turno + 1) + "¿Deseas volver a jugar?","pregunta",MessageBoxButtons.YesNo);
                  
                    if (result == DialogResult.Yes) 
                    {
                        ReiniciarJuego();
                    }

                }
                else 
                {
                    if (Movimientos < 8)
                    {
                        Turno = Turno == 0 ? 1 : 0;
                        ActualizarLabelTurno();
                        Movimientos++;
                        lblMovimientos.Text = "Movimientos"+Movimientos;
                    }
                    else 
                    {
                        DialogResult empate = MessageBox.Show("Hubo Un Empate "+ "¿Deseas volver a jugar?", "Empate", MessageBoxButtons.YesNo);
                        if (empate == DialogResult.Yes)
                        {
                            ReiniciarJuego();
                        }
                    }
                    

                }

             
            }
             

        }

        void ActualizarLabelTurno() 
        {
            lblTurno.Text = "Turno: Jugador" +" "+ (Turno + 1);
        }

        bool ChequeaGanador() 
        {
            if((!string.IsNullOrEmpty(listaBotones[0].Text)&& listaBotones[0].Text == listaBotones[1].Text && listaBotones[1].Text == listaBotones[2].Text)||
               (!string.IsNullOrEmpty(listaBotones[3].Text)&& listaBotones[3].Text == listaBotones[4].Text && listaBotones[4].Text == listaBotones[5].Text)||
               (!string.IsNullOrEmpty(listaBotones[6].Text)&& listaBotones[6].Text == listaBotones[7].Text && listaBotones[7].Text == listaBotones[8].Text)||
              (!string.IsNullOrEmpty(listaBotones[0].Text)&& listaBotones[0].Text == listaBotones[3].Text && listaBotones[3].Text == listaBotones[6].Text )||
               (!string.IsNullOrEmpty(listaBotones[1].Text) && listaBotones[1].Text == listaBotones[4].Text && listaBotones[4].Text == listaBotones[7].Text)||
              (!string.IsNullOrEmpty(listaBotones[2].Text) && listaBotones[2].Text == listaBotones[5].Text && listaBotones[5].Text == listaBotones[8].Text) ||
               (!string.IsNullOrEmpty(listaBotones[0].Text) && listaBotones[0].Text == listaBotones[4].Text && listaBotones[4].Text == listaBotones[8].Text)||
              (!string.IsNullOrEmpty(listaBotones[2].Text)&& listaBotones[2].Text == listaBotones[4].Text && listaBotones[4].Text == listaBotones[6].Text)) 
            {

                return true;
              
               
            }
            return false;
        }

        private void ReiniciarJuego() 
        {
            Turno = 0;
            Movimientos = 0;
            lblMovimientos.Text = "Movimientos" + " "+ Movimientos;

            for (int index = 0; index < 9; index++) 
            {
                listaBotones[index].Text = " ";
            }

            Turno = 0;
            ActualizarLabelTurno();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
