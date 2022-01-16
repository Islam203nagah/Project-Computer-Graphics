using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Graphics
{
    public partial class Ellips_Draw : Form
    {
        public Ellips_Draw()
        {
            InitializeComponent();
        }
        public void ellips(int xc,int yc,int Rx,int Ry)
        {
            Bitmap bit = new Bitmap(picture_Ellips.Width, picture_Ellips.Height);
            int Rx2 = Rx * Rx, Ry2 = Ry * Ry, twoRx2 = 2 * Rx2, twoRy2 = 2 * Ry2;
            double p;
            int x = 0, y = Ry, dx = twoRy2 * x, dy = twoRx2 * y;

            //region one
            //   p = (int)Math.Round(Ry2 - (Rx2 * Ry) + (0.25 * Rx2));    //  (b^2) - ( a^2 * b ) + ( a^2 * (1/4) )
            p = Math.Pow(Ry, 2) - (Math.Pow(Rx, 2) * Ry) + (Math.Pow(Rx, 2) * 0.25);
            pointEllipsRegon1.Rows.Add(new object[] { 0, p, x, y, dx, dy });
            int i = 1;
            do
            {
                x++;
                dx = twoRy2 * x;

                if (p < 0)
                    p += Ry2 + dx;

                else
                {
                    y--;
                    dy = twoRx2 * y;
                    p += Ry2 + dx - dy;
                }
                pointEllipsRegon1.Rows.Add(new object[] { i++, p, x, y, dx, dy });

                bit.SetPixel(xc + x, yc + y, Color.Red);
                bit.SetPixel(xc - x, yc + y, Color.Red);
                bit.SetPixel(xc - x, yc - y, Color.Red);
                bit.SetPixel(xc + x, yc - y, Color.Red);

            } while (dx < dy);


            //region two
            p = (int)Math.Round((y - 1) * Rx2 * (y - 1) + Ry2 * (x + .5) * (x + .5) - Rx2 * Ry2);
            pointEillpsRegon2.Rows.Add(new object[] { 0, p, x, y, dx, dy });
            i = 1;
            while (y > 0)
            {
               
                if (p > 0)
                {
                    y--;
                    dy = twoRx2 * y;
                    p += Rx2 - dy;
                    
                }
                else
                {
                    x++;
                    y--;
                    dy = twoRx2 * y;
                    dx = twoRy2 * x;
                    p += Rx2 - dy + dx;
                    
                }
                pointEillpsRegon2.Rows.Add(new object[] { i++, p, x, y, dx, dy });

                bit.SetPixel(xc + x, yc + y, Color.Red);
                bit.SetPixel(xc - x, yc + y, Color.Red);
                bit.SetPixel(xc - x, yc - y, Color.Red);
                bit.SetPixel(xc + x, yc - y, Color.Red);



            }

            picture_Ellips.Image = bit;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int xc = int.Parse(txt_xcenter.Text);
            int yc = int.Parse(txt_ycenter.Text);
            int raduisx = int.Parse(txt_radiusx.Text);
            int radiusy = int.Parse(txt_radiusy.Text);
            ellips(xc,yc,raduisx,radiusy);
        }
        public void translate( int xc, int yc, int rx, int ry, int tx, int ty)
        {
            xc = xc + tx;
            yc = yc + tx;
            ellips(xc, yc, rx, ry);
        }
        private void btn_translate_Click(object sender, EventArgs e)
        {
            int Xc = int.Parse(txt_xcenter.Text);
            int Yc = int.Parse(txt_ycenter.Text);
            int raduisx = int.Parse(txt_radiusx.Text);
            int radiusy = int.Parse(txt_radiusy.Text);
            int tx = int.Parse(txt_Tx_Sx_Theta.Text);
            int ty = int.Parse(txt_Ty_Sy.Text);
            translate(Xc, Yc, raduisx, radiusy,tx,ty);
        }
        public void scaling(int xc,int yc ,int rx, int ry,int sx,int sy)
        {
             
            rx *= sx;
            ry *= sy;
            ellips(xc, yc, rx, ry);
        }
        private void btn_Scale_Click(object sender, EventArgs e)
        {
            int Xc = int.Parse(txt_xcenter.Text);
            int Yc = int.Parse(txt_ycenter.Text);
            int raduisx = int.Parse(txt_radiusx.Text);
            int radiusy = int.Parse(txt_radiusy.Text);
            int sx = int.Parse(txt_Tx_Sx_Theta.Text);
            int sy = int.Parse(txt_Ty_Sy.Text);
            scaling(Xc, Yc, raduisx, radiusy, sx, sy);
        }
        public void rotate(int xc, int yc, int rx, int ry, double angle)
        {
            double theta = angle * ((int)Math.PI / 180);
            rx = (int)(rx * Math.Cos(angle) - ry * Math.Sin(angle));
            ry = (int)(rx * Math.Sin(angle) + ry * Math.Cos(angle));
            ellips(xc,yc,rx,ry);

        }
        public void ReflectEllips(int xc, int yc, int Rx, int Ry)
        {
            int temp;
            temp = xc;
            xc = yc;
            yc = temp;

            temp = Rx;
            Rx = Ry;
            Ry = temp;
            ellips(xc,yc,Rx,Ry);
        }
        private void btn_reflect_Click(object sender, EventArgs e)
        {
            int rx = int.Parse(txt_radiusx.Text);
            int ry = int.Parse(txt_radiusy.Text);
            int xc = int.Parse(txt_xcenter.Text);
            int yc = int.Parse(txt_ycenter.Text);
            ReflectEllips(xc, yc, rx, ry);
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            int rx = int.Parse(txt_radiusx.Text);
            int ry = int.Parse(txt_radiusy.Text);
            int xc = int.Parse(txt_xcenter.Text);
            int yc = int.Parse(txt_ycenter.Text);
            double ang = double.Parse(txt_Tx_Sx_Theta.Text);
            rotate(xc, yc, rx, ry, ang);
        }

        private void btn_backEllips_Click(object sender, EventArgs e)
        {
            Frm_Home frmback3 = new Frm_Home();
            frmback3.Show();
            this.Close();
        }

    }
}
