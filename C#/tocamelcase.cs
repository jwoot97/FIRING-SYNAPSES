using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    List<string> lstSTRING = new List<string>();
    // determine what delimiter is being used
    foreach (string word in (str.Split(new char [] { '-', '_' }))) {
      if (!(lstSTRING.Contains(word))) { lstSTRING.Add(word); }
    }
    
    // rebuild str with proper capitalization
    str = "";
    foreach (string word in lstSTRING) {
      if (word != "" && !(char.IsUpper(word, 0)) && lstSTRING.FindIndex(a => a.Contains(word)) == 0) { str = word; }
      else if (word != "") { str += (char.ToUpper(word[0]) + word.Substring(1)); }
    }
    return str;
  }
}
