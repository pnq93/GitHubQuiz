using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class baza
    {
        private static bazaDanychQuizDataContext db = new bazaDanychQuizDataContext();
        private baza()
        {
        }
        public static bazaDanychQuizDataContext Polaczenie
        {
            get { return db; }
        }
    }
}
