using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gamerek2
{ 
    class gamer
    {
        public string nev;
        public string jelszo;
        public string email;
        public int pontszam;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<gamer> jatekoslista = new List<gamer>();
            

            // gamer létrehozása

            gamer g = new gamer();
            gamer g1 = new gamer();
            gamer g2 = new gamer();
            gamer g3 = new gamer();

            g.nev = "Pisti";
            g.jelszo = "qwert";
            g.email = "hgfg@jhgf.hu";
            g.pontszam = 57;

            g1.nev = "Eszter";
            g1.jelszo = "esztike";
            g1.email = "esztike@gmail.hu";
            g1.pontszam = 87;

            g2.nev = "Gyula";
            g2.jelszo = "gyuszko";
            g2.email = "gyuszko@gmail.com";
            g2.pontszam = 97;

            g3.nev = "Fémember";
            g3.jelszo = "metalman";
            g3.email = "metalman@freemail.hu";
            g3.pontszam = 77;

            jatekoslista.Add(g);
            jatekoslista.Add(g1);
            jatekoslista.Add(g2);
            jatekoslista.Add(g3);

            /*for (int i = 0; i < jatekoslista.Count; i++)
            {
                Console.WriteLine(jatekoslista[i].nev + " " + jatekoslista[i].pontszam);
            }*/

            foreach (var item in jatekoslista)
            {
                Console.WriteLine(item.nev + " " + item.pontszam+ " pontja van.");

            }

            Console.ReadLine();
        }
    }
}
