using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OUR_LogicSimulator
{
    public class AND : Gate
    {
        public AND()
        { 
        }

        public AND(TextBox Input1, TextBox Input2, TextBox Out)
        {
            Input[0] = Input1;
            Input[1] = Input2;
            Output = Out;

        }


        public override void calculate()
        {

            int x = Convert.ToInt32(Input[0].Text);
            int y = Convert.ToInt32(Input[1].Text);

            if (x == 1 && y == 1)
            {
                Output.Text = "1";
            }
            else
            {
                Output.Text = "0";
            }
        }
    }
}
