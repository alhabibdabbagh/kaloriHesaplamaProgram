using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//www.gorselprogramlama.com

namespace ornek1
{
    public partial class fbesinlistesi : Form
    {
        ComboBox f1cbesin;
        ListBox f1porsmiktari, f1kalorimiktari;

        public fbesinlistesi(ComboBox cb, ListBox lb1, ListBox lb2)
        {
            InitializeComponent();

            f1cbesin = cb;
            f1porsmiktari = lb1;
            f1kalorimiktari = lb2;

            for (int i = 0; i < cb.Items.Count; i++)
            {
                lbesin.Items.Add(f1cbesin.Items[i]);
                lpormik.Items.Add(f1porsmiktari.Items[i]);
                lkalori.Items.Add(f1kalorimiktari.Items[i]);
            
            }

        }

        private void bekle_Click(object sender, EventArgs e)
        {
            int pormik, kalori;
            bool k1 = Int32.TryParse(tpormik.Text, out pormik);
            bool k2 = Int32.TryParse(tkalori.Text, out kalori);

            if (k1 && k2 && tbesin.Text.Length > 0)
            {
                lbesin.Items.Add(tbesin.Text);
                lpormik.Items.Add(pormik);
                lkalori.Items.Add(kalori);

                f1cbesin.Items.Add(tbesin.Text);
                f1porsmiktari.Items.Add(pormik);
                f1kalorimiktari.Items.Add(kalori);

                tbesin.Clear();
                tpormik.Clear();
                tkalori.Clear();
            }

        }

        private void bduzenle_Click(object sender, EventArgs e)
        {
            int secilen = lbesin.SelectedIndex;
            
            int pormik, kalori;
            bool k1 = Int32.TryParse(tpormik.Text, out pormik);
            bool k2 = Int32.TryParse(tkalori.Text, out kalori);

            if (secilen > -1 && k1 && k2)
            {
                lpormik.Items[secilen] = pormik;//www.gorselprogramlama.com
                lkalori.Items[secilen] = kalori;

                f1porsmiktari.Items[secilen] = pormik;
                f1kalorimiktari.Items[secilen] = kalori;

                tpormik.Clear();
                tkalori.Clear();
            }


        }

        private void bdyaz_Click(object sender, EventArgs e)
        {
            string yazilacak = "";
            for (int i = 0; i < lbesin.Items.Count; i++)
                yazilacak += lbesin.Items[i] + ";" + lpormik.Items[i] + ";" + lkalori.Items[i] + "\n";
            try
            {
                File.WriteAllText("besinliste.txt", yazilacak);
            }
            catch { }
        
        }

        private void bdoku_Click(object sender, EventArgs e)
        {
            lbesin.Items.Clear();
            lpormik.Items.Clear();
            lkalori.Items.Clear();

            f1cbesin.Items.Clear();
            f1kalorimiktari.Items.Clear();
            f1porsmiktari.Items.Clear();

            try {
               string[] liste= File.ReadAllLines("besinliste.txt");
               string[] ayrac = {";" };

                for (int i = 0; i < liste.Length; i++)
               {
                   string[] sutun = liste[i].Split(ayrac,StringSplitOptions.None);
                   if (sutun.Length == 3)
                   {
                       int pormik, kalori;
                       bool k1 = Int32.TryParse(sutun[1],out pormik);
                       bool k2 = Int32.TryParse(sutun[2], out kalori);

                       if (k1 && k2 && sutun[0].Length > 0)
                       {
                           lbesin.Items.Add(sutun[0]);
                           lpormik.Items.Add(pormik);
                           lkalori.Items.Add(kalori);

                           f1cbesin.Items.Add(sutun[0]);
                           f1porsmiktari.Items.Add(pormik);
                           f1kalorimiktari.Items.Add(kalori);
                       }
                   }
               }


            }
            catch { }

        }//www.gorselprogramlama.com
    }
}
