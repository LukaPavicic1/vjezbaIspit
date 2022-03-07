using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vježbaZaTest1
{
    public partial class Form1 : Form
    {
        List<Zrakoplov> listaZrakoplova = new List<Zrakoplov>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpis_Click(object sender, EventArgs e)
        {

            Zrakoplov zrakoplov = new Zrakoplov(vrsta.Text, txbIme.Text, GodProd.Value, trckBrzina.Value, chkDa.Checked);
            listaZrakoplova.Add(zrakoplov);
            MessageBox.Show("uspjeh lol", "uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            foreach (Zrakoplov zrakoplov in listaZrakoplova)
            {
                richTextBox1.AppendText(zrakoplov.ToString());
            }


        }
    }
}
