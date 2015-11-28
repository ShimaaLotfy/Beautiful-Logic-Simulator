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

        or = new OR(Input1 , Input2 , Out);
        nand = new NAND(Input3 , Out , Out2);
        /* or = new OR();
         or.SetIp1(Input1);
         or.SetIp2(Input2);
         or.SetOp(Out);

         nand = new NAND();
         nand.SetIp1(Input3);
         nand.SetIp2(Out);
         nand.SetOp(Out2); */

        }
    OR or;
    NAND nand;

        private void button1_Click(object sender, EventArgs e)
        {
            or.validate();
            nand.validate();

        }

    }
}
