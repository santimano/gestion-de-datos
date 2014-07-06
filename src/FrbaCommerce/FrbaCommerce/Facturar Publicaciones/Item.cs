using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Facturar_Publicaciones
{
    class Item
    {
        public string Publicacion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Vendidos { get; set; }
        public decimal Unitario { get; set; }
        public decimal Total { get; set; }
        public decimal PubCodigo { get; set; }
        public decimal Visibilidad { get; set; }

        public Item(string Publicacion, DateTime Fecha, decimal Vendidos, decimal Unitario, decimal Total, decimal PubCodigo, decimal Visibilidad)
        {
            this.Publicacion = Publicacion;
            this.Fecha = Fecha;
            this.Vendidos = Vendidos;
            this.Unitario = Unitario;
            this.Total = Total;
            this.PubCodigo = PubCodigo;
            this.Visibilidad = Visibilidad;
        }
    }
}
