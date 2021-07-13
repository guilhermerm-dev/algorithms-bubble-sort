using algorithms_bubble_sort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithms_bubble_sort_tests
{
    [TestClass]
    public class BubbleSortTest
    {

        [TestMethod]
        public void ShouldSortArrayWhenSortMethodFromBubbleSortClassIsCalled()
        {
            int[] array = { 10, 2, 3, 8, 9, 5, 4, 6, 7, 1 };
            BubbleSort.Sort(array);
            Assert.AreEqual(array[0], 1);
            Assert.AreEqual(array[array.Length - 1], 10);
        }


        [TestMethod]
        public void ShouldSortArrayWhenSortRecursiveMethodFromBubbleSortClassIsCalled()
        {
            int[] array = { 10, 2, 3, 8, 9, 5, 4, 6, 7, 1 };
            BubbleSort.RecursiveSort(array, array.Length - 1);
            Assert.AreEqual(array[0], 1);
            Assert.AreEqual(array[array.Length - 1], 10);
        }
    }
}