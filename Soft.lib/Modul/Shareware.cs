using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft.lib.Modul
{
    public class Shareware : PO
    {
        public Shareware(string name, string company, string date, byte demo_period, int cost)
            : base(name, company, date, demo_period, cost)
        { }

        public override void Info()
        {
            Console.WriteLine("Имя продукта: " + name + "\nПроизводитель: "
                                 + company + "\nДата установки ПО: " + dateOfInstall.ToShortDateString()
                                 + "\nПериод бесплатного использования: " + demo_preiod
                                 + "\nCтоимость продукта: " + cost + " $\n");
        }
        public override bool ItIsAWorks()
        {
            if (dateOfInstall.AddDays(demo_preiod) >= DateTime.Now)
                return true;
            return false;
        }
    }
}
