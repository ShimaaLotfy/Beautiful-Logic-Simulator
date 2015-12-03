using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Form1_Paint);
        }
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
       SolidBrush sb = new SolidBrush(Color.Black);
       
            e.Graphics.DrawLine(Pens.Black, 0, 40, 40, 40);
            e.Graphics.DrawLine(Pens.Black, 0, 80, 40, 80);
            e.Graphics.DrawLine(Pens.Black, 70, 59, 150, 59);
            e.Graphics.DrawLine(Pens.Black, 40, 30, 40, 90);
           g.DrawArc(sb,10,30,60,60,270,180);
        
          
        }
    }
}
