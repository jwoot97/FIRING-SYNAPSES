using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;

public class CodeWars {
  public static string Encode(string text) {
    
    // initialize variables
    string binarystring = "";
    string bits = "";
    
    // convert unicode string to binary string
    foreach (char c in text) { binarystring += Convert.ToString(c, 2).PadLeft(8, '0'); }
    
    // repeat each bit three times
    foreach (char bit in binarystring) { bits += string.Concat(Enumerable.Repeat(bit, 3)); }
    
    // return result
    return bits;
  }
  public static string Decode(string bits) {
    
    // initialize variables
    string binarystring = "";
    string text = "";
    
    // convert triple-bit string to normal binary string
    List<string> lstTRIPLETS = (from Match m in Regex.Matches(bits, @"\d{3}") select m.Value).ToList();
    foreach (string triplet in lstTRIPLETS) {
      if (triplet.Count(freq => (freq == '1')) > triplet.Count(freq => (freq == '0'))) {
        binarystring += 1;
      } else {
        binarystring += 0;
      }
    }
    
    // convert binary string to unicode string
    List<string> lstBYTES = (from Match m in Regex.Matches(binarystring, @"\d{8}") select m.Value).ToList();
    foreach (string byt in lstBYTES) {
      text += (char)Convert.ToInt32(byt, 2);
    }
    
    // return result
    return text;
  }
}
