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

        public virtual void validate()
        {
            bool ThereIsNull = false; 

            //check nulls in the inputs 
            //turn the flag on and break if any Null is found 
            for (int i = 0; i < Input.Length; i++)
            {
                if(Input[i].Text == "" || Input[i].Text == null)
                {
                    ThereIsNull = true;
                    MessageBox.Show("Please Fill In All The Inputs");
                    break;
                }
               
            }

            //calculate if the flag isn't turned on
            if (!ThereIsNull)
            {
                calculate();
            }

        }

        //Menna 
        //Edit the code to point to reference of Textbox
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


    
 
       