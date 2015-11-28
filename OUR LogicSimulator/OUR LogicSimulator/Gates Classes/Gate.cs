using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; // i included that !!


namespace OUR_LogicSimulator
{
   public class Gate
    {
       
       //protected List <TextBox> Input = new List <TextBox>();
        protected TextBox[] Input = new TextBox[2];
        protected TextBox Output;

        public virtual void calculate()
        { 
        }

        public void validate()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i].Text != "" && Input[i].Text != null )
                {
                    calculate();
                }
                else if (Input[i].Text == "" || Input[i].Text == null )
                {
                    MessageBox.Show("Please Fill In All The Inputs");
                }
            }

        }

        public void SetIp1(TextBox Input1)
        {
            Input[0] = Input1;

        }

        public void SetIp2(TextBox Input2)
        {
            Input[1] = Input2;

        }

        public void SetOp(TextBox Out)
        {
            Output = Out;

        }
       
    }

   

}


    
 
       