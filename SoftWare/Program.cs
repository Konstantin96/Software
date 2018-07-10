using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soft.lib.Modul;

namespace SoftWare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            PO[] soft = new PO[]{new Free ("GitHub", "GitHub"),
                            new Shareware("Excel", "microsoft", "04.04.2018", (byte)rnd.Next(), rnd.Next(10,100)),
                            new Shareware("Notepad", "net", "30.07.2018", (byte)rnd.Next(), rnd.Next(10,100)),
                            new Commercial("Diablo 3", "BLIZZARD", "05.08.2018", (byte)rnd.Next(100), rnd.Next(100,200), rnd.Next(100)),
                            new Free("Paint", "Microsoft")};

            Console.WriteLine("~~~~ Весь список ПО:");
            foreach (PO p in soft)
                p.Info();

            Console.WriteLine("~~~~ Список ПО, которое можно использовать на сегодняшний день: ");
            foreach (PO p in soft)
                if (p.ItIsAWorks()) Console.WriteLine(p.ProgramName);

        }
    }
}
