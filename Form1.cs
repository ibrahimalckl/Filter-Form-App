using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltreDeneme
{
    public partial class Form1 : Form
    {
        Bitmap resim;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            resim = new Bitmap(pictureBox1.Image);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGri.Click += BtnGri_Click;
            btnSiyah.Click += BtnSiyah_Click;
        }

        private void BtnSiyah_Click(object sender, EventArgs e)
        {
            Bitmap yeniResim = new Bitmap(resim.Width, resim.Height);

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    Color eskiRenk = resim.GetPixel(x, y);
                    int R = eskiRenk.R;
                    int G = eskiRenk.G;
                    int B = eskiRenk.B;

                    int toplam = (R + G + B) / 3;

                    Color yeniRenk = Color.Black;

                    if (toplam > 150)
                    {
                        yeniRenk = Color.White;
                    }

                    yeniResim.SetPixel(x, y, yeniRenk);
                }
            }

            pictureBox1.Image = yeniResim;

        }

        private void BtnGri_Click(object sender, EventArgs e)
        {
            Bitmap yeniResim = new Bitmap(resim.Width, resim.Height);

            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    Color eskiRenk = resim.GetPixel(x, y);
                    int R = eskiRenk.R;
                    int G = eskiRenk.G;
                    int B = eskiRenk.B;
                    int sonuc = (R + G + B) / 3;

                    Color yeniRenk = Color.FromArgb(sonuc, sonuc, sonuc);

                    yeniResim.SetPixel(x, y, yeniRenk);
                }
            }

            pictureBox1.Image = yeniResim;

        }
    }
}
