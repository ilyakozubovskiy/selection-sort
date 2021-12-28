using System;

// ReSharper disable InconsistentNaming
#pragma warning disable SA1611

namespace SelectionSort
{
    public static class Sorter
    {
        /// <summary>
        /// Sorts an <paramref name="array"/> with selection sort algorithm.
        /// </summary>
        public static void SelectionSort(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (int startIndex = 0; startIndex < array.Length - 1; startIndex++)
            {
                int minIndex = startIndex;
                for (int currentIndex = startIndex + 1; currentIndex < array.Length; currentIndex++)
                {
                    if (array[currentIndex] < array[minIndex])
                    {
                        minIndex = currentIndex;
                    }
                }

                int tmp = array[minIndex];
                array[minIndex] = array[startIndex];
                array[startIndex] = tmp;
            }
        }

        /// <summary>
        /// Sorts an <paramref name="array"/> with recursive selection sort algorithm.
        /// </summary>
        public static void RecursiveSelectionSort(this int[] array)
        {
            RecursiveSelectionSort(array, 0);
        }

        public static void RecursiveSelectionSort(int[] array, int startIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0 || startIndex == array.Length - 1)
            {
                return;
            }

            int minIndex = startIndex;
            for (int currentIndex = startIndex + 1; currentIndex < array.Length; currentIndex++)
            {
                if (array[currentIndex] < array[minIndex])
                {
                    minIndex = currentIndex;
                }
            }

            int tmp = array[minIndex];
            array[minIndex] = array[startIndex];
            array[startIndex] = tmp;

            RecursiveSelectionSort(array, startIndex + 1);
        }
    }
}
