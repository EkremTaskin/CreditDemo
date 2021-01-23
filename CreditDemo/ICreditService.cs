using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditDemo
{
    public interface ICreditService
    {
        void Hesapla(double credit , ListBox listbox);
    }
}
