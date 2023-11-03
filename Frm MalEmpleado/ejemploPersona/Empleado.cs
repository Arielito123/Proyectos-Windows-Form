using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPersona
{
    class Empleado : Persona
    {
        #region atributos privados
        Int32 legajo;
        Int32 horas_trabajadas;
        Decimal valor_hora;
        DateTime fecha_de_ingreso;
        #endregion

        #region encapsulamiento
        public Int32 Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }


        public Int32 Horas_trabajadas
        {
            get { return horas_trabajadas; }
            set { horas_trabajadas = value; }
        }


        public Decimal Valor_hora
        {
            get { return valor_hora; }
            set { valor_hora = value; }
        }

        public DateTime Fecha_de_ingreso
        {
            get { return fecha_de_ingreso; }
            set { fecha_de_ingreso = value; }
        }

        #endregion

        public Empleado() 
        { 
        }

        public Empleado(string nombre, string apellido, int dni, Int32 legajo, Int32 horas_trabajadas, decimal valor_hora, DateTime fecha_de_ingreso) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Legajo = legajo;
            this.Horas_trabajadas = horas_trabajadas;
            this.Valor_hora = valor_hora;
            this.Fecha_de_ingreso = fecha_de_ingreso;

            decimal resultado = sueldo();

        }


        public decimal sueldo() 
        {
            return Horas_trabajadas * Valor_hora;
        }
       


    }
}
