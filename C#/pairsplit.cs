using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;

public class SplitString
{
  public static string[] Solution(string str)
  {
    List<char> lstCHARS = str.ToCharArray().ToList();
    List<string> lstSUBSTR = new List<string>();
    Regex findPAIRS = new Regex(@".{2}");
    
    // adding an underscore to pad the last pair of characters
    if( lstCHARS.Count % 2 > 0 ) {
      lstCHARS.Add('_');
      str = String.Join("", lstCHARS);
    }
    
    // split string into pairs
    foreach (Match match in findPAIRS.Matches(str)) { lstSUBSTR.Add(match.Value); }
    return lstSUBSTR.ToArray();
  }
}
