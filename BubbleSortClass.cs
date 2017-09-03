using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms___Sorting_Algorithms
{
    public static class BubbleSortClass
    {
        ///Best suited for sorts of small data
        ///Take user input and segregate into "Bubble"
        ///Compares figures and performs swap
        ///Process follows pass by swapping 
        public static int[] BubbleArr;

        public static int[] BSort(this int[] BubbleArr)
        {
            int length = BubbleArr.Length;//Null Reference
            for(int i = 0; i<length - 1; i++)
            {
                for(int j = 0; j <length - 1 - i; j++)
                {
                    if(BubbleArr[j] < BubbleArr[j + 1])
                    {
                        int num = BubbleArr[j];
                        BubbleArr[j] = BubbleArr[j + 1];
                        BubbleArr[j + 1] = num;
                    }
                }
            }
            return BubbleArr; //Convert to list
            string result = string.Join(",", BubbleArr);
        }
        
    }

}

