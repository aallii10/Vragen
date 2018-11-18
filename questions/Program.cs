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

                new Vragen() {Vraag = "1 + 1", Antwoord = "2", MoeilijkheidsGraad = "1", Categorie = "rekenen"},
                new Vragen() {Vraag = "welke kleur heeft een dolfijn", Antwoord = "blauw", MoeilijkheidsGraad = "1", Categorie = "kleuren"},
                new Vragen() {Vraag = "3 + 2", Antwoord = "5", MoeilijkheidsGraad = "3", Categorie = "rekenen"},
                new Vragen() {Vraag = "8 + 1", Antwoord = "9", MoeilijkheidsGraad = "1", Categorie = "rekenen"},
                new Vragen() {Vraag = "welke kleur heeft een schildpad", Antwoord = "groen", MoeilijkheidsGraad = "2", Categorie = "kleuren"}
            };

                
            

            //Vragen vragens = vraagArray.Where(v => v.MoeilijkheidsGraad == "2").FirstOrDefault();


            var result = from v in vraagArray
                         where v.MoeilijkheidsGraad.Equals("1")
                         select v;
        
            
            

            Console.WriteLine("kies een Categorie: rekenen(1) of kleuren(2)");
            string categorieKeuze = Console.ReadLine();
            

            if (categorieKeuze.Equals("1") || categorieKeuze.Equals("2"))
            {
                var gefilterdeVragenCategorie = from v in vraagArray where v.Categorie.Equals(categorieKeuze) select v;

                Console.WriteLine("Kies een moeilijkheidsgraad: 1, 2, 3");
                string mgKeuze = Console.ReadLine();

                if (mgKeuze.Equals("1") || mgKeuze.Equals("2") || mgKeuze.Equals("3"))
                {
                    var gefilterdeVragenMoeilijkheidsGraad = from v in vraagArray where v.MoeilijkheidsGraad.Equals(mgKeuze) select v;

                     foreach(var v in gefilterdeVragenMoeilijkheidsGraad)
                     {
                        v.Display();
                        string input = Console.ReadLine();
                        bool x = v.CheckAntwoord(input);
                        v.GedragAntwoord(x);

                    }
                }

                else
                {
                    Console.WriteLine("deze moeilijkheidsgraad bestaat niet.");
                }
            }


        }
    }
}
