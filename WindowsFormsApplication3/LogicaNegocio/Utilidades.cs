using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FlyMail
{
    class Utilidades
    {
        /// <summary>
        /// Toma una cadena y le aplica una función de hashing para almacenarla posteriormente en la base de datos.
        /// </summary>
        /// <param name="passOriginal">Contraseña a encriptar. Se recomienda utilizar combinación user+pass</param>
        /// <returns></returns>
        public static string Encriptar(string passOriginal)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(passOriginal);
            byte[] hash = sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }
    }
}
