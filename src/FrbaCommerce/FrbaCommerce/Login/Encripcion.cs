using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace FrbaCommerce.Login
{
    class Encripcion
    {
        public static string CalcularHash(string texto)
        {
            Byte[] hash = SHA256CryptoServiceProvider.Create().ComputeHash(Encoding.ASCII.GetBytes(texto));
            StringBuilder cadena = new StringBuilder();
            foreach (byte b in hash)
            {
                cadena.AppendFormat("{0:x2}", b);
            }
            return cadena.ToString();
        }
    }
}
