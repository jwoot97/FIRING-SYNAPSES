using System.Linq;
using System;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    foreach (int item in b) { a = a.Where(element => element != item).ToArray(); }
    return a;
  }
}
