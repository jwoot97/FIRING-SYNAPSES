using System.Collections;
using System;

public class Parentheses
{
  public static bool ValidParentheses(string input)
  {
    Stack stPAR = new Stack();
    
      foreach (char ch in input) {
        switch (ch) {
          case '(':
            stPAR.Push(ch);
            break;
          case ')':
            if (stPAR.Count != 0) {
              stPAR.Pop();
            }
            break;
      }
    }
    return (stPAR.Count == 0 && input.Length > 1) || input == "" ? true : false;
  }
}
