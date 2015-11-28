using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gates2
{
    public class NotGate : Gate
    {
        private bool? Input;
        public void SetInput(bool? Input)
        {
            this.Input = Input;
        }
        public override bool? GetOutput()
        {
            if (Input.HasValue)
                return !Input;
            return null;
        }
        public NotGate()
        {
            Input = null;
        }
    }
}
