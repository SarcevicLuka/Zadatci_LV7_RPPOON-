using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peti_šesti_i_sedmi_zadatci
{
    class Cart
    {
        private List<IItem> items;

        public Cart()
        {
            this.items = new List<IItem>();
        }
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
        public double Accept(IVisitor visitor)
        {
            double overaalPrice = 0;
            foreach(IItem item in this.items)
            {
                overaalPrice += item.Accept(visitor);
            }
            return overaalPrice;
        }
    }
}
