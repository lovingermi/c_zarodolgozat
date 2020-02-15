using CryptSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.Services
{
    public static class Hash
    {
        public static string Encrypt(string input)
        {
            var sha256 = SHA256.Create();
            // char[] = string
            // bájt tömbbé alakítjuk a stringet
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            // Itt megtörténik a kódolás
            var hash = sha256.ComputeHash(inputBytes);

            // Egy string készítése
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                // hozzáfűzze a stringhez
                // X2-vel nem számok lesznek, hanem betűk
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

    }
}