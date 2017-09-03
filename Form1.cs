using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms___Sorting_Algorithms
{
    public partial class Form1 : Form
    {
        //Input Data is stored here:
        //QuickSort Data:
        public List<int> QuickList = new List<int>();
        public int piv;
        //BubbleSort Data:
        public int[] BubbleArr;
        public List<int> BubbleList = new List<int>();
        //MergeSort Data:
        public static int[] numbers;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void BubbleTest()
        {
            //int[] BubbleArr = Input.Text.Split(',').Select(int.Parse).ToArray();
            //BubbleSortClass.BSort(BubbleArr);
            //string result = string.Join(",", BubbleArr);
            //Output.Text = result;

            //Converted to List:

            List<int> BubbleList = Input.Text.Split(',').Select(int.Parse).ToList();
            TestClass.BubbleSort2(BubbleList);
            string result = string.Join(",", BubbleList);
            Output.Text = result;
        }

        public void QuickTest()
        {
            List<int> QuickList = Input.Text.Split(',').Select(int.Parse).ToList();
            QuickSortClass.QSort(QuickList);
            string result = string.Join(",", QuickList);
            Output.Text = result;
        }//Complete

        public void MergeTest()
        {
            int[] numbers = Input.Text.Split(',').Select(int.Parse).ToArray();
            //numbers.ExecuteMergeSort();
            MergeSortClass.ExecuteMergeSort(numbers);
            //Not parsing data
            //MergeSortClass.ExecuteMergeSort(numbers);
            string result = string.Join(",", numbers);
            Output.Text = result;
             
        }
      
        #region MergeSort
        public void MSort()
        {
            //MergeList = Input.Text.Split(',').Select(int.Parse).ToList();
            ////split into sublists:
            //if(MergeList.Count <= 1)
            //{
            //    Output.Text = MergeList.ToString();   
            //}
            //int midPoint = MergeList.Count / 2;
            //for(int i = 0; i < midPoint; i++)
            //{
            //    MergeListLeft.Add(MergeList[i]);
            //}
            //for(int i = midPoint; i < MergeList.Count; i++)
            //{
            //    MergeListRight.Add(MergeList[i]);
            //}

            //Call Class
            

        }
        #endregion
        #region BubbleSort
        public void BSort()
        {

        }
        #endregion
        #region HeapSort
        public void HSort()
        {

        }
        #endregion
        private void button5_Click(object sender, EventArgs e)
        {
            //Clear Fields
            Input.Clear();
            Output.Clear();
        }

        private void QuickSort_Click(object sender, EventArgs e)
        {
            QuickSortClass.QSort(QuickList);
            QuickTest();
        }

        private void MergeSort_Click(object sender, EventArgs e)
        {
            //Null Reference: MergeSortClass.ExecuteMergeSort(numbers);
            //MergeSortClass.ExecuteMergeSort(numbers);
            //Outputs to textbox : TestClass.BubbleSort2(BubbleList);
            MergeTest();
            
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            TestClass.BubbleSort2(BubbleList);//Doesn't apply sort
            BubbleTest();
           
        }

        private void HeapSort_Click(object sender, EventArgs e)
        {
            //Call HeapSort
            //Output.Text = Convert.ToString(StValue);
        }
    }

}


///Converting List Types:
///https://stackoverflow.com/questions/1909268/convert-a-list-of-objects-from-one-type-to-another-using-lambda-expression

