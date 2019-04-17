using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Invoice
    {
        public Invoice()
        {

        }

        public Invoice(int price, int discount, int lastPrice, int cashPayment, int cardPayment, string checkBarcode)
        {
            Price = price;
            Discount = discount;
            LastPrice = lastPrice;
            CashPayment = cashPayment;
            CardPayment = cardPayment;
            CheckBarcode = checkBarcode;
        }

        public int Price { get; set; }
        public int Discount { get; set; }
        public int LastPrice { get; set; }
        public int CashPayment { get; set; }
        public int CardPayment { get; set; }
        public string CheckBarcode { get; set; }
    }
}
