using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesliSessizHarfBulmaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbkelime_TextChanged(object sender, EventArgs e)
        {
            lKelime.Text = tbkelime.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lKelime.Text = "";
            lSonuc.Text = "";
        }

        private void bBul_Click(object sender, EventArgs e)
        {
            SesliSessizHarfBul();
        }

        private void SesliSessizHarfBul()
        {
            char[] sesliHarfler = new char[8]
            {
                'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'
            };
            string sonuc = "";
            /* Çağıl Yolu
            if (rbSesli.Checked)
            {
                foreach (char kelimeKarakter in tbkelime.Text.ToLower())
                {
                    foreach (char sesliHarf in sesliHarfler)
                    {
                        if (kelimeKarakter == sesliHarf)
                        {
                            if (!sonuc.Contains(sesliHarf))
                            {
                                sonuc += sesliHarf;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                bool sessizHarfMi; //flag
                foreach (char kelimeKarakter in tbkelime.Text.ToLower())
                {
                    sessizHarfMi = true;
                    foreach (char sesliHarf in sesliHarfler)
                    {
                        if (kelimeKarakter == sesliHarf)
                        {
                            sessizHarfMi = false;
                        }
                    }
                    if (sessizHarfMi && !sonuc.Contains(kelimeKarakter))
                    {
                        sonuc += kelimeKarakter;
                    }
                }
            }
            */
            string sesliler = "";
            foreach (char kelimeKarakter in tbkelime.Text.ToLower())
            {
                foreach (char sesliHarf in sesliHarfler)
                {
                    if (kelimeKarakter == sesliHarf)
                    {
                        if (!sonuc.Contains(sesliHarf))
                        {
                            sonuc += sesliHarf;
                            break;
                        }
                    }
                }
            }
            string sessizler = "";
            foreach (char kelimeKarakter in tbkelime.Text.ToLower())
            {
                if (!sesliler.Contains(kelimeKarakter) && !sessizler.Contains(kelimeKarakter))
                    sessizler += kelimeKarakter;
            }
            if (rbSesli.Checked)
                sonuc = sesliler;
            else
                sonuc = sessizler;

            lSonuc.Text = sonuc;

        }
    }
}
