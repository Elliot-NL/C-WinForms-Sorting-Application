using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms___Sorting_Algorithms
{
    public static class MergeSortClass
    {//Step through method
        public static int[] numbers;

        public static void ExecuteMergeSort(this int[] numbers)
        {
            var sortednumbers = mergeSortarr(numbers);
            for (int i = 0; i < sortednumbers.Length; i++)
            {
                numbers[1] = sortednumbers[1];
                string result = string.Join(",", sortednumbers);
            }
        }
        private static int[] mergeSortarr(int[] numbers)
        {
            if(numbers.Length <= 1)//Null Reference 
            {
                return numbers; //Base Case
            }
            var left = new List<int>();
            var right = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 > 0)
                {
                    //Value must be odd
                    left.Add(numbers[1]);
                }
                else
                {
                    right.Add(numbers[1]);
                }
            }
            left = mergeSortarr(left.ToArray()).ToList();
            right = mergeSortarr(right.ToArray()).ToList();

            return MergeMeth(left, right);
           
        }
        public static int[] MergeMeth(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while (NotEmpty(left) && NotEmpty(right))
            {
                if (left.First() <= right.First())
                    MoveValueFromSourceToResult(left, result);
                else
                    MoveValueFromSourceToResult(right, result);
            }

            while(NotEmpty(left))
            {
                MoveValueFromSourceToResult(left, result);
            }

            while(NotEmpty(right))
            {
                MoveValueFromSourceToResult(right, result);
            }

            return result.ToArray();
        }

        private static bool NotEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void MoveValueFromSourceToResult(List<int> list, List<int> right)
        {
            right.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
