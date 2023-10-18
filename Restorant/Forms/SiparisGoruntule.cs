namespace Restorant
{
    public partial class SiparisGoruntule : Form
    {
        public SiparisGoruntule()
        {
            InitializeComponent();
        }

        private void SiparisleriGoruntule_Load(object sender, EventArgs e)
        {
            foreach (string name in SiparisIslemleri.siparisNames)
            {
                lstBoxAlinanTumSiparisler.Items.Add(name);
            }

            lblCiro.Text = "₺" + SiparisIslemleri.genelToplam.ToString("0.00");
            lblToplamSiparis.Text = lstBoxAlinanTumSiparisler.Items.Count.ToString();
            lblEkstraMalzemeGeliri.Text = "₺" + SiparisIslemleri.ekstraMalzemeToplam.ToString("0.00");
            lblSatilanUrunAdedi.Text = SiparisIslemleri.satılanUrunAdedi.ToString();
        }
    }
}
