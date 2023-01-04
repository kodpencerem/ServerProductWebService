using System;
using System.Windows.Forms;
using ClientProductWebService.TcknKpsService;

namespace ClientProductWebService
{
    public partial class TcknKimlikDogrula : Form
    {
        public TcknKimlikDogrula()
        {
            InitializeComponent();
        }

        private void TcknKimlikDogrula_Load(object sender, EventArgs e)
        {
            txtTckn.PasswordChar= '*';
            txtDogumYili.PasswordChar= '*';

        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            KPSPublicSoapClient proxy = new KPSPublicSoapClient();

            bool Dogrula = proxy.TCKimlikNoDogrula(Convert.ToInt64(txtTckn.Text),txtAdi.Text,txtSoyadi.Text, Convert.ToInt32(txtDogumYili.Text));

            if (Dogrula==true) {

                MessageBox.Show("Evet Tckn Doğru!");
            }
            else
            {
                MessageBox.Show("Evet Tckn Yanlış!");
            }

            

        }

       
    }
}
