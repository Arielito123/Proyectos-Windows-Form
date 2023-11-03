using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_vuelto
{
    class Vuelto
    {
        #region Campos Privados
        private int precio;
        private int pago;
        #endregion


        #region Atributos Publicos
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Pago
        {
            get { return pago; }
            set { pago = value; }
        }

        #endregion


        #region Constructor vacio
        public Vuelto() { }

        #endregion


        #region Metodo/Accion Dar Vuelto
        public int DarVuelto(int total) 
        {
            total =  Pago-Precio;
            return total;
        }
        #endregion
    }
}
