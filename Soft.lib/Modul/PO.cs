using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft.lib.Modul
{
    public abstract class PO
    {
        protected string name;
        protected string company;
        protected DateTime dateOfInstall;
        protected byte demo_preiod;
        protected int cost;

        public PO(string name, string company, string date, byte demo_period, int cost)
        {
            this.name = name;
            this.company = company;
            this.dateOfInstall = DateTime.Parse(date);
            this.demo_preiod = demo_period;
            this.cost = cost;
        }
        public virtual void Info()
        {
            Console.WriteLine("\nИмя продукта: " + name + " Производитель: "
                                 + company + " дата установки ПО: " + dateOfInstall
                                 + "Период бесплатного использования: " + demo_preiod
                                 + " стоимость продукта: " + cost + " \n");
        }
        public virtual bool ItIsAWorks()
        {
            if (dateOfInstall.AddDays(demo_preiod) >= DateTime.Now) return true;
            return false;
        }
        public string ProgramName
        {
            get { return name; }
        }
    }
}
