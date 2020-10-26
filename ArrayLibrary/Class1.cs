using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class Class1
    {
        public static int SumNegativeElements(int[] arrayNumbers)
        {
            int sum = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] < 0)
                    sum += arrayNumbers[i];
            }
            return sum;
        }

        public static int MaxElementArray(int[] arrayNumbers)
        {
            int MaxElementArray = arrayNumbers[0]; // припускаємо, що нульовий елемент є найбільшим числом(максимальним)
            for (int i = 1; i < arrayNumbers.Length; i++) // розпочати пошук максимального числа з елемента під індексом 1(i = 1)
                if (arrayNumbers[i] > MaxElementArray)
                    MaxElementArray = arrayNumbers[i];
            return MaxElementArray;
        }

        public static int IndexMaxElementArray(int[] arrayNumbers)
        {
            int MaxElementArray = arrayNumbers[0]; // припускаємо, що нульовий елемент є найбільшим числом(максимальним)
            int IndexMaxElementArray = 0;
            for (int i = 1; i < arrayNumbers.Length; i++) // розпочати пошук максимального числа з елемента під індексом 1(i = 1)
            {
                if (arrayNumbers[i] > MaxElementArray)
                {
                    MaxElementArray = arrayNumbers[i];
                    IndexMaxElementArray = i;
                }
            }
            return IndexMaxElementArray;
        }

        public static int MaxModuloElementArray(int[] arrayNumbers)
        {
            int MaxModuloElementArray = arrayNumbers[0]; // припускаємо, що нульовий елемент є найбільшим числом по модулю(максимальним)
            for (int i = 1; i < arrayNumbers.Length; i++) // розпочати пошук максимального числа по модулю з елемента під індексом 1(i = 1)
                if (Math.Abs(arrayNumbers[i]) > Math.Abs(MaxModuloElementArray))
                    MaxModuloElementArray = arrayNumbers[i];
            return MaxModuloElementArray;
        }

        public static int SumIndicesPositiveElements(int[] arrayNumbers)
        {
            int sum = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
                if (arrayNumbers[i] > 0)
                    sum += i;
            return sum;
        }

        public static int CountIntegersArray(int[] arrayNumbers)
        {
            int count = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
                if (arrayNumbers[i] - (int)arrayNumbers[i] == 0)
                    count += 1;
            return count;
        }

        public static int[] SortAndReverseArray(int[] arrayNumbers)
        {
            Array.Sort(arrayNumbers);
            Array.Reverse(arrayNumbers);
            return arrayNumbers;
        }

        public static int CountZeroAndPositiveElementsArray(int[] arrayNumbers)
        {
            int count = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
                if (arrayNumbers[i] >= 0)
                    count += 1;
            return count;
        }

        public static int[] RemoveNegativeElementsArray(int[] arrayNumbers)
        {
            int j = 0;
            int[] arrayNumbersWithoutNegativeNumbers = new int[CountZeroAndPositiveElementsArray(arrayNumbers)];
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] >= 0)
                {
                    arrayNumbersWithoutNegativeNumbers[j] = arrayNumbers[i];
                    j += 1;
                }
            }
            return arrayNumbersWithoutNegativeNumbers;
        }
    }
}
