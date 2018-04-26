using System;

namespace SortingAlg
{
  public class SortingAlg
  {
    public int[] SortArray(int[] UnsortedArray)
    {
      for (int i = 0; i < UnsortedArray.Length-1; i++)
      {
        for (int j = 1; j < UnsortedArray.Length; j++)
        {
          if (UnsortedArray[j] < UnsortedArray[j-1])
          {
            int LargerValue = UnsortedArray[j-1];
            UnsortedArray[j-1] = UnsortedArray[j];
            UnsortedArray[j] = LargerValue;
          } else {
            continue;
          }
        }

      }

      foreach(var output in UnsortedArray)
      {
          Console.WriteLine(output.ToString());
      }
      Console.WriteLine("=====================");

      return UnsortedArray;
    }


  // End of Class
 }
}
