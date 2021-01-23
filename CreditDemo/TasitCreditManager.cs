using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditDemo
{
    class TasitCreditManager : ICreditService
    {
        public void Hesapla(double credit , ListBox listbox)
        {
            listbox.Items.Add("Taksit kredisi Tutarı: " + credit / 4);
        }

    }
}
