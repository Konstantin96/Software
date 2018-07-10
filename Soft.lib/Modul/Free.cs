using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft.lib.Modul
{
   public class Free : PO
    {
        public Free(string name, string company) : base(name, company, "01.01.2000", 0, 0)
        { }

        public override void Info()
        {
            Console.WriteLine("Имя продукта: " + name + "\nПроизводитель: "
                                 + company + "\n");
        }
        public override bool ItIsAWorks()
        {
            return true;
        }
    }
}
