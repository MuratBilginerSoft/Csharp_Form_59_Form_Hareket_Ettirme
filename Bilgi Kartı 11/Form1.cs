using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bilgi_Kartı_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Kapat Butonu

            Application.Exit(); // Bu tüm uygulamanın kapanmasını sağlar
            this.Close(); // Bu kod ise o anki çalışan formu kapatır.
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Maximize Butonu
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;

            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Minimize Butonu
            this.WindowState = FormWindowState.Minimized;
        }

        Point İlkkonum; // Bu değişkenler Global olarak tanımlanmalı.
        bool durum = false;


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Mouse a tıklandığı anda. Burada sol yada sağ tıklanması farketmeyecektir.
            durum = true;
            this.Cursor = Cursors.SizeAll; // Fareyi taşıma şeklinde seçim yapılmış ikon halini almasını sağladık.
            İlkkonum = e.Location; /* İlk konum olarak fareye tam basıldığında e parametresinin Location özelliğini
                                    * kullanarak konum aldık. X ve Y koordinatlarını almış olduk.*/

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Mouse'u hareket ettirdiğimizde çalışacak kodlar.
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Mouse'u bıraktığımızda çalışacak kodlar.
            durum = false;
            this.Cursor = Cursors.Default; // Fare işaretçisi Default halini aldı.

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
