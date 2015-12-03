using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NAND
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
            e.Graphics.DrawLine(Pens.Black, 40, 30, 40, 90);
            
            e.Graphics.DrawArc(Pens.Black,10,30,60,60,270,180);  
             e.Graphics.DrawArc(Pens.Black,70,55,10,10,0,360); 
            e.Graphics.DrawLine(Pens.Black, 80, 60, 150, 60);



        }
    }
}
