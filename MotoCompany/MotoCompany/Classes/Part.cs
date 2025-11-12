using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoCompany.Classes
{
    public class Part
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price}₺ - {Amount} adet";
        }
    }
}
