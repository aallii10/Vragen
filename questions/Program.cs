using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Vragen> vraagArray = new List<Vragen>(){

                new Vragen() {Vraag = "sadsasa", Antwoord = "", MoeilijkheidsGraad = "1", Categorie = ""},
                new Vragen() {Vraag = "sadfdvcx", Antwoord = "", MoeilijkheidsGraad = "2", Categorie = ""},
                new Vragen() {Vraag = "3243", Antwoord = "", MoeilijkheidsGraad = "3", Categorie = ""},
                new Vragen() {Vraag = "yhytjthg", Antwoord = "", MoeilijkheidsGraad = "1", Categorie = ""},
                new Vragen() {Vraag = "adqwsad", Antwoord = "", MoeilijkheidsGraad = "2", Categorie = ""}
            };


            //Vragen vragens = vraagArray.Where(v => v.MoeilijkheidsGraad == "2").FirstOrDefault();

         

           /* foreach(var v in result)
            {
                Console.WriteLine(v.Vraag);
            }*/


            

            //Console.WriteLine("Kies een moeilijkheidsgraad: 1, 2, 3");

            string read = Console.ReadLine();

            if(read.Equals("1"))
            {
                var result = from v in vraagArray
                             where v.MoeilijkheidsGraad.Equals("1")
                             select v;

                Console.WriteLine(result.v.Vraag);
            }

            else if (read.Equals("2"))
            {
                Console.WriteLine("");
            }

            else if (read.Equals("3"))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("deze moeilijkheidsgraad bestaat niet.");
            }


        }
    }
}
