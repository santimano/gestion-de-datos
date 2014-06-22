using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.ABM_Rol
{
    public class Rol
    {
        private string descripcion;
        private string estado;

        public Rol(string descripcion, string estado) 
        {
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

    }
}
