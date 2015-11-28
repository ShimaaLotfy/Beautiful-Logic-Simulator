using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OUR_LogicSimulator
{
   public class NOT : Gate
   {
       public NOT()
       { 
       }

       public NOT(TextBox Input1, TextBox Out)
       {
           Input[0] = Input1;
           Output = Out;

       }
       public override void calculate()
       {
           int x = Convert.ToInt32(Input[0].Text);
           Output.Text = (~x).ToString();     
       }
    }
}
