// WIP - works for all cases where number isn't bigger than double

namespace Solution
{
  using System.Collections.Generic;
  using System.Numerics;
  using System.Linq;
  using System;
  
  class LastDigit
  {
    public static int GetLastDigit(BigInteger n1, BigInteger n2)
    {
      // get the last digit of each of the parameters
      double n1_lastdigit = (double)n1 % 10;
      double n2_lastdigit = (double)n2 % 10;
      
      // calculate the constant of variation (k)
      double k = n2_lastdigit / n1_lastdigit;
      int fourk = 4 * (int)k;
      
      Console.WriteLine("N1 = " + (double)n1 + " N2 = " + (double)n2);
      Console.WriteLine("Last Digit of N1: " + n1_lastdigit + "\nLast Digit of N2: " + n2_lastdigit);
            
      double lastdigit = 0;
      if ((double)n2 == 1) {
        lastdigit = n1_lastdigit;
      }
      
      switch(n1_lastdigit) 
      {
        case 0:
          // for powers of 0, all last digits are 0
          lastdigit = 0;
          break;
        case 1:
          // for powers of 1, all last digits == the coefficient
          lastdigit = n1_lastdigit;
          break;
        case 2:
          // for powers of 2, there is a pattern of 2, 4, 8, 6, repeating, starting at the constant of variation (k)
          lastdigit = (double)Math.Pow(n1_lastdigit, n2_lastdigit + fourk) % 10;
          break;
        case 3:
          // for powers of 3, there is a pattern of 9, 7, 1, 3, repeating, starting at the constant of variation (k)
          lastdigit = (double)Math.Pow(n1_lastdigit, n2_lastdigit + fourk) % 10;
          break;
        case 4:
          // for powers of 4, odd powers [ i.e. 4^3 ] end with 4, even powers [i.e. 4^2 ] end with 6
          if (n2_lastdigit % 2 == 0) { lastdigit = 6; } else { lastdigit = 4; }
          break;
        case 5:
          // for powers of 5, all powers end with 5
          lastdigit = n1_lastdigit;
          break;
        case 6:
          // for powers of 6, all powers end with 6
          lastdigit = n1_lastdigit;
          break;
        case 7:
          // for powers of 7, there is a pattern of 9, 3, 1, 7, repeating, starting at the constant of variation (k)
          lastdigit = (double)Math.Pow(n1_lastdigit, n2_lastdigit + fourk) % 10;
          break;
        case 8:
          // for powers of 8, there is a pattern of 4, 2, 6, 8, repeating, starting at the constant of variation (k)
          lastdigit = Math.Pow(n1_lastdigit, (n2_lastdigit + fourk)) % 10;
          break;
        case 9:
          // for powers of 9, odd powers [ i.e. 9^3 ] end with 9, even powers [i.e. 9^2 ] end with 1
          if (n2_lastdigit % 2 == 0) { lastdigit = 1; } else { lastdigit = 9; }
          break;
        default:
          lastdigit = 0;
          break;
      }
      
      // ensure if power is 0, return 1
      if ((double)n2 == 0) {
        lastdigit = 1;
      }
      
      Console.WriteLine("LAST DIGIT -> [ " + (int)lastdigit + " ]\n");
      return (int)lastdigit;
                                       
    }
  }
}
