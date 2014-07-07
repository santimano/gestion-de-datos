using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Comprar_Ofertar
{
    class Vendedor
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }

        public Vendedor(string Nombre, string Telefono, string Mail)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Mail = Mail;
        }


    }
}
