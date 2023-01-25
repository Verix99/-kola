using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKLADNA_2._0
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte cenu nákupu: ");
            string cena01 = Console.ReadLine() ;
            int cena = Int32.Parse(cena01);

            Console.WriteLine("Zadejte hodnotu bankovky: ");
            string bankovka01 = Console.ReadLine();
            int bankovka = Int32.Parse(bankovka01);

            int vraceni = bankovka - cena;
            Console.WriteLine("Vrátí se vám: ");

            int padesatky = vraceni / 50; ;
            Console.WriteLine(padesatky + "  padesátikorun");
            int dvacky = ((vraceni - (padesatky * 50)) / 20);
            Console.WriteLine(dvacky + "  dvacek");
            int desitky = (vraceni - ((padesatky * 50) + (dvacky * 20)))/10;
            Console.WriteLine(desitky + "  desetikorun");
            int petky = (vraceni - ((padesatky * 50) + (dvacky * 20) + (desitky*10))) / 5;
            Console.WriteLine(petky + "  pětikorun");
            int dvojky = (vraceni - ((padesatky * 50) + (dvacky * 20) + (desitky * 10) + (petky * 5))) / 2;
            Console.WriteLine(dvojky + "  dvojkorun");
            int jednicky = (vraceni - ((padesatky * 50) + (dvacky * 20) + (desitky * 10) + (petky * 5) + (dvojky *2))) / 1;
            Console.WriteLine(jednicky + "  jednikorun");
            int celek = padesatky + dvacky + desitky + petky + dvacky + jednicky;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vrátí se vám celkem: " + celek + "  mincí");
           









            Console.ReadKey();

        }
    }
}
