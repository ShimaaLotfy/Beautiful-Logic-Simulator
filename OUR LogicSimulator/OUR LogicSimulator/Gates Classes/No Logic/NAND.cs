using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace OUR_LogicSimulator
{
    class NAND : Gate
    {
        public NAND()
        { 
        }

        #region Dealing With Integers

        public NAND(TextBox Input1, TextBox Input2, TextBox Out)
        {
            Input[0] = Input1;
            Input[1] = Input2;
            Output = Out;

        }
         public override void calculateInt()
         {
            TextBox tempOut = new TextBox();
             AND and = new AND(Input[0], Input[1], tempOut);
             NOT not = new NOT(Output, Output);
         }
        #endregion
    }

}
