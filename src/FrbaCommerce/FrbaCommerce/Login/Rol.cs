using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Login
{
    public class Rol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Funciones { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
