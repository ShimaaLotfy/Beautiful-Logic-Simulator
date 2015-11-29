using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator
{
    class XOR : Gate
    {
        public XOR()
        { 
        }

        public XOR(TextBox Input1, TextBox Input2, TextBox Out)
        {
            Input[0] = Input1;
            Input[1] = Input1;
            Output = Out;
        }
        
        public override void calculate()
        {
           int x = Convert.ToInt32(Input[0].Text);
           int y = Convert.ToInt32(Input[1].Text);

           Output.Text = (x ^ y).ToString();

        }
    }
}
