using Restorant.Models;

namespace Restorant
{
    public partial class MenuEklemeEkrani : Form
    {
        public MenuEklemeEkrani()
        {
            InitializeComponent();
        }

        private void btnMenuEklemeEkrani_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Ad = txtMenuEklemeAdi.Text;
            menu.Fiyat = (double)nudMenuEklemeFiyati.Value;

            SiparisIslemleri.menuList.Add(menu);
        }
    }
}
