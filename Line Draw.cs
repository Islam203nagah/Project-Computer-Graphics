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
    public partial class Line_Draw : Form
    {
        public Line_Draw()
        {
            InitializeComponent();
        }
        const byte inside = 0; // 0000
        const byte left = 1;   // 0001
        const byte right = 2;  // 0010
        const byte bottom = 4; // 0100
        const byte top = 8;    // 1000

        public int computeCode(double x, double y, int x_min, int y_min, int x_max, int y_max)
        {

            int code = 0;

            if (x < x_min)       
                code |= left;
            else if (x > x_max)  
                code |= right;
            if (y < y_min)        
                code |= bottom;
            else if (y > y_max)  
                code |= top;

            return code;
        }


        double x, y;
        public void cohenSutherlandClip(double x11, double y11, double x2, double y2, int x_min, int y_min, int x_max, int y_max)
        {


            int code1 = computeCode(x11, y11, x_min, y_min, x_max, y_max);
            int code2 = computeCode(x2, y2, x_min, y_min, x_max, y_max);


            bool accept = true;

            while (true)
            {


                int outcode0 = code1;
                int outcode1 = code2;


                if ((outcode0 | outcode1) == 0)
                {
                    accept = true;
                    break;
                }

                else if ((outcode0 & outcode1) == 0)
                {


                    double xi = 0, yi = 0;
                    int codein = 0;
                    if (outcode0 != 0)
                    {
                        codein = outcode0;
                        xi = x11;
                        yi = y11;
                    }
                    else if (outcode1 != 0)
                    {
                        codein = outcode1;
                        xi = x2;
                        yi = y2;
                    }

                    if (codein == top)
                    {
                        x = x11 + (x2 - x11) * (y_max - y11) / (y2 - y11);
                        y = y_max;
                        //MessageBox.Show(x.ToString() + "t" + y.ToString());
                    }
                    else if (codein == bottom)
                    {
                        x = x11 + (x2 - x11) * (y_min - y11) / (y2 - y11);
                        y = y_min;
                        //MessageBox.Show(x.ToString() + "b" + y.ToString());
                    }
                    else if (codein == right)
                    {
                        y = y11 + (y2 - y11) * (x_max - x11) / (x2 - x11);
                        x = x_max;
                       // MessageBox.Show(x.ToString() + "r" + y.ToString());
                    }
                    else if (codein == left)
                    {
                        y = y11 + (y2 - y11) * (x_min - x11) / (x2 - x11);
                        x = x_min;
                       // MessageBox.Show(x.ToString() + "left" + y.ToString());
                    }
                    int q = (int)Math.Round(x);
                    int w = (int)Math.Round(y);

                    if (codein == outcode0)
                    {
                        x11 = x;
                        y11 = y;
                        code1 = computeCode(x11, y11, x_min, y_min, x_max, y_max);


                    }
                    else
                    {
                        x2 = x;
                        y2 = y;
                        code2 = computeCode(x2, y2, x_min, y_min, x_max, y_max);

                    }
                }
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("the line is out", "attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (d == DialogResult.OK)
                    {
                        accept = false;
                        Close();
                    }
                    break;
                }


            }


            if (accept)
            {
                DDA((int)x11, (int)y11, (int)x2, (int)y2);
            }
        }
        //public void DDA2(int x1, int y1, int x2, int y2,int x_min,int y_min,int x_max,int y_max)
        //{
        //    Bitmap p = new Bitmap(picture_DDA.Width, picture_DDA.Height);
        //    int dx = x2 - x1;
        //    int dy = y2 - y1;
        //    int Steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

        //    float xincreasment = Math.Abs(dx) / (float)Steps;
        //    float yincreasment = Math.Abs(dy) / (float)Steps;

        //    float x = x1;
        //    float y = y1;

        //    for (int i = 0; i < Steps; i++)
        //    {
        //        if (x1 > x_min && x1 < x_max && y1 > y_min && y1 < y_max)
        //        {
        //            p.SetPixel(Math.Abs((int)x), Math.Abs((int)y), Color.Red);

        //            x += xincreasment;
        //            y += yincreasment;
        //        }
        //        else
        //        {
        //            x += xincreasment;
        //            y += yincreasment;
        //        }
        //        pointdda.Rows.Add(new object[] { i + 1, x, y, (int)x, (int)y });
        //    }

        //    picture_DDA.Image = p;
        //}


        public void DDA(int x1, int y1, int x2, int y2)
        {
            Bitmap p = new Bitmap(picture_DDA.Width, picture_DDA.Height);

            int dx = x2 - x1;
            int dy = y2 - y1;
            int Steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xincreasment =Math.Abs( dx) / (float)Steps;
            float yincreasment = Math.Abs(dy) / (float)Steps;

            float x = x1;
            float y = y1;

            for (int i = 0; i < Steps; i++)
            {
                p.SetPixel(Math.Abs((int)x),Math.Abs( (int)y), Color.Red);

                x += xincreasment;
                y += yincreasment;


                pointdda.Rows.Add(new object[]{i+1,x,y,(int)x,(int)y});
            }

            picture_DDA.Image = p;
        }

        private void btn_DDA_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(txt_X1.Text);
            int y1 = int.Parse(txt_Y1.Text);
            int x2 = int.Parse(txt_X2.Text);
            int y2 = int.Parse(txt_Y2.Text);
            DDA(x1, y1, x2, y2);
        }
        public void Bresenham(int x1,int x2,int y1, int y2)
        {

            int dx, dy;
            dx = x2 - x1;
            dy = y2 - y1;
            int p0 = 2 * dy - dx;
            Bitmap bit = new Bitmap(picture_Bresnham.Width , picture_Bresnham.Height );
            bit.SetPixel(x1, y1, Color.Red);
            for (int i = 0; i <Math.Abs( dx); i++)
            {
                if (p0 < 0)
                {
                    x1++;
                    y1 = y1;
                    p0 = p0 + 2 * dy;
                    bit.SetPixel(Math.Abs(x1),Math.Abs( y1), Color.Red);

                    pointham.Rows.Add(new object[] { i + 1, p0,Math.Abs( x1),Math.Abs( y1) });
                }
                else
                {
                    x1++;
                    y1++;
                    p0 = p0 + 2 * dy - 2 * dx;
                    bit.SetPixel(Math.Abs( x1),Math.Abs( y1), Color.Red);
                    pointham.Rows.Add(new object[] { i + 1, p0,Math.Abs( x1),Math.Abs( y1) });
                }

            }
            picture_Bresnham.Image = bit;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int x0, y0, x1, y1;
            x0 = int.Parse(txt_xb1.Text);
            y0 = int.Parse(txt_yb1.Text);
            x1 = int.Parse(txt_xb2.Text);
            y1 = int.Parse(txt_yb2.Text);
            Bresenham(x0, x1,y0 ,y1);

        }
        public void translate(int a,int x1, int y1, int x2, int y2, int tx, int ty)
        {
            x1 = x1 + tx;
            x2 = x2 + tx;
            y1 = y1 + ty;
            y2 = y2 + ty;
            if (a == 1)
            {
                DDA(x1, y1, x2, y2);
            }
            else
                Bresenham(x1, x2,y1, y2);

        }

        private void btn_translate_Click(object sender, EventArgs e)
        {
            int x0, y0, x1, y1,tx,ty;
            x0 = int.Parse(txt_X1.Text);
            y0 = int.Parse(txt_Y1.Text);
            x1 = int.Parse(txt_X2.Text);
            y1 = int.Parse(txt_Y2.Text);
            tx = int.Parse(txt_Tx_Sx_Theta.Text);
            ty = int.Parse(txt_Ty_Sy.Text);
            translate(1,x0, y0, x1, y1, tx, ty);

        }
        public void Scale(int a,int x1, int y1, int x2, int y2, int sx, int sy)
        {
            x1 = x1 * sx;
            x2 = x2 * sx;
            y1 = y1 * sy;
            y2 = y2 * sy;
            if(a==1)
            {
                DDA(x1, y1, x2, y2);

            }
           else
                Bresenham(x1, x2, y1, y2);

        }
        private void btn_scale_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(txt_X1.Text);
            int y0 = int.Parse(txt_Y1.Text);
            int x1 = int.Parse(txt_X2.Text);
            int y1 = int.Parse(txt_Y2.Text);
            int sx = int.Parse(txt_Tx_Sx_Theta.Text);
            int sy = int.Parse(txt_Ty_Sy.Text);
            Scale(1,x0, y0, x1, y1, sx, sy);
        }
        public void Rotate(int a,int x1, int y1, int x2, int y2, double angle)
        {
            double theta= angle/*  * (Math.PI / 180)*/;
            //x1 = (int)((x1 * Math.Cos(theta)) - (y1 * Math.Sin(theta)));
            x2 = (int)(x2 * Math.Cos(theta) - y2 * Math.Sin(theta));
            //y1 = (int)(x1 * Math.Sin(theta) + y1 * Math.Cos(theta));
            y2 = (int)(x2 * Math.Sin(theta) + y2 * Math.Cos(theta));
            if(a==1)
            {
                DDA(x1, y1, x2, y2);
            }
            else
                Bresenham(x1,x2, y1, y2);

        }
        private void btn_rotate_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(txt_X1.Text);
            int y0 = int.Parse(txt_Y1.Text);
            int x1 = int.Parse(txt_X2.Text);
            int y1 = int.Parse(txt_Y2.Text);
            double theta = double.Parse(txt_Tx_Sx_Theta.Text);
            Rotate(1,x0,y0,x1,y1,theta);
        }
        public void Reflect(int a,int x1, int y1, int x2, int y2)
        {
            int temp;
            temp = x1;
            x1 = y1;
            y1 = temp;

            temp = x2;
            x2 = y2;
            y2 = temp;
            if (a == 1) {
                DDA(x1, y1, x2, y2);
            }
            else if (a == 2)
            {
                Bresenham(x1, x2, y1, y2);
            }

        }
        private void btn_reflect_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(txt_X1.Text);
            int y0 = int.Parse(txt_Y1.Text);
            int x1 = int.Parse(txt_X2.Text);
            int y1 = int.Parse(txt_Y2.Text);
            
            Reflect(1,x0, y0, x1, y1);
        }
        private void btn_Transbresenham_Click(object sender, EventArgs e)
        {
            int x0, y0, x1, y1, tx, ty;
            x0 = int.Parse(txt_xb1.Text);
            y0 = int.Parse(txt_yb1.Text);
            x1 = int.Parse(txt_xb2.Text);
            y1 = int.Parse(txt_yb2.Text);
            tx = int.Parse(bTx_bSx_bTheta.Text);
            ty = int.Parse(bTy_bSy.Text);
            translate(2, x0, y0, x1, y1, tx, ty);
        }
        private void btn_Scalebresenham_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(txt_xb1.Text);
            int y0 = int.Parse(txt_yb1.Text);
            int x1 = int.Parse(txt_xb2.Text);
            int y1 = int.Parse(txt_yb2.Text);
            int sx = int.Parse(bTx_bSx_bTheta.Text);
            int sy = int.Parse(bTy_bSy.Text);
            Scale(2, x0, y0, x1, y1, sx, sy);
        }
        private void btn_rotatebresenham_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(txt_xb1.Text);
            int y0 = int.Parse(txt_yb1.Text);
            int x1 = int.Parse(txt_xb2.Text);
            int y1 = int.Parse(txt_yb2.Text);
            int theta = int.Parse(bTx_bSx_bTheta.Text);
            Rotate(2, x0, y0, x1, y1, theta);
        }
        private void btn_reflectbresenham_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(txt_xb1.Text);
            int y0 = int.Parse(txt_yb1.Text);
            int x1 = int.Parse(txt_xb2.Text);
            int y1 = int.Parse(txt_yb2.Text);

            Reflect(2, x0, y0, x1, y1);
        }

        private void btn_cliping_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(txt_X1.Text);
            int y1 = int.Parse(txt_Y1.Text);
            int x2 = int.Parse(txt_X2.Text);
            int y2 = int.Parse(txt_Y2.Text);
            int x_min = int.Parse(txt_x_min.Text);
            int y_min = int.Parse(txt_y_min.Text);
            int x_max = int.Parse(txt_x_max.Text);
            int y_max = int.Parse(txt_y_max.Text);
            double m = (y2 - y1) / (x2 - x1);
            cohenSutherlandClip((double)x1, (double)y1, (double)x2, (double)y2, x_min, y_min, x_max, y_max);
            //DDA2(x1, y1, x2, y2, x_min, y_min, x_max, y_max);
        }

        private void btn_backLine_Click(object sender, EventArgs e)
        {
            Frm_Home frmback = new Frm_Home();
            frmback.Show();
            this.Close();
        }


    }
}
