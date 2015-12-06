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
       public Gate()
        {

        }
        public virtual void calculateOutput()
        {
        }
        public virtual void validate()
        {
        }

        #region Dealing With Integers

        //protected List <TextBox> Input = new List <TextBox>();
        protected TextBox[] Input = new TextBox[2];
        protected TextBox Output;

        public virtual void calculateInt()
        { 
        }
        
        public virtual void validateInt()
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
                calculateInt();
            }

        }

        //Menna 
        //Edit the code to point to reference of Textbox
        public void SetTextBoxIp1(TextBox Input1)
        {
            Input[0] = Input1;

        }

        public void SetTextBoxIp2(TextBox Input2)
        {
            Input[1] = Input2;

        }

        public void SetTextBoxOp(TextBox Out)
        {
            Output = Out;

        }
        #endregion


    }

   

}


    
 
       