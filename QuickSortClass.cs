using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms___Sorting_Algorithms
{
    public static class QuickSortClass
    {
        public static int piv;
        public static List<int> QuickList = new List<int>();

        public static void QSort(this List<int> QuickList)
        {
            foreach(int items in QuickList)
            {
                int total = QuickList.Sum();
                int length = QuickList.Count;
                piv = total /= length;
            }
            for(int i = 0; i < QuickList.Count; i++)
            {
                QuickList.Sort(); //Not QuickSort
                string result = string.Join(",", QuickList);
                //Output not implemented here
            }
        }
    }
}
