using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        namespace focicsapat
        { 
        class Program
        {
            struct foci
            {
                public string csap_nev;
                public int nyert;
                public int dontetlen;
                public int osszpont;
            }
            static void Main(string[] args)
            {
                Console.Write("Add meg a csapatok számát : ");
                int n = Convert.ToInt32(Console.ReadLine());
                foci[] csapat = new foci[n];
                Console.WriteLine("Kérem a csapatok adatait!");
                for (int i = 0; i < csapat.Length; i++)
                {
                    Console.Write("Csapat neve : ");
                    csapat[i].csap_nev = Console.ReadLine();
                    Console.Write(" A nyert mecsek száma: ");
                    csapat[i].nyert = Convert.ToInt32(Console.ReadLine());
                    Console.Write("A döntetlen mecsek száma : ");
                    csapat[i].dontetlen = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("____________________________________");
                    csapat[i].osszpont = 3 * csapat[i].nyert + csapat[i].dontetlen;

                }
                Console.WriteLine("A csapatok pontszámai : ");
                for (int i = 0; i < csapat.Length; i++)
                {
                    Console.WriteLine("A csapat neve {0}, enyiszer győztek {1} a bajnokságban elért pontszám {2}", csapat[i].csap_nev, csapat[i].nyert, csapat[i].osszpont);
                }
        Console.ReadLine();



            }
        }
    }


