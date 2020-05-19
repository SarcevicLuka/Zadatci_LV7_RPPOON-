using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peti_šesti_i_sedmi_zadatci
{
    class RentVisitor : IVisitor
    {
        private const double DVDTax = 0.18;
        private const double VHSTax = 0.10;
        private const double BookTax = 0.09;
        public double Visit(DVD DVDItem)
        {
            //Šesti zadatak
            //if (DVDItem.Type == DVDType.SOFTWARE)
            //{
            //    return double.NaN;
            //}

            //Sedmi zadatak
            if (DVDItem.Type == DVDType.SOFTWARE)
            {
                return DVDItem.Price * (1 + DVDTax);
            }
            return DVDItem.Price * (0.1 + DVDTax);
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (0.1 + VHSTax);
        }
        public double Visit(Book BookItem)
        {
            return BookItem.Price * (0.1 + BookTax);
        }
    }
}
