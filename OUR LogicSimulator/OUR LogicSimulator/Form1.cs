using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            xor = new XOR(Input3,Out, Out2);
            and1 = new AND(Input1, Input2, Out);
            not1 = new NOT(Input4, Out3);
            
        //nand = new NAND(Input3 , Out , Out2);
        /* or = new OR();
         or.SetIp1(Input1);
         or.SetIp2(Input2);
         or.SetOp(Out);

         nand = new NAND();
         nand.SetIp1(Input3);
         nand.SetIp2(Out);
         nand.SetOp(Out2); */

        }
    AND and1;
        XOR xor;
        NOT not1;
        private void button1_Click(object sender, EventArgs e)
        {
            and1.validate();
            xor.validate();
            not1.validate();

        }

    }
}
