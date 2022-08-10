using System;
using System.Collections.Generic;

public class SumDigPower {
    
    public static long[] SumDigPow(long a, long b) 
    {
      List<long> lstRANGE = new List<long>();
      
      // build array of digits in range a..b
      for(int i = (int)a; i < (int)b; i++) {
        
        // split number into digits
        int numtosplit = i;
        List<int> lstDIGITS = new List<int>();
        while(numtosplit > 0) {
          lstDIGITS.Add(numtosplit % 10);
          numtosplit = numtosplit / 10;
        }
        lstDIGITS.Reverse();
        lstDIGITS.ToArray();
        
        // raise to consecutive powers and sum
        int numsum = 0;
        int digitindex = 1;
        foreach (int digit in lstDIGITS) {
          numsum += (int)Math.Pow(digit, digitindex);
          digitindex++;
        }
        
        // check if number's digits equal its value when raised to consecutive powers
        if (i == numsum) {
          lstRANGE.Add(i);
        }
      }
      return lstRANGE.ToArray();
    }
}
