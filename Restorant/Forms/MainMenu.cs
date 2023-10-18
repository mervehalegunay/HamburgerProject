using Microsoft.VisualBasic.Logging;

namespace Restorant
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            SiparisOlusturGetir();
        }

        private void SiparisOlusturGetir()
        {
            FormlarýKapat();
            SiparisIslemleri sog = new SiparisIslemleri();
            sog.MdiParent = this;
            sog.Dock = DockStyle.Fill;
            this.Width = sog.Width + 30;
            this.Height = sog.Height + 60;
            sog.Show();
        }

        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisOlusturGetir();
        }

        private void sipariþleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisGoruntule sg = new SiparisGoruntule();
            sg.MdiParent = this;
            sg.Dock = DockStyle.Fill;
            this.Width = sg.Width + 30;
            this.Height = sg.Height + 60;
            sg.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEklemeEkrani mee = new MenuEklemeEkrani();
            mee.MdiParent = this;
            mee.Dock = DockStyle.Fill;
            this.Width=mee.Width + 30;
            this.Height=mee.Height + 60;
            mee.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkstraMalzemeEklemeEkrani emek = new EkstraMalzemeEklemeEkrani();
            emek.MdiParent = this;
            emek.Dock = DockStyle.Fill;
            this.Width = emek.Width + 30;
            this.Height =emek.Height +60;
            emek.Show();    
        }

        private void FormlarýKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
    }
}