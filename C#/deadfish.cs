using System.Collections.Generic;
using System;

public class Deadfish
{
  public static int[] Parse(string data)
  {
    int val = 0;
    List<int> ret = new List<int>();
    
    foreach (char c in data.ToCharArray()) {
      switch(c) {
          case 'i':
            val++;
            break;
          case 'd':
            val--;
            break;
          case 's':
            val = val * val;
            break;
          case 'o':
            ret.Add(val);
            break;
          default:
            break;
      }
    }
    return ret.ToArray();
  }
}
