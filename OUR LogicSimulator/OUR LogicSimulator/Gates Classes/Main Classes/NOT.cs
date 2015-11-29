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

        public override void validate()
        {
            if (Input.Length > 1)
            {
                MessageBox.Show("Only One Input is allowed for Not Gate!");
            }
            else if(Input[0]==null || Input[0].Text == ""|| Input[0].Text==null)
            {
                MessageBox.Show("Please specify an input for the Not Gate :')");
            }
        }

        public NOT(TextBox Input1, TextBox Out)
       {
           Input[0] = Input1;
           Output = Out;

       }
       public override void calculate()
       {
           int x = Convert.ToByte(Input[0].Text);
           Output.Text = (~x).ToString();     
       }
    }
}
