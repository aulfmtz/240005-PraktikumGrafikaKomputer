using System.Drawing;
using System.Windows.Forms;

namespace PraktikumGDI2
{
    public partial class FormSoal2 : Form
    {
        public FormSoal2()
        {
            this.Text = "Soal 2 - Objek Kompleks (Perahu Layar)";
            this.Size = new Size(600, 450);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Brush brushLangit = new SolidBrush(Color.MidnightBlue);
            Brush brushBulan = new SolidBrush(Color.LightYellow);
            Brush brushLaut = new SolidBrush(Color.DarkBlue);
            Brush brushBadanPerahu = new SolidBrush(Color.SaddleBrown);
            Brush brushTiang = new SolidBrush(Color.BurlyWood);
            Brush brushLayar = new SolidBrush(Color.WhiteSmoke);
            Pen penGaris = new Pen(Color.Black, 2);

            g.FillRectangle(brushLangit, 0, 0, 600, 250); // Blok warna langit malam
            g.FillRectangle(brushLaut, 0, 250, 600, 200); // Blok warna laut
            g.FillEllipse(brushBulan, 450, 40, 80, 80); // Lingkaran untuk Bulan

            // Menggambar bintang-bintang (lingkaran putih kecil)
            g.FillEllipse(Brushes.White, 100, 80, 5, 5);
            g.FillEllipse(Brushes.White, 250, 50, 4, 4);
            g.FillEllipse(Brushes.White, 350, 120, 6, 6);

            // Koordinat trapesium badan perahu
            Point[] badanPerahu = {
                new Point(150, 250),
                new Point(400, 250),
                new Point(350, 320),
                new Point(200, 320)
            };

            g.FillPolygon(brushBadanPerahu, badanPerahu); // Mewarnai badan perahu
            g.DrawPolygon(penGaris, badanPerahu); // Membuat garis tepi badan perahu
            g.FillRectangle(brushTiang, 265, 80, 10, 170); // Blok warna tiang tegak

            // Koordinat segitiga layar kiri
            Point[] layarKiri = {
                new Point(260, 90),
                new Point(160, 230),
                new Point(260, 230)
            };

            g.FillPolygon(brushLayar, layarKiri); // Mewarnai layar kiri
            g.DrawPolygon(penGaris, layarKiri); // Garis tepi layar kiri

            // Koordinat segitiga layar kanan
            Point[] layarKanan = {
                new Point(280, 110),
                new Point(380, 230),
                new Point(280, 230)
            };

            g.FillPolygon(brushLayar, layarKanan); // Mewarnai layar kanan  
            g.DrawPolygon(penGaris, layarKanan); // Garis tepi layar kanan

            // Membersihkan memori (mencegah memory leak)
            brushLangit.Dispose();
            brushBulan.Dispose();
            brushLaut.Dispose();
            brushBadanPerahu.Dispose();
            brushTiang.Dispose();
            brushLayar.Dispose();
            penGaris.Dispose();
        }
    }
}
