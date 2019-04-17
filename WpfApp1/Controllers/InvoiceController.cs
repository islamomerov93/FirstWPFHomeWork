using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Views;

namespace WpfApp1.Controllers
{
    class InvoiceController
    {
        IView view;

        public InvoiceController(IView view)
        {
            this.view = view;
        }

        public void ShowView()
        {
            view.ShaowView();
        }
    }
}
