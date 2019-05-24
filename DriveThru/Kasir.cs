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
    public partial class Kasir : Form
    {
        public int result;
        string datapassing = string.Empty;
        public Kasir(string data, int x, int y)
        {
            InitializeComponent();
            this.datapassing = data;
            if (y <= 10)
            {
                totalpembelian.Text = data;
            }
            else
            {
                totalpembelian.Text = "Maaf, Anda tidak diperkenankan membeli lebih dari 10 cangkir kopi.";
            }

            this.result = x;
        }
        private void Kasir_Load(object sender, EventArgs e)
        {
            
        }

        private void kembalian_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled =
                !Char.IsDigit(e.KeyChar) && e.KeyChar
                != Delete;
        }

        private void bayar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void count_Click(object sender, EventArgs e)
        {
            int byr = int.Parse(bayar.Text);
            kembalian.Text = "Rp" + Convert.ToString(byr - this.result);
        }
    }
}
