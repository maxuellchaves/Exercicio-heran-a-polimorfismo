using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_herança_e_polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee):base(name,price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag(string pricetag)
        {
            return base.PriceTag(pricetag);
        }

        public double TotalPrice()
        {
            return Price * CustomsFee;
        }

        public override string ToString()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + 
                " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)+")";
        }

    }
}
