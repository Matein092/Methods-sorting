using System;

namespace model
{
    public class DataGenerator
    {
        public const int TEN_TO_ONE = 10;
        public const int TEN_TO_TWO = 100;
        public const int TEN_TO_THREE = 1000;
        public const int TEN_TO_FOUR = 10000;
        public const int TEN_TO_FIVE = 100000;


        public DataGenerator()
        {

        }


        public int[] GenerateDataRandomly(int size)
        {
            int[] array = new int[size];
            
            var seed = Environment.TickCount;
            var random = new Random(seed);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, (size + 1));
            }

            return array;
        }


        public int[] GenerateDataIncreasingly(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            return array;
        }


        public int[] GenerateDataDecreasingly(int size)
        {
            int[] array = new int[size];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = i;
            }

            return array;
        }
    }
}
