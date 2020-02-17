﻿using System;

using model;
using System.Diagnostics;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using modelTest;


namespace userInterface
{
    public class Program
    {
        private SortingMethod sortingMethod;
        private DataGenerator dataGenerator;
        private SortingMethodTest sortingMethodTest;

        private Stopwatch sw;

        public Program()
        {
            this.sortingMethod = new SortingMethod();
            this.dataGenerator = new DataGenerator();
            this.sortingMethodTest = new SortingMethodTest();

            startTest();
        }

        private void startTest()
        {
            Console.WriteLine("-----------------------------------------10^1-----------------------------------------------------------");
            testTime_1();

            Console.WriteLine("------------------------------------------10^2----------------------------------------------------------");
            testTime_2();

            Console.WriteLine("------------------------------------------10^3----------------------------------------------------------");
            testTime_3();
        
            Console.WriteLine("-----------------------------------------10^4----------------------------------------------------------");
            testTime_4();
       
            Console.WriteLine("-----------------------------------------10^5-----------------------------------------------------------");
            testTime_5();

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
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            //Metodos de seleccion para la prueba de 10^1
            sw.Start();
            this.sortingMethod.SelectionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_ONE, sw.Elapsed.TotalMilliseconds);
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
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            //Metodos de seleccion para la prueba de 10^2
            sw.Start();
            this.sortingMethod.SelectionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_TWO, sw.Elapsed.TotalMilliseconds);
            sw.Reset();
        }
        private void testTime_3()
        {

            this.sw = new Stopwatch();

            int[] random = this.dataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_THREE);
            int[] ascendingly = this.dataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_THREE);
            int[] descending = this.dataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_THREE);

            //Metodos de insercion para la prueba de 10^3
            sw.Start();
            this.sortingMethod.InsertionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_THREE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_THREE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_THREE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            //Metodos de seleccion para la prueba de 10^3
            sw.Start();
            this.sortingMethod.SelectionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_THREE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_THREE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_THREE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

        }
        private void testTime_4()
        {
            this.sw = new Stopwatch();

            int[] random = this.dataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_FOUR);
            int[] ascendingly = this.dataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_FOUR);
            int[] descending = this.dataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_FOUR);

            //Metodos de insercion para la prueba de 10^4
            sw.Start();
            this.sortingMethod.InsertionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_FOUR, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_FOUR, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_FOUR, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            //Metodos de seleccion para la prueba de 10^4
            sw.Start();
            this.sortingMethod.SelectionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_FOUR, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_FOUR, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_FOUR, sw.Elapsed.TotalMilliseconds);
            sw.Reset();
        }
        private void testTime_5()
        {
            this.sw = new Stopwatch();

            int[] random = this.dataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_FIVE);
            int[] ascendingly = this.dataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_FIVE);
            int[] descending = this.dataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_FIVE);

            //Metodos de insercion para la prueba de 10^5
            sw.Start();
            this.sortingMethod.InsertionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_FIVE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_FIVE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.InsertionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "InsertionSort", DataGenerator.TEN_TO_FIVE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            //Metodos de seleccion para la prueba de 10^5
            sw.Start();
            this.sortingMethod.SelectionSort(random);
            Console.WriteLine("============================================= \nDatos aleatorios \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_FIVE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(ascendingly);
            Console.WriteLine("============================================= \nDatos ascendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_FIVE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();

            sw.Start();
            this.sortingMethod.SelectionSort(descending);
            Console.WriteLine("============================================= \nDatos descendentemente \nMetodo: {0} \ntamano: {1} datos \ntiempo: {2} milisegundos", "SelectionSort", DataGenerator.TEN_TO_FIVE, sw.Elapsed.TotalMilliseconds);
            sw.Reset();
        }



        static void Main(string[] args)
        {
            Program p = new Program();

            /**

            // I1

            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();

            p.sortingMethodTest.InsertionSortTes();

            timeMeasure.Stop();
            Console.WriteLine($"Tiempo I1: {timeMeasure.Elapsed.TotalMilliseconds} ms");


            // I2

            Stopwatch timeMeasure2 = new Stopwatch();
            timeMeasure2.Start();

            p.sortingMethodTest.InsertionSortTes_2();

            timeMeasure2.Stop();
            Console.WriteLine($"Tiempo I2: {timeMeasure2.Elapsed.TotalMilliseconds} ms");


            // I3

            Stopwatch timeMeasure3 = new Stopwatch();
            timeMeasure3.Start();

            p.sortingMethodTest.InsertionSortTes_3();

            timeMeasure3.Stop();
            Console.WriteLine($"Tiempo I3: {timeMeasure3.Elapsed.TotalMilliseconds} ms");


            // I4

            Stopwatch timeMeasure4 = new Stopwatch();
            timeMeasure4.Start();

            p.sortingMethodTest.InsertionSortTes_4();

            timeMeasure4.Stop();
            Console.WriteLine($"Tiempo I4: {timeMeasure4.Elapsed.TotalMilliseconds} ms");


            // I5

            Stopwatch timeMeasure5 = new Stopwatch();
            timeMeasure5.Start();

            p.sortingMethodTest.InsertionSortTes_5();

            timeMeasure5.Stop();
            Console.WriteLine($"Tiempo I5: {timeMeasure5.Elapsed.TotalMilliseconds} ms");

            **/

        }
    }
}
