using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Controllers;
using WpfApp1.Entities;
using WpfApp1.Models;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStock_Click(object sender, RoutedEventArgs e)
        {
            Product product1 = new Product("Computer","csda2123asda",1000,20);
            Product product2 = new Product("Screen", "mgdaA23jhh234j234", 500, 20);
            Product product3 = new Product("Mouse", "m123nn123n12676546", 20, 20);
            Product product4 = new Product("Keyboard", "342167sd6786sda", 40, 20);
            StockInfoModel stockInfo = new StockInfoModel();
            stockInfo.products.Add(product1);
            stockInfo.products.Add(product2);
            stockInfo.products.Add(product3);
            stockInfo.products.Add(product4);
            new StockController(new StockInfoView(stockInfo)).ShowView();
        }


        private void BtnInvoice_Click(object sender, RoutedEventArgs e)
        {
            Invoice invoice1 = new Invoice(1321,10,1200,1200,0,"988AdsaDSAD923");
            Invoice invoice2 = new Invoice(1453, 20, 1150, 200, 950, "988AdsaDSAD923");
            Invoice invoice3 = new Invoice(2456, 10, 2300, 0, 2300, "988AdsaDSAD923");
            Invoice invoice4 = new Invoice(3000, 30, 2000, 1000, 1000, "988AdsaDSAD923");
            Invoice invoice5 = new Invoice(14000, 10, 13800, 13500, 300, "988AdsaDSAD923");
            InvoiceInfoModel invoiceInfo = new InvoiceInfoModel();
            invoiceInfo.invoices.Add(invoice1);
            invoiceInfo.invoices.Add(invoice2);
            invoiceInfo.invoices.Add(invoice3);
            invoiceInfo.invoices.Add(invoice4);
            invoiceInfo.invoices.Add(invoice5);
            new StockController(new InvoiceInfoView(invoiceInfo)).ShowView();
        }
    }
}
