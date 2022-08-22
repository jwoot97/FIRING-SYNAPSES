using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string UInt32ToIP(uint ip)
  {
    Console.WriteLine("IP: " + ip);
    if (ip != 0) {
      string binarystring = Convert.ToString(ip, 2);
      // ensure string is has a length of 24, and add leading zeroes
      if (binarystring.Length != 32) {
        binarystring = binarystring.PadLeft(binarystring.Length + (32 - binarystring.Length), '0');
      }
      
      // binary -> integer
      List<string> lstBYTES = (from Match m in Regex.Matches(binarystring, @"\d{8}") select m.Value).ToList();
      List<int> lstBYTVAL = new List<int>();
      foreach (string byt in lstBYTES) {
        lstBYTVAL.Add(Convert.ToInt32(byt, 2));
      }
      return String.Join(".", lstBYTVAL.ToArray());
    } else { return "0.0.0.0"; }
  }
}
