using System.Collections.Generic;
using System.Linq;
using System;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    // initialize list to return, build char array from word input, and sort characters alphabetically
    List<string> lstANAGRAMS = new List<string>();
    char[] wordCHARS = word.ToCharArray();
    Array.Sort(wordCHARS);
    
    // determine which elements to return
    foreach ( string element in words ) {
      char[] elementCHARS = element.ToCharArray();
      Array.Sort(elementCHARS);
      if (elementCHARS.SequenceEqual(wordCHARS) ) { lstANAGRAMS.Add( element ); }
    }
    return lstANAGRAMS;
  }
}
