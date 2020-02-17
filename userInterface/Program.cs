using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace userInterface
{
    public class Program
    {
        private SortingMethod sortingMethod;
        private DataGenerator dataGenerator;

        public Program()
        {
            this.sortingMethod = new SortingMethod();
            this.dataGenerator = new DataGenerator();

            startTest();
        }

        private void startTest()
        {
            int[] random = this.dataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_TWO);

            Console.WriteLine("Array desorganizado");
            for (int i = 0; i < random.Length; i++)
            {
                Console.WriteLine("{0} = {1}", (i + 1), random[i]);
            }

            sortingMethod.SelectionSort(random);

            Console.WriteLine("\n \nArray organizado");
            for (int i = 0; i < random.Length; i++)
            {
                Console.WriteLine("{0} = {1}", (i + 1), random[i]);
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
        }
    }
}
