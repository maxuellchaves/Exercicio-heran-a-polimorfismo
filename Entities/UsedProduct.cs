using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_herança_e_polimorfismo.Entities
{
    class UsedProduct:Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate):base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag(string pricetag)
        {
            return base.PriceTag(pricetag);
        }

        public override string ToString()
        {
            return Name + " (used) $" + Price.ToString("F2", CultureInfo.InvariantCulture) + 
                " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
