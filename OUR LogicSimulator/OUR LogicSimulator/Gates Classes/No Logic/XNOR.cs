using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUR_LogicSimulator.Classes
{
    class XNOR : Gate
    {
        public XNOR()
        { 
        }


        #region Dealing With Integers

        public XNOR(TextBox Input1, TextBox Input2, TextBox Out)
        {
            Input[0] = Input1;
            Input[1] = Input2;
            Output = Out;
        }

        public override void calculateInt()
        {
            XOR xor = new XOR(Input[0], Input[1], Output);
            NOT not = new NOT(Output, Output);
        }

        #endregion
    }
}
