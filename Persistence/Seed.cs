using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
         public static async Task SeedData(DataContext context)
        {
            /*Shikon nese kemi ndonje aktivitet mbrenda Studentit
            nese po i kthen ato.
            */
            if (context.Studentet.Any()) return;
            
            var studentet = new List<Studenti>
            {
                new Studenti
                {
                    Emaili = "arlindfeta433@gmail.com",
                    NrLetenjoftimit = 10256948,
                    Emri = "Arlind",
                    EmriPrindit = "Azem",
                    Mbiemri = "Feta",
                    Gjinia = "Mashkull",
                    Ditelindja = new DateTime(2002,02,11),
                    Vendlindja = "Podujeve"
                },
                new Studenti
                {
                    Emaili = "arlindfeta433@gmail.com",
                    NrLetenjoftimit = 10256948,
                    Emri = "Arlind",
                    EmriPrindit = "Azem",
                    Mbiemri = "Feta",
                    Gjinia = "Mashkull",
                    Ditelindja = new DateTime(2002,02,11),
                    Vendlindja = "Podujeve"
                },
                new Studenti
                {
                    Emaili = "arlindfeta433@gmail.com",
                    NrLetenjoftimit = 10256948,
                    Emri = "Arlind",
                    EmriPrindit = "Azem",
                    Mbiemri = "Feta",
                    Gjinia = "Mashkull",
                    Ditelindja = new DateTime(2002,02,11),
                    Vendlindja = "Podujeve"
                },
               
            };
            /*
            Vendos te dhenat qe i marrim nga te dhenat 
            qe jane vendosur ne variablen studentet
            ne metoden AddRangeAsync (Nuk i ruan ato)
            */
            await context.Studentet.AddRangeAsync(studentet);
            //ruan te dhenat e variables
            await context.SaveChangesAsync();
    }
}} 