using ClientProductWebService.CustomerWebServiceConsumer;
using ClientProductWebService.ProductWebServiceConsumer;
using System;
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

        private void btnMusteriGetir_Click(object sender, EventArgs e)
        {
            CustomerWebServiceSoapClient musteriGetir = new CustomerWebServiceSoapClient();
            dataGridView1.DataSource = musteriGetir.MusteriGetir();
        }

        private void btnTcknSor_Click(object sender, EventArgs e)
        {
            TcknKimlikDogrula dogrula = new TcknKimlikDogrula();
            dogrula.ShowDialog();

        }
    }
}