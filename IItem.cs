using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peti_šesti_i_sedmi_zadatci
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
