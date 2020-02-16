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

            disorganizedArray = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_ONE);
            ascendingArray = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_ONE);
            descendingArray = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_ONE);
        }
        private void SetUpScenary2()
        {
            SetUpScenary0();

            disorganizedArray = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_TWO);
            ascendingArray = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_TWO);
            descendingArray = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_TWO);
        }
        private void SetUpScenary3()
        {
            SetUpScenary0();

            disorganizedArray = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_THREE);
            ascendingArray = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_THREE);
            descendingArray = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_THREE);
        }
        private void SetUpScenary4()
        {
            SetUpScenary0();

            disorganizedArray = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_FOUR);
            ascendingArray = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_FOUR);
            descendingArray = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_FOUR);
        }
        private void SetUpScenary5()
        {
            SetUpScenary0();

            disorganizedArray = DataGenerator.GenerateDataRandomly(DataGenerator.TEN_TO_FIVE);
            ascendingArray = DataGenerator.GenerateDataIncreasingly(DataGenerator.TEN_TO_FIVE);
            descendingArray = DataGenerator.GenerateDataDecreasingly(DataGenerator.TEN_TO_FIVE);
        }
       


        [TestMethod]
        public void InsertionSortTes()
        {
        }

        [TestMethod]
        public void SelectionSortTest()
        {
        }


    }
}
