using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlg;
//[37,15,2,4,9,1,2,0,3,7,12,19,29,24,22,5,21,19,0,34,16,3]
namespace SortingAlg.Tests
{
  [TestClass]
  public class SortingAlgTest
  {
    [TestMethod]
    public void SortTwoElements_True()
    {
      int[] expectedArray = new int[] {1,7};
      int[] UnsortedArray = new int[] {7,1};
      SortingAlg testSortingAlg = new SortingAlg();
      CollectionAssert.AreEqual(expectedArray, testSortingAlg.SortArray(UnsortedArray));
    }
    [TestMethod]
    public void SortThreeElements_True()
    {
      int[] expectedArray = new int[] {1,3,7};
      int[] UnsortedArray = new int[] {7,3,1};
      SortingAlg testSortingAlg = new SortingAlg();
      CollectionAssert.AreEqual(expectedArray, testSortingAlg.SortArray(UnsortedArray));
    }
    [TestMethod]
    public void SortFiveElements_True()
    {
      int[] expectedArray = new int[] {1,4,5,6,7};
      int[] UnsortedArray = new int[] {7,6,5,4,1};
      SortingAlg testSortingAlg = new SortingAlg();
      CollectionAssert.AreEqual(expectedArray, testSortingAlg.SortArray(UnsortedArray));
    }
    [TestMethod]
    public void SortManyElements_True()
    {
      int[] expectedArray = new int[] {0,1,2,2,3,4,5,7,9,12,15,16,19,19,21,22,24,29,34,37};
      int[] UnsortedArray = new int[] {37,15,2,4,9,1,2,3,7,12,19,29,24,22,5,21,19,0,34,16};
      SortingAlg testSortingAlg = new SortingAlg();
      CollectionAssert.AreEqual(expectedArray, testSortingAlg.SortArray(UnsortedArray));
    }

  }
}
