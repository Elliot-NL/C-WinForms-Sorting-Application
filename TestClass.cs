using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms___Sorting_Algorithms
{
    public static class TestClass
    {
        //Testing File
        //Convert Array objects to Lists
        static string result;
        public static List<int> BubbleList = new List<int>();
        public static void BubbleSort2(this List<int> BubbleList)
        {
            int length = BubbleList.Count;
            for(int i = 0; i < length - 1; i++)
            {
                for(int j = 0; j < length - 1 - i; j++)
                {
                    if(BubbleList[j] < BubbleList[j + 1])
                    {
                        int num = BubbleList[j];
                        BubbleList[j] = BubbleList[j + 1];
                        BubbleList[j + 1] = num;

                        //Output not implemented.
                       result = string.Join(",", BubbleList);
                    }
                       //No Effect:
                       //result = string.Join(",", BubbleList);
                }
                       //result = string.Join(",", BubbleList);
            }
        }
    }
}
