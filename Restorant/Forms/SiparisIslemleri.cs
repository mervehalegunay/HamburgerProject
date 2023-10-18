using Restorant.Models;

namespace Restorant
{
    public partial class SiparisIslemleri : Form
    {
        public static List<Menu> menuList = new List<Menu>()
        {
            new Menu () {Ad = "Big King Menü", Fiyat = 109.90},
            new Menu () {Ad = "Whooper Menü" , Fiyat = 256.99}
        };

        public static List<EkstraMalzeme> ekstraMalzemeList = new List<EkstraMalzeme>() {

          new EkstraMalzeme() {Ad = "Ketçap", Fiyat = 10 },
          new EkstraMalzeme() {Ad = "Mayonez", Fiyat = 10 },
        };

        public List<MenuBoyu> menuBoyuList = new List<MenuBoyu>()
        {
           new MenuBoyu(){ Ad = "Küçük", Fiyat=0 },
           new MenuBoyu(){ Ad = "Orta", Fiyat=20 },
           new MenuBoyu(){ Ad = "Büyük", Fiyat=40 }
        };

        public List<Siparis> siparisList = new List<Siparis>();
        public static List<string> siparisNames = new List<string>();

        public double siparisToplam = 0;
        public static double genelToplam = 0;
        public static double ekstraMalzemeToplam = 0;
        public static int satılanUrunAdedi = 0;

        public SiparisIslemleri()
        {
            InitializeComponent();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            string ekstraMalzemeMesaj = string.Empty;

            siparis.Adet = Convert.ToInt32(nudAdet.Value);

            siparis.Menu = new Menu()
            {
                Ad = cboxMenuSeciniz.SelectedItem.ToString()
            };

            foreach (CheckBox c in flwPnlEkstraMalzeme.Controls)
            {
                if (c.Checked)
                {
                    siparis.EkstraMalzeme.Add((EkstraMalzeme)c.Tag);
                }
            }

            MenuBoyu menuBoyu = new MenuBoyu();
            foreach (RadioButton r in flwPnlMenuBoyu.Controls)
            {
                if (r.Checked)
                    menuBoyu.Ad = r.Text;
            }

            siparis.MenuBoyu = menuBoyu;

            double fiyat = Hesapla(siparis);

            string hesap = siparis.Adet.ToString() + " " +
                           siparis.Menu.Ad + ", " +
                           ekstraMalzemeMesaj +
                           siparis.MenuBoyu.Ad + "=>" +
                           "Toplam : ₺" + fiyat.ToString("0.00");

            siparisNames.Add(hesap);
            siparisList.Add(siparis);
            lstBoxSiparisBilgi.Items.Add(hesap);
            lblGenelToplam.Text = "₺" + siparisToplam.ToString("0.00");
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            MenuOlustur();

            EkstraMalzemeOlustur();
        }

        private void EkstraMalzemeOlustur()
        {
            foreach (EkstraMalzeme malzeme in ekstraMalzemeList)
            {
                flwPnlEkstraMalzeme.Controls.Add(new CheckBox() { Text = malzeme.Ad, Tag = malzeme });
            }
        }

        private void MenuOlustur()
        {
            foreach (Menu m in menuList)
            {
                cboxMenuSeciniz.Items.Add(m.Ad);
            }
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Siparişi onaylıyor musunuz ?", "Onay Mesajı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
                Clear();
        }

        private double Hesapla(Siparis siparis)
        {
            double toplam = 0;
            int ekstraMalzemeAdedi = 0;

            foreach (Menu m in menuList)
            {
                if (siparis.Menu.Ad == m.Ad)
                {
                    toplam += siparis.Adet * m.Fiyat;
                }
            }

            foreach (EkstraMalzeme e in ekstraMalzemeList)
            {
                foreach (EkstraMalzeme ekM in siparis.EkstraMalzeme)
                {
                    if (e.Ad == ekM.Ad)
                    {
                        toplam += e.Fiyat;
                        ekstraMalzemeToplam += e.Fiyat;
                        ekstraMalzemeAdedi++;
                    }
                }
            }

            foreach (MenuBoyu m in menuBoyuList)
            {
                if (siparis.MenuBoyu.Ad == m.Ad)
                {
                    toplam += m.Fiyat;
                }
            }

            genelToplam += toplam;
            siparisToplam += toplam;
            satılanUrunAdedi += ekstraMalzemeAdedi + siparis.Adet;
            return toplam;
        }

        private void Clear()
        {
            cboxMenuSeciniz.SelectedIndex = -1;
            foreach (CheckBox c in flwPnlEkstraMalzeme.Controls)
            {
                c.Checked = false;
            }

            foreach (RadioButton r in flwPnlMenuBoyu.Controls)
            {
                r.Checked = false;
            }
            nudAdet.Value = 0;
            lblGenelToplam.Text = "0.00";
            siparisToplam = 0;
            lstBoxSiparisBilgi.Items.Clear();
        }
    }
}
