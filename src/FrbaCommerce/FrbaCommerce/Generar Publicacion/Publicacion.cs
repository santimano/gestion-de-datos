using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Generar_Publicacion
{
    class Publicacion
    {
        public string Descripcion { get; set; }
        public decimal Stock { get; set; }
        public DateTime FechaVenc { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public List<string> Rubros { get; set; }
        public string Visibilidad { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
    }
}
