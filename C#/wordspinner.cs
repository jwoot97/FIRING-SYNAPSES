using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
      string[] words = sentence.Split(' ');
      foreach (string word in words) {
        int strLENGTH = word.Length;
        int strINDEX = Array.IndexOf(words,  word);
        // Console.WriteLine(word + "\nINDEX: " + strINDEX + "\nLENGTH: " + strLENGTH);
        
        // spin word if it's longer than 5 char long
        if( strLENGTH >= 5 ) {
          char[] strCHARS = word.ToCharArray();
          Array.Reverse( strCHARS );
          string wordREVERSED = new string( strCHARS );
          words[strINDEX] = wordREVERSED;
        }
      }
    return String.Join(" ", words);
  }
}
