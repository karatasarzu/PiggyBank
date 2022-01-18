using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiggyBank.Exception_Library;

namespace PiggyBank
{
    public partial class KumbaraForm : Form
    {
        Kumbara kumbara = new Kumbara(75000);

        private readonly List<KagitPara> KagitParalar = new List<KagitPara>();
        private readonly List<BozukPara> BozukParalar = new List<BozukPara>();
        private readonly BindingList<Para> atilanKagitParalar = new BindingList<Para>();
        private readonly BindingList<Para> atilanBozukParalar = new BindingList<Para>();

        Para secilen;
        string atilacak;
        bool katlandiMi = false;
        int kirilmaSayisi = 0;
        double birikenMiktar = 0;
        double toplamHacim = 0;
        double fazlaHacim = 0;

        public KumbaraForm()
        {
            InitializeComponent();
            ParalariOlusturEkle();
            pnlDolu.Height = 0;
        }
        private void ParalariOlusturEkle()
        {
            BozukParalar.Add(new BozukPara() { Ad = "1 Kuruş", Deger = 0.01, Cap = 16.50, Yukseklik = 1.35 });
            BozukParalar.Add(new BozukPara() { Ad = "5 Kuruş", Deger = 0.05, Cap = 17.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "10 Kuruş", Deger = 0.10, Cap = 18.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "25 Kuruş", Deger = 0.25, Cap = 20.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "50 Kuruş", Deger = 0.50, Cap = 23.85, Yukseklik = 1.90 });
            BozukParalar.Add(new BozukPara() { Ad = "1 Lira", Deger = 1.0, Cap = 26.15, Yukseklik = 1.90 });

            KagitParalar.Add(new KagitPara() { Ad = "5 Lira", Deger = 5.0, En = 64.0, Boy = 130.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "10 Lira", Deger = 10.0, En = 64.0, Boy = 136.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "20 Lira", Deger = 20.0, En = 68.0, Boy = 142.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "50 Lira", Deger = 50.0, En = 68.0, Boy = 148.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "100 Lira", Deger = 100.0, En = 72.0, Boy = 154.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "200 Lira", Deger = 200.0, En = 72.0, Boy = 160.0, Yukseklik = 0.25 });

            cmbKagitPara.Items.Add("Seçiniz");
            foreach (var item in KagitParalar)
            {
                cmbKagitPara.Items.Add(item.Ad);
            }
            cmbKagitPara.SelectedIndex = 0;
            cmbBozukPara.Items.Add("Seçiniz");
            foreach (var item in BozukParalar)
            {
                cmbBozukPara.Items.Add(item.Ad);
            }
            cmbBozukPara.SelectedIndex = 0;
        }
        private void cmbKagitPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKagitPara.SelectedIndex > 0)
            {
                cmbBozukPara.Enabled = false;
                btnKatla.Visible = true;
                atilacak = cmbKagitPara.SelectedItem.ToString();
                foreach (var item in KagitParalar)
                {
                    if (atilacak == item.Ad)
                    {
                        secilen = (KagitPara)item;
                    }
                }
            }
        }
        private void cmbBozukPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBozukPara.SelectedIndex > 0)
            {
                cmbKagitPara.Enabled = false;
                atilacak = cmbBozukPara.SelectedItem.ToString();
                foreach (var item in BozukParalar)
                {
                    if (atilacak == item.Ad)
                    {
                        secilen = (BozukPara)item;
                    }
                }
            }
        }
        private void btnParaAt_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilen == null)
                {
                    throw new AtilacakParaSecilmediException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (secilen is BozukPara)
            {
                BozukPara bozukpara = (BozukPara)secilen;
                try
                {
                    if (toplamHacim + bozukpara.Hacim() + bozukpara.FazladanHacim(secilen.Hacim()) > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDolduException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriSifirla();
                }
                atilanBozukParalar.Add(bozukpara);
                birikenMiktar += bozukpara.Deger;
                toplamHacim += bozukpara.Hacim() + bozukpara.FazladanHacim(bozukpara.Hacim());
                fazlaHacim += bozukpara.FazladanHacim(bozukpara.Hacim());

                kumbara.ParaEkle(bozukpara.Hacim() + bozukpara.FazladanHacim(bozukpara.Hacim()));
                BozukParaAtmaSesi();
                SeviyeGuncelle();
                HacimleriYazdir();
            }
            else if (secilen is KagitPara)
            {
                KagitPara kagitpara = (KagitPara)secilen;
                try
                {
                    if (toplamHacim + kagitpara.Hacim() + kagitpara.FazladanHacim(secilen.Hacim()) > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDolduException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriSifirla();
                }
                try
                {
                    if (katlandiMi == false)
                    {
                        throw new ParaKatlanmadiException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                atilanKagitParalar.Add(kagitpara);
                birikenMiktar += kagitpara.Deger;
                toplamHacim += kagitpara.Hacim() + kagitpara.FazladanHacim(kagitpara.Hacim());
                fazlaHacim += kagitpara.FazladanHacim(kagitpara.Hacim());

                kumbara.ParaEkle(kagitpara.Hacim() + kagitpara.FazladanHacim(kagitpara.Hacim()));
                pnlDolu.Height = (int)(kumbara.DolulukOrani * pnlTotal.Height);
                KagitParaAtmaSesi();
                HacimleriYazdir();
            }
            btnSalla.Enabled = true;
            VerileriSifirla();
        }
        private void VerileriSifirla()
        {
            cmbBozukPara.SelectedIndex = 0;
            cmbKagitPara.SelectedIndex = 0;
            katlandiMi = false;
            btnKatla.Text = "Katla!";
            btnKatla.Enabled = true;
            btnKatla.Visible = false;
            secilen = null;
            cmbBozukPara.Enabled = true;
            cmbKagitPara.Enabled = true;
        }
        private void btnKatla_Click(object sender, EventArgs e)
        {
            KagitPara katlanacak = (KagitPara)secilen;
            if (katlanacak != null)
            {
                katlandiMi = true;
                katlanacak.Katla(katlanacak.Hacim());
                btnKatla.Text = "Katlandı!";
                btnKatla.Enabled = false;
            }
            KagitParaKatlamaSesi();
        }
        private void btnSalla_Click(object sender, EventArgs e)
        {
            if (toplamHacim > fazlaHacim)
            {
                toplamHacim = toplamHacim - kumbara.Salla(fazlaHacim);
                kumbara.ParaEkle(-kumbara.Salla(fazlaHacim));
            }
            KumbaraSallamaSesi();
            SeviyeGuncelle();
            fazlaHacim = 0;
            btnSalla.Enabled = false;
            HacimleriYazdir();
            VerileriSifirla();
        }
        private void btnKir_Click(object sender, EventArgs e)
        {
            if (kirilmaSayisi == 0)
            {
                ParalarForm paralarForm = new ParalarForm(atilanKagitParalar, atilanBozukParalar, birikenMiktar);
                try
                {
                    if (birikenMiktar > 0)
                    {
                        KumbaraKirmaSesi();
                        paralarForm.ShowDialog();
                    }
                    else
                    {
                        throw new KumbaraBosException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnKir.Text = "Yapıştır!";
                btnParaAt.Enabled = false;
                btnKatla.Enabled = false;
                btnSalla.Enabled = false;
                atilanKagitParalar.Clear();
                atilanBozukParalar.Clear();
                kirilmaSayisi++;
                cmbBozukPara.Enabled = false;
                cmbKagitPara.Enabled = false;
                KumbaraSifirla();
                SeviyeGuncelle();
            }
            else if (kirilmaSayisi == 1)
            {
                this.BackgroundImage = Properties.Resources.Affixed_Glass_Piggy_Bank;
                btnKir.Text = "Kır!";
                cmbBozukPara.Enabled = true;
                cmbKagitPara.Enabled = true;
                btnParaAt.Enabled = true;
                btnKatla.Enabled = true;
                btnSalla.Enabled = true;
                kirilmaSayisi++;
                KumbaraSifirla();
                SeviyeGuncelle();
            }
            else if (kirilmaSayisi > 1)
            {
                ParalarForm paralarForm = new ParalarForm(atilanKagitParalar, atilanBozukParalar, birikenMiktar);
                try
                {
                    if (birikenMiktar > 0)
                    {
                        KumbaraKirmaSesi();
                        paralarForm.ShowDialog();
                    }
                    else
                    {
                        throw new KumbaraBosException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnKir.Text = "Kırılamaz!";
                btnParaAt.Enabled = false;
                btnKir.Enabled = false;
                btnKatla.Enabled = false;
                btnSalla.Enabled = false;
                KumbaraSifirla();
                SeviyeGuncelle();
                try
                {
                    throw new KumbaraKullanilamazException();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
        }
        private void BozukParaAtmaSesi()
        {
            string path = Environment.CurrentDirectory.Replace("\\bin\\Debug", "") + "\\Resources\\DropCoins.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Play();
        }
        private void KumbaraSallamaSesi()
        {
            string path = Environment.CurrentDirectory.Replace("\\bin\\Debug", "") + "\\Resources\\Shaking.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Play();
        }
        private void KagitParaAtmaSesi()
        {
            string path = Environment.CurrentDirectory.Replace("\\bin\\Debug", "") + "\\Resources\\DropBanknote.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Play();
        }
        private void KumbaraKirmaSesi()
        {
            string path = Environment.CurrentDirectory.Replace("\\bin\\Debug", "") + "\\Resources\\BreakingPiggy.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Play();
        }
        private void KagitParaKatlamaSesi()
        {
            string path = Environment.CurrentDirectory.Replace("\\bin\\Debug", "") + "\\Resources\\Folding.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Play();
        }
        private void KumbaraSifirla()
        {
            birikenMiktar = 0;
            kumbara.ParaMiktari = 0;
            toplamHacim = 0;
            fazlaHacim = 0;
            lblParaHacmi.Text = "Paraların kapladığı hacim: 0";
            lblFazladan.Text = "Paraların kapladığı fazladan hacim: 0";
            pnlDolu.Height = 0;
        }
        private void SeviyeGuncelle()
        {
            pnlDolu.Height = (int)(kumbara.DolulukOrani * pnlTotal.Height);
        }
        public void HacimleriYazdir()
        {
            lblParaHacmi.Text = "Paraların kapladığı hacim: " + toplamHacim.ToString();
            lblFazladan.Text = "Paraların kapladığı fazladan hacim: " + fazlaHacim.ToString();
        }
    }
}
