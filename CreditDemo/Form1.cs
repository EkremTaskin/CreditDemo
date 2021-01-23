using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditDemo
{
    public partial class Form1 : Form
    {
        private int _credit;
        List<ICreditService> creditManagers;
        public Form1()
        {
            InitializeComponent();
            creditManagers = new List<ICreditService>();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cbxKonut.Checked)
                creditManagers.Add(new KonutCreditManager());
            if (cbxTasit.Checked)
                creditManagers.Add(new TasitCreditManager());
            if (cbxihtiyac.Checked)
                creditManagers.Add(new IhtiyaçCreditManager());

            lbxKrediler.Items.Clear();
            foreach (var creditManager in creditManagers)
            {
                creditManager.Hesapla((double)_credit , lbxKrediler);
            }
            creditManagers.Clear();
        }

        private void tbxKredi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _credit = Convert.ToInt32(tbxKredi.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("int değer harici yazamazsın !");
                tbxKredi.Text = "";
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
