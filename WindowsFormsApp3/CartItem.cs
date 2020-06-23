using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class CartItem
    {
        public string NAME { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return NAME + "/" + price + "₺";
        }
        public CartItem(string n, int p)
        {
            NAME = n;
            price = p;


        }
    }
}
