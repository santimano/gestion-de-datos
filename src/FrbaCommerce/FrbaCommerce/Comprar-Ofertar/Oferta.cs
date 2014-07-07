using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Comprar_Ofertar
{
    class Oferta
    {
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Oferta(decimal Monto, DateTime Fecha)
        {
            this.Fecha = Fecha;
            this.Monto = Monto;
        }

        public override string ToString()
        {
            return Monto + " " + Fecha;
        }

    }
}
