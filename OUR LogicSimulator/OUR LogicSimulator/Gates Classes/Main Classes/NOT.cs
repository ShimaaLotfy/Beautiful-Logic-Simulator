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



        #region Dealing With Integers

        public override void validateInt()
        {
            //if (Input.Length > 1)
            //{
            //    MessageBox.Show("Only One Input is allowed for Not Gate!");
            //}
            //else 
            if (Input[0] == null || Input[0].Text == "" || Input[0].Text == null)
            {
                MessageBox.Show("Please specify an input for the Not Gate :')");
            }
            else
                calculateInt();
        }

        public NOT(TextBox Input1, TextBox Out)
       {
           Input[0] = Input1;
           Output = Out;
       }

       public override void calculateInt()
       {
            if (Input[0].Text == "0")
            {
                Output.Text = "1";
            }
            else if (Input[0].Text == "1")
            {
                Output.Text = "0";
            }

            //Binary
            //byte[] b = Convert.FromBase64String(Input[0].Text);
            //byte[] o = new byte[2];
            //for(int i=0; i<2; i++)
            //{
            //    o[i] =(byte) ~(int)(b[i]);
            //}
            //Output.Text = Convert.ToBase64String(o);

        }
        #endregion
    }
}
