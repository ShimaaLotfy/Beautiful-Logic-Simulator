using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOT
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
            

            e.Graphics.DrawLine(Pens.Black, 0, 60, 40, 60);
            e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 80);
            e.Graphics.DrawLine(Pens.Black, 40, 40, 60, 60);
            e.Graphics.DrawLine(Pens.Black, 40, 80, 60, 60);
            e.Graphics.DrawArc(Pens.Black, 60, 55, 10, 10, 0, 360); 
            e.Graphics.DrawLine(Pens.Black, 70, 60, 150, 60);


        }
    }
}
