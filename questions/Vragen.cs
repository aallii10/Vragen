using System;
using System.Collections.Generic;
using System.Text;

namespace questions
{
    class Vragen
    {
        
        
        public Vragen()
        {
            Vraag = "";
            Antwoord = "";
        }


        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public string MoeilijkheidsGraad { get; set; }
        public string Categorie { get; set; }

        public bool CheckAntwoord(String Reactie)
        {
            return Reactie.Equals(Antwoord);
        }

        public virtual void GedragAntwoord(bool Check)
        {
            if (Check == true)
            {
                Console.WriteLine("Antwoord klopt");
            }
            else
            {
                Console.WriteLine("Probeer het opnieuw.");
                string v = Console.ReadLine();
                GedragAntwoord(CheckAntwoord(v));
            }

        }


        public void Display()
        {
            Console.WriteLine(Vraag);
        }


    }
}
