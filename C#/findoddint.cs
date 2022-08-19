using System.Linq;
using System;

namespace Solution {
  class Kata {
    public static int find_it(int[] seq) {
      foreach (int num in seq) {
        int frequency = seq.Count(x => x == num);
        if ( !(frequency % 2 == 0) ) { return num; }
      }
      return -1;
    }
  }
}
