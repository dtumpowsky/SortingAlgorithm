using System;

namespace SortingAlg
{
  public class SortingAlg
  {
    public bool SortArray(int[] UnsortedArray)
    {
      for (int i = 0; i < UnsortedArray.Length-1; i++)
      {
        for (int j = 1; j < UnsortedArray.Length; j++)
        {
          if (UnsortedArray[j] < UnsortedArray[i])
          {
            int LargerValue = UnsortedArray[i];
            UnsortedArray[i] = UnsortedArray[j];
            UnsortedArray[j] = LargerValue;
          } else {
            continue;
          }
        }

      }
      Console.WriteLine(UnsortedArray[0]);
      Console.WriteLine(UnsortedArray[1]);
      Console.WriteLine(UnsortedArray[2]);
      return true;
    }


  // End of Class
 }
}
