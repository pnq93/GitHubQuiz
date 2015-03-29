using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Quiz
{
    class Haszowanie
    {
        public string SzyfrujMD5(string input) //szfrowanie MD5
        {
            MD5 hash = MD5.Create(); //Tworzy wystąpienie domyślne stosowania MD5 algorytm wyznaczania wartości skrótu.
            byte[] inputbytes = Encoding.ASCII.GetBytes(input);
            byte[] hasbytes = hash.ComputeHash(inputbytes);
            StringBuilder strBuild = new StringBuilder();
            for (int i = 0; i < hasbytes.Length; i++)
            {
                strBuild.Append(hasbytes[i].ToString("X2"));
            }
            return strBuild.ToString();
        }
    }
}
