using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using model;

namespace modelTest
{

    [TestClass]
    public class SortingMethodTest
    {
        private SortingMethod SortingMethod;
        private DataGenerator DataGenerator;

        private int[] disorganized;
        private int[] ascending;
        private int[] descending;

        private int[] disorganizedArray;
        private int[] ascendingArray;
        private int[] descendingArray;

        private void SetUpScenary0()
        {
            this.SortingMethod = new SortingMethod();
            this.DataGenerator = new DataGenerator();
        }
        private void SetUpScenary1()
        {
            SetUpScenary0();

            this.disorganized = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_ONE);
            this.disorganizedArray = this.disorganized;

            this.ascending = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_ONE);
            this.ascendingArray = ascending;

            this.descending = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_ONE);
            this.descendingArray = descending;

            Array.Sort(disorganized);
            Array.Sort(ascending);
            Array.Sort(descending);
        }
        private void SetUpScenary2()
        {
            SetUpScenary0();

            this.disorganized = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_TWO);
            this.disorganizedArray = this.disorganized;

            this.ascending = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_TWO);
            this.ascendingArray = ascending;

            this.descending = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_TWO);
            this.descendingArray = descending;

            Array.Sort(disorganized);
            Array.Sort(ascending);
            Array.Sort(descending);
        }
        private void SetUpScenary3()
        {
            SetUpScenary0();

            this.disorganized = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_THREE);
            this.disorganizedArray = this.disorganized;

            this.ascending = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_THREE);
            this.ascendingArray = ascending;

            this.descending = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_THREE);
            this.descendingArray = descending;

            Array.Sort(disorganized);
            Array.Sort(ascending);
            Array.Sort(descending);
        }
        private void SetUpScenary4()
        {
            SetUpScenary0();

            this.disorganized = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_FOUR);
            this.disorganizedArray = this.disorganized;

            this.ascending = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_FOUR);
            this.ascendingArray = ascending;

            this.descending = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_FOUR);
            this.descendingArray = descending;

            Array.Sort(disorganized);
            Array.Sort(ascending);
            Array.Sort(descending);
        }
        private void SetUpScenary5()
        {
            SetUpScenary0();

            this.disorganized = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_FIVE);
            this.disorganizedArray = this.disorganized;

            this.ascending = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_FIVE);
            this.ascendingArray = ascending;

            this.descending = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_FIVE);
            this.descendingArray = descending;

            Array.Sort(disorganized);
            Array.Sort(ascending);
            Array.Sort(descending);
        }
       

        //Pruebas para insertion y selction sort con un array de tamano 10^1
        [TestMethod]
        public void InsertionSortTes()
        {

            SetUpScenary1();

            this.SortingMethod.InsertionSort(this.disorganizedArray);
            this.SortingMethod.InsertionSort(this.ascendingArray);
            this.SortingMethod.InsertionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_ONE);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_ONE);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_ONE);

            
            for (int i = 0; i < DataGenerator.TEN_TO_ONE; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest()
        {

            SetUpScenary1();

            this.SortingMethod.SelectionSort(this.disorganizedArray);
            this.SortingMethod.SelectionSort(this.ascendingArray);
            this.SortingMethod.SelectionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_ONE);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_ONE);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_ONE);


            for (int i = 0; i < DataGenerator.TEN_TO_ONE; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        //Pruebas para insertion y selction sort con un array de tamano 10^2
        public void InsertionSortTes_2()
        {
            SetUpScenary2();

            this.SortingMethod.InsertionSort(this.disorganizedArray);
            this.SortingMethod.InsertionSort(this.ascendingArray);
            this.SortingMethod.InsertionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_TWO);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_TWO);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_TWO);


            for (int i = 0; i < DataGenerator.TEN_TO_TWO; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest_2()
        {
            SetUpScenary2();

            this.SortingMethod.SelectionSort(this.disorganizedArray);
            this.SortingMethod.SelectionSort(this.ascendingArray);
            this.SortingMethod.SelectionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_TWO);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_TWO);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_TWO);


            for (int i = 0; i < DataGenerator.TEN_TO_TWO; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        //Pruebas para insertion y selction sort con un array de tamano 10^3
        public void InsertionSortTes_3()
        {
            SetUpScenary3();

            this.SortingMethod.InsertionSort(this.disorganizedArray);
            this.SortingMethod.InsertionSort(this.ascendingArray);
            this.SortingMethod.InsertionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_THREE);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_THREE);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_THREE);


            for (int i = 0; i < DataGenerator.TEN_TO_THREE; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest_3()
        {
            SetUpScenary3();

            this.SortingMethod.SelectionSort(this.disorganizedArray);
            this.SortingMethod.SelectionSort(this.ascendingArray);
            this.SortingMethod.SelectionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_THREE);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_THREE);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_THREE);


            for (int i = 0; i < DataGenerator.TEN_TO_THREE; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        //Pruebas para insertion y selction sort con un array de tamano 10^4
        public void InsertionSortTes_4()
        {
            SetUpScenary4();

            this.SortingMethod.InsertionSort(this.disorganizedArray);
            this.SortingMethod.InsertionSort(this.ascendingArray);
            this.SortingMethod.InsertionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_FOUR);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_FOUR);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_FOUR);


            for (int i = 0; i < DataGenerator.TEN_TO_FOUR; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest_4()
        {
            SetUpScenary4();

            this.SortingMethod.SelectionSort(this.disorganizedArray);
            this.SortingMethod.SelectionSort(this.ascendingArray);
            this.SortingMethod.SelectionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_FOUR);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_FOUR);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_FOUR);


            for (int i = 0; i < DataGenerator.TEN_TO_FOUR; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        //Pruebas para insertion y selction sort con un array de tamano 10^4
        public void InsertionSortTes_5()
        {
            SetUpScenary5();

            this.SortingMethod.InsertionSort(this.disorganizedArray);
            this.SortingMethod.InsertionSort(this.ascendingArray);
            this.SortingMethod.InsertionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_FIVE);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_FIVE);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_FIVE);


            for (int i = 0; i < DataGenerator.TEN_TO_FIVE; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }

        [TestMethod]
        public void SelectionSortTest_5()
        {
            SetUpScenary5();

            this.SortingMethod.SelectionSort(this.disorganizedArray);
            this.SortingMethod.SelectionSort(this.ascendingArray);
            this.SortingMethod.SelectionSort(this.descendingArray);

            //Aqui se verifica que en el proceso de ordenamiento el array mantenga su tamano
            Assert.IsTrue(disorganizedArray.Length == DataGenerator.TEN_TO_FIVE);
            Assert.IsTrue(ascendingArray.Length == DataGenerator.TEN_TO_FIVE);
            Assert.IsTrue(descendingArray.Length == DataGenerator.TEN_TO_FIVE);


            for (int i = 0; i < DataGenerator.TEN_TO_FIVE; i++)
            {
                Assert.IsTrue(disorganizedArray[i] == disorganized[i]);
                Assert.IsTrue(ascendingArray[i] == ascending[i]);
                Assert.IsTrue(descendingArray[i] == descending[i]);
            }
        }
    }
}
