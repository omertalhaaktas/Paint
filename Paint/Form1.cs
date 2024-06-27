using System.Drawing.Imaging;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Paint
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 850;
            this.Height = 700;
            bm = new Bitmap(resim.Width, resim.Height);
            grafik = Graphics.FromImage(bm);
            grafik.Clear(Color.White);
            resim.Image = bm;
        }

        Bitmap bm;
        bool ciz = false;
        Graphics grafik;
        Point px, py;
        Pen kalem = new Pen(Color.Black, 1);
        Pen silgi = new Pen(Color.White, 10);
        int kalinlik;
        int x, y, sX, sY, cX, cY;

        ColorDialog renksec = new ColorDialog();
        Color new_color;

        private void resim_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void resim_MouseMove(object sender, MouseEventArgs e)
        {
            if (ciz)
            {
                if (kalinlik == 1)
                {
                    px = e.Location;
                    grafik.DrawLine(kalem, px, py);
                    py = px;
                }
                if (kalinlik == 2)
                {
                    px = e.Location;
                    grafik.DrawLine(silgi, px, py);
                    py = px;
                }

            }
            resim.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void resim_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;

            sX = x - cX;
            sY = y - cY;

            if (kalinlik == 3)
            {
                grafik.DrawEllipse(kalem, cX, cY, sX, sY);
            }
            if (kalinlik == 4)
            {
                grafik.DrawRectangle(kalem, cX, cY, sX, sY);
            }
            if (kalinlik == 5)
            {
                grafik.DrawLine(kalem, cX, cY, x, y);
            }
        }
        private void btn_kalem_Click(object sender, EventArgs e)
        {
            kalinlik = 1;
        }

        private void btn_silgi_Click(object sender, EventArgs e)
        {
            kalinlik = 2;
        }

        private void btn_yuvarlak_Click(object sender, EventArgs e)
        {
            kalinlik = 3;
        }

        private void btn_kare_Click(object sender, EventArgs e)
        {
            kalinlik = 4;
        }

        private void btn_cizgi_Click(object sender, EventArgs e)
        {
            kalinlik = 5;
        }

        private void resim_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafik = e.Graphics;

            if (ciz)
            {
                if (kalinlik == 3)
                {
                    grafik.DrawEllipse(kalem, cX, cY, sX, sY);
                }
                if (kalinlik == 4)
                {
                    grafik.DrawRectangle(kalem, cX, cY, sX, sY);
                }
                if (kalinlik == 5)
                {
                    grafik.DrawLine(kalem, cX, cY, x, y);
                }
            }
        }


        private void btn_temizle_Click(object sender, EventArgs e)
        {
            grafik.Clear(Color.White);
            resim.Image = bm;
            kalinlik = 0;
        }

        private void Resim_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_renk_Click(object sender, EventArgs e)
        {
            renksec.ShowDialog();
            new_color = renksec.Color;
            resim_rengi.BackColor = renksec.Color;
            kalem.Color = renksec.Color;
        }



        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X*pX),(int)(pt.Y * pY));
        }



        private void renk_secici_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(renk_secici, e.Location);
            resim_rengi.BackColor = ((Bitmap)renk_secici.Image).GetPixel(point.X, point.Y);
            new_color = resim_rengi.BackColor;
            kalem.Color = resim_rengi.BackColor;
        }

        private void validate(Bitmap bm,Stack<Point> sp,int x, int y,Color old_color,Color new_color)
        {
            Color cx= bm.GetPixel(x, y);
            if (cx==old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x,y,new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;

            while(pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X>0 && pt.Y>0 && pt.X<bm.Width-1 && pt.Y<bm.Height-1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y-1, old_color, new_clr);
                    validate(bm, pixel, pt.X+1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y+1, old_color, new_clr);
                }
            }
        }
        private void resim_MouseClick(object sender, MouseEventArgs e)
        {
            if (kalinlik==7)
            {
                Point point = set_point(resim, e.Location);
                Fill(bm,point.X,point.Y,new_color);
            }
        }
        private void btn_doldur_Click(object sender, EventArgs e)
        {
            kalinlik= 7;
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg) |*.jpg|(*.*|*.*";
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, resim.Width, resim.Height),bm.PixelFormat);
                btm.Save(sfd.FileName,ImageFormat.Jpeg);
                MessageBox.Show("Resim Baþarýyla Kaydedildi...");
            }
        }
        private void comboBoxKalinlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxKalinlik.SelectedItem.ToString(), out int secilenKalite))
            {
                
                kalem.Width = secilenKalite;
                silgi.Width = secilenKalite; 
            }
        }

    }
}