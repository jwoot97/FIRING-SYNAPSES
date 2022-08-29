using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Solution
{
  class Kata
  {
    public static bool IsValidIp(string ipAddres)
    {
      int intVAL = 0;
      // check for empty string
      if (ipAddres == "") {
        return false;
      }
      else {
        // capture all non-period components of the ip string and run through gauntlet
        List<string> lstIPCOMP = (from Match m in Regex.Matches(ipAddres, @"[^\.]{1,}") select m.Value).ToList();
        foreach (string comp in lstIPCOMP) {
          bool isINT = int.TryParse(comp, out intVAL);
          if (isINT == false || lstIPCOMP.Count != 4 || comp.Length != intVAL.ToString().Length || intVAL > 255 || intVAL < 0 ) { return false; }
        }
        return true;
      }
    }
  }
}
