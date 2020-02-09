using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class SortingMethod
    {

        public void InsertionSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int current = A[i];
                int j = i;

                while (j > 0 && A[j-1] > current)
                {
                    A[j] = A[j - 1];
                    j--;
                }
                A[j] = current;
            }
        }

        public void SelectionSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int min = A[i];
                int c = i;

                for (int j = i+1; j < A.Length; j++)
                {
                    if (A[j] < min)
                    {
                        min = A[j];
                        c = j;
                    }
                }
                int aux = A[i];
                A[i] = min;
                A[c] = aux;
            }
        }

    }
}
