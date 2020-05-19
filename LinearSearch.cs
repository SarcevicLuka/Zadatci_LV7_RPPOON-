using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_i_drugi_zadatak
{
    class LinearSearch : SearchStrategy
    {
        public override double Search(double[] array, double numberToSearch)
        {
            int arrayLength = array.Length;
            for(int i = 0; i < arrayLength - 1; i++)
            {
                if (array[i] == numberToSearch)
                    return 1;
            }
            return 0;
        }
    }
}
