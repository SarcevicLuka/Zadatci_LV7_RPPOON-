using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_i_drugi_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 5.78, 9.23, 4.5, 7.05, 13.96, 5.78, 1.02, 10.28, 19.67, 3.65 };

            //Prvi zadatak
            NumberSequence numberSequenceSequential = new NumberSequence(array);
            NumberSequence numberSequenceBubble = new NumberSequence(array);
            NumberSequence numberSequenceComb = new NumberSequence(array);
            SequentialSort sequentialSort = new SequentialSort();
            BubbleSort bubbleSort = new BubbleSort();
            CombSort combSort = new CombSort();

            numberSequenceSequential.SetSortStrategy(sequentialSort);
            numberSequenceSequential.Sort();
            Console.WriteLine("Sequential sort: \n" + numberSequenceSequential.ToString());

            numberSequenceBubble.SetSortStrategy(bubbleSort);
            numberSequenceBubble.Sort();
            Console.WriteLine("Bubble sort: \n" + numberSequenceBubble.ToString());

            numberSequenceComb.SetSortStrategy(combSort);
            numberSequenceComb.Sort();
            Console.WriteLine("Comb sort: \n" + numberSequenceComb.ToString());


            // Drugi zadatak
            double numberToSearch = 5.78;
            LinearSearch linearSearch = new LinearSearch();
            NumberSequence numberSequenceLinear = new NumberSequence(array);
            numberSequenceLinear.SetSearchStrategy(linearSearch);
            double isFound = numberSequenceLinear.Search(numberToSearch);
            if (isFound == 1)
                Console.WriteLine("Broj " + numberToSearch + " je nađen.");
            else
                Console.WriteLine("Broj " + numberToSearch + " nije nađen.");
        }
    }
}
