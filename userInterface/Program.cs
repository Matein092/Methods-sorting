using System;
using model;
using System.Diagnostics;

namespace userInterface
{
    public class Program
    {
        private SortingMethod sortingMethod;
        private DataGenerator dataGenerator;

        private Stopwatch sw;

        public Program()
        {
            this.sortingMethod = new SortingMethod();
            this.dataGenerator = new DataGenerator();

            startTest();
        }

        private void startTest()
        {
            testTime_1();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            testTime_2();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            testTime_3();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            testTime_4();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            testTime_5();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");


            Console.ReadLine();
        }

        private void testTime_1()
        {
            this.sw = new Stopwatch();

            int[] random = this.dataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_ONE);
            int[] ascendingly = this.dataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_ONE);
            int[] descending = this.dataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_ONE);

            //Metodos de insercion para la prueba de 10^1
            sw.Start();
            this.sortingMethod.InsertionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "InsertionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "InsertionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "InsertionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            //Metodos de seleccion para la prueba de 10^1
            sw.Start();
            this.sortingMethod.SelectionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "SelectionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "SelectionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "SelectionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();
        }
        private void testTime_2()
        {
            this.sw = new Stopwatch();

            int[] random = this.dataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_TWO);
            int[] ascendingly = this.dataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_TWO);
            int[] descending = this.dataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_TWO);

            //Metodos de insercion para la prueba de 10^2
            sw.Start();
            this.sortingMethod.InsertionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "InsertionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "InsertionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "InsertionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            //Metodos de seleccion para la prueba de 10^2
            sw.Start();
            this.sortingMethod.SelectionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "SelectionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "SelectionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} segundos", "SelectionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();
        }
        private void testTime_3()
        {

        }
        private void testTime_4()
        {

        }
        private void testTime_5()
        {

        }

        static void Main(string[] args)
        {
            Program p = new Program();
        }
    }
}
