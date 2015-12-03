using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gates2;

namespace OUR_LogicSimulator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region Mariam's

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Text = "1";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                this.checkBox8.Text = "1";
            else
                this.checkBox8.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NotGate r = new NotGate();
            r.SetInput(true);
            bool? p = r.GetOutput();

            XorGate x = new XorGate();
            x.SetInput(true);
            x.SetInput(false);
            bool? xO = x.GetOutput();

            AndGate g = new AndGate();
            g.SetInput(true);
            g.SetInput(true);
            g.SetInput(true);
            g.SetInput(false);
            bool? y = g.GetOutput();
            textBox1.Text = Convert.ToString(xO);

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            string msg = "";

            if (checkBox1.Checked == true)
            {
                msg = "And";
            }

            if (checkBox2.Checked == true)
            {
                msg = msg + "   Not";
            }

            if (checkBox3.Checked == true)
            {
                msg = msg + "   Or";
            }
            if (checkBox4.Checked == true)
            {
                msg = msg + "   nand";
            }
            if (checkBox5.Checked == true)
            {
                msg = msg + "   nOr";
            }
            if (checkBox6.Checked == true)
            {
                msg = msg + "   xOr";
            }
            if (checkBox7.Checked == true)
            {
                msg = msg + "   xnOr";
            }


            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected ");
            }
            else
            {
                MessageBox.Show("No checkbox selected");
            }

            checkBox1.ThreeState = true;


        }



        #endregion

    }
}
