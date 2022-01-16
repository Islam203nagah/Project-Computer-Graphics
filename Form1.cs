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
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            Line_Draw line = new Line_Draw();
            line.Show();
            this.Hide();
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            Circle_Draw Circle = new Circle_Draw();
            Circle.Show();
           this.Hide();
        }
        private void btn_Ellips_Click(object sender, EventArgs e)
        {
            Ellips_Draw Ellips = new Ellips_Draw();
            Ellips.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
