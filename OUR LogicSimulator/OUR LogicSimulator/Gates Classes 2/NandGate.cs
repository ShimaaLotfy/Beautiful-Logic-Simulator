using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gates2
{
    public class NandGate : MultiInputGate
    {
        protected override bool CalculateOutput(bool InputOne, bool InputTwo)
        {
            return !(InputOne && InputTwo);
        }
    }
}
