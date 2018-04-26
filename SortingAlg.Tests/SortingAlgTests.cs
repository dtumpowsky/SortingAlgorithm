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
      int[] UnsortedArray = new int[] {7,1};
      SortingAlg testSortingAlg = new SortingAlg();
      Assert.AreEqual(true, testSortingAlg.SortArray(UnsortedArray));
    }
    [TestMethod]
    public void SortThreeElements_True()
    {
      int[] UnsortedArray = new int[] {7,3,1};
      SortingAlg testSortingAlg = new SortingAlg();
      Assert.AreEqual(true, testSortingAlg.SortArray(UnsortedArray));
    }

  }
}
