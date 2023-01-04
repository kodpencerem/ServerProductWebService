using ClientProductWebService.ProductWebServiceConsumer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProductWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            ProductWebServiceSoapClient urungetir = new ProductWebServiceSoapClient();

            dataGridView1.DataSource = urungetir.UrunleriGetir();
        }
    }
}