using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iva__producto_
{
    class iva
    {
        private int precioOriginal;
        private int r_iva;

     

        public int PrecioOriginal 
        {
            get { return precioOriginal;}
            set { precioOriginal = value;}
        }

        public int  R_Iva
        {
            get { return r_iva; }
            set { r_iva = value; }
        }


        public int calcularPrecioIva(int PrecioIva) 
        {
            PrecioIva = PrecioOriginal * R_Iva/100;

            return PrecioIva;
        }

     


       


    }
}
