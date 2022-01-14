using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucaciu_Vlad_FreeTime
{
    class Program
    {
        static void Main(string[] args)
            // Calculeaza timpul liber ramas intr-o zi normala
            // n este numarul de ore din zi
            // a este numarul de ore consumate cu tabieturi si nevoi (mancare, cafea, igiena etc)
            // b este numarul de ore petrecut spre activitati obligatorii ( munca, scoala, locuinta / timp total,
            // dus intors)
            // c este numarul de ore petrecut in activitatile obligatorii ( -||-)
            // d este numarul de ore petrecut in activitati de recreere sau sportive
            // e este numarul de ore petrecut in activitati de socializare ( familie, prieteni)
            // t este timpul ramas liber
            // Citeste de la tastatura informatiile si afiseaza rezultatul.

        {
            double n, a, b, c, d, e, t;
            Console.WriteLine("Introduceti numarul de ore din zi: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de ore dedicat tabieturilor si nevoilor personale: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de ore din trafic spre si dinspre activitatile obligatorii: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de ore petrecut la munca si facultate: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de ore petrecut in activitati de recreere si sportive: ");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de ore petrecut in activitati de socializare, familie si prieteni: ");
            e = double.Parse(Console.ReadLine());
            Console.WriteLine("Daca nu dormi niciodata timpul tau liber este: ");
            t = n - (a + b + c + d + e);

            // t = n-(a+b+c+d+e)
            Console.WriteLine("Timpul liber ramas este : {0}-({1}+{2}+{3}+{4}+{5}) = {6} ", n,a,b,c,d,e,t);

            Console.WriteLine("Daca timpul disponibil somnului este mai mic de 8h sugestia este de reorganizare a activitatilor in functie de importanta acestora");
            Console.ReadLine();

        }
        
    }
}
