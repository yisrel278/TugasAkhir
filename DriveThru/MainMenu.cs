using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PemesananKopi
{
    public partial class MainMenu : Form
    {
        protected int count1 = 0, count2 = 0, count3 = 0;
        public void result()
        {
            textBox1.Text = "Americano\t: " + count1 + "\nEspresso\t\t: " + count2 + "\nCappuccino\t: " + count3 + "\n";
        }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void americano_Click(object sender, EventArgs e)
        {
            count1 = count1 + 1;
            result();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void espresso_Click(object sender, EventArgs e)
        {
            count2 = count2 + 1;
            result();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int hasil, jml;
            hasil = count1 * 24350 + count2 * 24550 + count3 * 23750;
            jml = count1 + count2 + count3;
            if (jml > 10)
            {
                textBox1.Text = "Americano\t: " + count1 + "\nEspresso\t\t: " + count2 + "\nCappuccino\t: " + count3 + "\nPembelian terbatas hanya sampai 10 cup";
            }
            else
            {
                textBox1.Text = "Americano\t: " + count1 + "\nEspresso\t\t: " + count2 + "\nCappuccino\t: " + count3 + "\nTotal\t: Rp" + hasil + ",-";
            }
            string data = "Americano : " + count1 + "; Espresso : " + count2 + "; Cappuccino : " + count3 + "; Total : Rp" + hasil;
            Kasir ks = new Kasir(data, hasil, jml);
            ks.Show();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            count1 = count2 = count3 = 0;
            textBox1.Clear();
        }

        private void cappuccino_Click(object sender, EventArgs e)
        {
            count3 = count3 + 1;
            result();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
