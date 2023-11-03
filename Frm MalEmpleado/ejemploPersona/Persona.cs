using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploPersona
{
    class Persona
    {
        /*
          las clases tienen :
         --campos: son las variabes privadas que tienen la base de datos
          --propiedades
          --constructores
         * ---metodos publicos 
         * metodos privados
          */
        #region Campos privados
        // no se puede ver desde afuera(encapsular)
        private string nombre;
        private string apellido;
        private long dni;

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }           //me va a retornar la lectura de lo que contiene,lectura del contenido
            set { this.nombre = value; }           //value trae
        }

        #endregion
        //constructores. si no tengo ningun constructor no hace falta que lo programe. se crea por defecto
        public Persona()
        { }
        public Persona(string nombre, String apellido, long dni)
        {
            this.Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

    }
}
