using System.Collections.Generic;
using System.Linq;
using System;
public class LongestConsecutives 
{
  public static string LongestConsec(string[] strarr, int k) 
  {
    List<string> lstCONSEC = new List<string>();

    // handle impossible cases
    if (strarr.Length == 0 || k > strarr.Length || k <= 0) { return ""; }
    else {
      // iterate through each element, saving space for the k lookahead length
      for (int index = 0; index < (strarr.Length - (k - 1)); index++) {
        string consecstr = "";
        for (int num = index; num < index+k; num++) { consecstr += strarr[num]; }
        lstCONSEC.Add(consecstr);
      }
      
      // use aggregate to iterate through the list of consecutive strings, returning
      // the FIRST string that has the highest length value, disregarding all others
      return lstCONSEC.Aggregate("", (max, cur) => max.Length >= cur.Length ? max : cur);
    }
  }
}
