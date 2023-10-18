using Restorant.Models;

namespace Restorant
{
    public partial class EkstraMalzemeEklemeEkrani : Form
    {
        public EkstraMalzemeEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeEklemeEkrani_Click(object sender, EventArgs e)
        {
            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            ekstraMalzeme.Ad = txtEkstraMalzemeAdi.Text;
            ekstraMalzeme.Fiyat = (double)nudEkstraMalzemeFiyati.Value;

            SiparisIslemleri.ekstraMalzemeList.Add(ekstraMalzeme);
        }
    }
}
