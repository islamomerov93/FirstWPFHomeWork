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
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for InvoiceInfoView.xaml
    /// </summary>
    public partial class InvoiceInfoView : Window, IView
    {
        InvoiceInfoModel invoiceInfoModel;

        public InvoiceInfoView(InvoiceInfoModel invoiceInfo)
        {
            InitializeComponent();
            invoiceInfoModel = invoiceInfo;
            dtgrdInvoiceInfo.ItemsSource = invoiceInfoModel.invoices;
        }

        public void ShaowView()
        {
            Show();
        }
    }
}
