using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
{
    public partial class Form1 : Form
    {
        double[] katsayi_bay = {66,13.7,5,6.8};
        double[] katsayi_bayan = {655,9.6,1.7,4.7};
        public Form1()
        {
            InitializeComponent();
            tyas.Text = "25";
            tboy.Text = "170";
            tkilo.Text = "79,5";
            rbay.Checked = true;
            lagunkal.Text = "0";
            lalistekal.Text = "0";
            cbesin.Text = "Seçiniz";
        }


        private void kisigunluk()
        {
            double[] katsayi = katsayi_bay;

            if (rbayan.Checked)
                katsayi = katsayi_bayan;

            int yas;
            double boy, kilo, aktivite = 1;

            bool k1 = Int32.TryParse(tyas.Text, out yas);
            bool k2 = Double.TryParse(tboy.Text, out boy);
            bool k3 = Double.TryParse(tkilo.Text, out kilo);

            if (k1 && k2 && k3)
            {
                int gereklikalori = (int)Math.Ceiling((katsayi[0] + katsayi[1] * kilo + katsayi[2] * boy - katsayi[3] * yas) * aktivite);

                lagunkal.Text =gereklikalori+" cal";
            }
            else
            {
                lagunkal.Text = "-";
            }

            int toplam = 0;
            for (int i = 0; i < lkalori.Items.Count; i++)
                toplam += (int)lkalori.Items[i];

            lalistekal.Text = toplam + " cal";
        
        }

        private void bekle_Click(object sender, EventArgs e)
        {
            double porsiyon;
            bool k = Double.TryParse(tporsiyon.Text, out porsiyon);

            int secilen = cbesin.SelectedIndex;

            if (secilen > -1 && k)
            {
                lbesin.Items.Add(cbesin.Text);
                lporsiyon.Items.Add(porsiyon);
                lkalori.Items.Add(kalorihesapla(secilen,porsiyon));

                cbesin.Text = "Seçilen";
                tporsiyon.Clear();
                kisigunluk();
            }
        }

        private int kalorihesapla(int secilen, double porsiyon)
        {
            double kalori = 0;

            int mevcutmiktar = (int)porsmiktari.Items[secilen];
            int kalorimiktar = (int)kalorimiktari.Items[secilen];

            kalori = porsiyon *1.0* kalorimiktar / mevcutmiktar;

            return (int)Math.Ceiling(kalori);
        }

        private void bsil_Click(object sender, EventArgs e)
        {
            int secilen = lbesin.SelectedIndex;
            if (secilen > -1)
            {
                lbesin.Items.RemoveAt(secilen);
                lporsiyon.Items.RemoveAt(secilen);
                lkalori.Items.RemoveAt(secilen);
                kisigunluk();
            }

        }

        ListBox porsmiktari = new ListBox();
        ListBox kalorimiktari = new ListBox();

        private void bliste_Click(object sender, EventArgs e)
        {
            fbesinlistesi frm = new fbesinlistesi(cbesin,porsmiktari,kalorimiktari);
            frm.ShowDialog();
        }
    }
}
