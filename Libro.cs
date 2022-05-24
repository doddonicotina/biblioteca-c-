using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_classi
{
    class Libro
    {
        private string titolo;
        private string autore;
        private int anno;
        private int pagina ;
        private string Genere;
        public Libro()
        {
            titolo = "none";
            Genere = "none";
            autore = "none";
            anno = 0000;
            pagina = 000;

        }
        public Libro(string t, string a, int an, int pa, string g)
        {
            titolo = t;
            autore = a;
            anno = an;
            pagina = pa;
            Genere = g;
        }

        public string Description()
        {
            string msg;
            msg = $"L'autore del libro {titolo}" + $" è {autore} " + $"scritto nell'anno {anno} " + $"di genere: {Genere} " + $"e n pagine {pagina}";
            return msg;
            return msg;
        }

        public int lettofinoapag()
        {
            int pag;
            pag = 0;
            return pag;
        }

    }
}
