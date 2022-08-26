using System.Collections;
using System;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    int[] retARR = new int[arr.Length];
    int ctZERO, index = ctZERO = 0;
    
    // add only non-zero elements to new array
    foreach ( int element in arr ) {
      if ( element == 0 ) { ctZERO++; }
      else { retARR[index] = element; index++; }
    }
    
    // add number of zeroes skipped to the end of the new array
    for (int i = 0; i < ctZERO; i++) { retARR[index] = 0; index++; }
    
    return retARR;
  }
}
