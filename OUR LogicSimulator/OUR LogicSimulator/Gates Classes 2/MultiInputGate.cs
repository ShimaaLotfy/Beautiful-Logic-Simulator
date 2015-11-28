using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gates2
{
    public abstract class MultiInputGate : Gate   
    {
        private List<bool?> Inputs;
        public MultiInputGate()
        {
            Inputs = new List<bool?>();
        }
        public void SetInput(bool? Input)
        {
            Inputs.Add(Input);
        }
        public override bool? GetOutput()
        {
            if (Inputs.Count < 2)
            {
                return null; 
            }
            foreach (bool? input in Inputs)
            {
                if (!input.HasValue)
                {
                    return null;
                }
            }
            return CalculateTotalOutput();
        }
        private bool CalculateTotalOutput()
        {
            bool x = Inputs[0].Value;
            for (int i = 1; i < Inputs.Count; i++)
            {
                x = CalculateOutput(x, Inputs[i].Value);
            }
            return x;
        }
        protected abstract bool CalculateOutput(bool inputOne, bool inputTwo);
    }
}

