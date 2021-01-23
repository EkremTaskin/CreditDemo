using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditDemo
{
    class IhtiyaçCreditManager : ICreditService
    {
        public void Hesapla(double credit, ListBox listbox)
        {
            listbox.Items.Add("İhtiyaç kredisi tutarı : " + credit);
        }
    }
}
