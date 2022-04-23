using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Studenti
    {
        /*Guid merr id ose nga serveri ose nga 
        pjesa e klientit varesisht si perdoret
       */
       public Guid Id { get; set; }
       public string Emaili { get; set; }

       public int NrLetenjoftimit { get; set; }

       public string Emri { get; set; }
 
        public string EmriPrindit { get; set; }

        public String Mbiemri { get; set; }

        public string Gjinia { get; set; }

        public DateTime Ditelindja { get; set; }

        public string Vendlindja { get; set; }

    }
}