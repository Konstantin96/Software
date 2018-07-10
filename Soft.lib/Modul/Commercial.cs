using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft.lib.Modul
{
    public class Commercial : PO
    {
        int period;
        public Commercial(string name, string company, string date, byte demo_period, int cost, int period)
            : base(name, company, date, 0, cost)
        { this.period = period; }

        public override void Info()
        {
            Console.WriteLine("Имя продукта: " + name + "\nПроизводитель: "
                                 + company + "\nДата установки ПО: " + dateOfInstall.ToShortDateString()
                                 + "\nСтоимость продукта: " + cost + " $ \nПериод использования: " + period + "\n");
        }
        public override bool ItIsAWorks()
        {
            if (dateOfInstall.AddDays(period) >= DateTime.Now) return true;
            return false;
        }
    }
}
