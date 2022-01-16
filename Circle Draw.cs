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
    public partial class Circle_Draw : Form
    {
        public Circle_Draw()
        {
            InitializeComponent();
        }
        public void midPoint(int xcint,int ycint,int radius)
        {
            int  x = 0, y = radius;
            double Pk = (5 / 4) - radius;
            Bitmap bit = new Bitmap(picture_midpoint.Width / 2, picture_midpoint.Height / 2);
            int i = 1;
            while (x <= y)
            {
                if (Pk < 0)
                {
                    x = x + 1;

                    Pk = Pk + 2 * x + 1;

                }
                else
                {
                    y = y - 1;
                    x = x + 1;
                    Pk = Pk + 2 * (x - y) + 1;

                }
                pointCircleMidpoint.Rows.Add(new object[] { i++, Pk, x+xcint, -y+ycint });
                //bit.SetPixel(x + xcint, y + ycint, Color.Blue);//;
                //bit.SetPixel(-x + xcint, y + ycint, Color.Blue);//;
                bit.SetPixel(x + xcint, -y + ycint, Color.Blue);//;
                //bit.SetPixel(-x + xcint, -y + ycint, Color.Blue);//;
                //bit.SetPixel(y + xcint, x + ycint, Color.Blue);//
                //bit.SetPixel(y + xcint, -x + ycint, Color.Blue);//
                //bit.SetPixel(-y + xcint, x + ycint, Color.Blue);//
                //bit.SetPixel(-y + xcint, -x + ycint, Color.Blue);//

            }
            picture_midpoint.Image = bit;
        }
        private void btn_midpoint_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(txt_radius.Text);
            int Xc = int.Parse(txt_xcen.Text);
            int Yc = int.Parse(txt_ycen.Text);
            midPoint(Xc, Yc, radius);
        }
        public void BresenhamCircle(int bresxcint, int bresycint, int bresradius)
        {
            int x = 0, y = bresradius;
            double Pk = 3 - 2*bresradius;
            Bitmap bit = new Bitmap((picture_BresenhamCircle.Width) / 2, (picture_BresenhamCircle.Height) / 2);
            int i = 1;
            while (x <= y)
            {
                if (Pk < 0)
                {
                    x = x + 1;

                    Pk = Pk + 4 * x + 6;

                }
                else
                {
                    y = y - 1;
                    x = x + 1;
                    Pk = Pk + 4 * (x - y) + 10;

                }
                pointBresenhamCircle.Rows.Add(new object[] { i++, Pk,x,y });
                bit.SetPixel(x + bresxcint, y + bresycint, Color.Blue);
                bit.SetPixel(-x + bresxcint, y + bresycint, Color.Blue);
                bit.SetPixel(y + bresxcint, -x + bresycint, Color.Blue);
                bit.SetPixel(x + bresxcint, -y + bresycint, Color.Blue);
                bit.SetPixel(-y + bresxcint, x + bresycint, Color.Blue);
                bit.SetPixel(-x + bresxcint, -y + bresycint, Color.Blue);
                bit.SetPixel(y + bresxcint, x + bresycint, Color.Blue);
                bit.SetPixel(-y + bresxcint, -x + bresycint, Color.Blue);

            }
            picture_BresenhamCircle.Image = bit;
        }

        private void btn_bresenhamCircle_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(txt_bresenhamRadius.Text);
            int Xc = int.Parse(txt_bresenhamXc.Text);
            int Yc = int.Parse(txt_bresenhamYc.Text);
            BresenhamCircle(Xc, Yc, radius);
        }
        public void translateCircle(int a, int xc, int yc, int radius,int tx,int ty)
        {
            xc += tx;
            yc += tx;
            if (a == 1)
            {
                midPoint(xc, yc, radius);
            }
            else
                BresenhamCircle(xc, yc, radius);

        }
        private void btn_translate_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(txt_radius.Text);
            int Xc = int.Parse(txt_xcen.Text);
            int Yc = int.Parse(txt_ycen.Text);
            int tx = int.Parse(txt_Tx_Sx.Text);
            int ty = int.Parse(txt_bresenhamCircle_Tx_Sx.Text);
            translateCircle(1,Xc, Yc, radius,tx,ty);
        }
        public void ScaleCircle(int a, int xc, int yc, int radius, int sx, int sy)
        {
            xc *= sx;
            yc*= sy;

            if (a == 1)
            {
                midPoint(xc, yc, radius);

            }
            else
                BresenhamCircle(xc, yc, radius);

        }
        private void btn_scale_Click(object sender, EventArgs e)
        {


            int radius = int.Parse(txt_radius.Text);
            int Xc = int.Parse(txt_xcen.Text);
            int Yc = int.Parse(txt_ycen.Text);
            int tx = int.Parse(txt_Tx_Sx.Text);
            int ty = int.Parse(txt_bresenhamCircle_Tx_Sx.Text);
            ScaleCircle(1, Xc, Yc, radius, tx, ty);
        }
        public void ReflectCircle(int a, int xc, int yc, int radius)
        {
            int temp;
            temp = xc;
            xc = yc;
            yc = temp;

           
            if (a == 1)
            {
                midPoint(xc, yc,radius);
            }
            else if (a == 2)
            {
                BresenhamCircle(xc, yc,radius);
            }

        }
        private void btn_reflect_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(txt_radius.Text);
            int Xc = int.Parse(txt_xcen.Text);
            int Yc = int.Parse(txt_ycen.Text);
            ReflectCircle(1,Xc, Yc, radius);
        }
        private void btn_bresnTransCircle_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(txt_bresenhamRadius.Text);
            int Xc = int.Parse(txt_bresenhamXc.Text);
            int Yc = int.Parse(txt_bresenhamYc.Text);
            int tx = int.Parse(txt_bresenhamCircle_Tx_Sx.Text);
            int ty = int.Parse(txt_bresenhamCircle_Tx_Sx.Text);
            translateCircle(2, Xc, Yc, radius, tx, ty);
        }
        private void btn_BresenScaleCircle_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(txt_bresenhamRadius.Text);
            int Xc = int.Parse(txt_bresenhamXc.Text);
            int Yc = int.Parse(txt_bresenhamYc.Text);
            int tx = int.Parse(txt_bresenhamCircle_Tx_Sx.Text);
            int ty = int.Parse(txt_bresenhamCircle_Tx_Sx.Text);
            ScaleCircle(2, Xc, Yc, radius, tx, ty);
        }
        private void btn_BresenReflectCircle_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(txt_bresenhamRadius.Text);
            int Xc = int.Parse(txt_bresenhamXc.Text);
            int Yc = int.Parse(txt_bresenhamYc.Text);
            ReflectCircle(2, Xc, Yc, radius);
        }

        private void btn_backCircle_Click(object sender, EventArgs e)
        {
            Frm_Home frmback2 = new Frm_Home();
            frmback2.Show();
            this.Close();
        }

    }
}
