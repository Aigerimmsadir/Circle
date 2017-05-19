using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }
        static float xc = 150;
        static float yc = 150;
        float a = -100;
        float b = 0;
        float a1 = 101;
        float b1 = 0;
        Pen pen = new Pen(Color.Cyan);

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a <= 100)
            {
                double w = Math.Sqrt(10000 - a * a);
                b = (float)w;
                a++;
                Refresh();

            }
            else 
            {
                if (a1 > -100) { 
                a1--;
                double w = Math.Sqrt(10000 - a1 * a1);


                b = (float)w; Refresh();
                
}
            }
        }
        static float prevx = 50, prevy = 150;
       
        float k, z;
        GraphicsPath gp = new GraphicsPath();
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (a <= 100)
            {
                k = a + 150;
                z = b + 150;
            }
            else
            {
                k = a1 + 150;
                z = -b + 150;
            }


            e.Graphics.DrawLine(pen, 150, 150, k, z);
            gp.AddLine(prevx, prevy, k, z);
            prevx = k;prevy = z;
            e.Graphics.DrawPath(pen, gp);
          
        }
    }
}

