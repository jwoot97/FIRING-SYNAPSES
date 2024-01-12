// "WEIGHT FOR WEIGHT" WIP SCRIPT
// SUPER HEAVYWEIGHT JESUS CHRIST
// https://www.codewars.com/kata/55c6126177c9441a570000cc/train/csharp

using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

public class WeightSort {
	
	public static string orderWeight(string strng) {
    if ( strng == "" ) {
      return "";
    } else {
      List<string> numbers = strng.Split(' ').ToList();
      List<int> sums = new List<int>();
      List<int> ret = new List<int>();

      // populates list of sums
      foreach(string number in numbers) {
        int totalsum = 0;
        foreach(char c in number) {
          totalsum += (int)Char.GetNumericValue(c);
        }
        Console.WriteLine($"SUM OF {number} IS {totalsum}");
        sums.Add(totalsum);
      }
      Console.WriteLine($"FULL NUMBER ARRAY: {String.Join(' ', numbers.ToArray())}");
      Console.WriteLine($"FULL SUM ARRAY: {String.Join(' ', sums.ToArray())}");

      // generate sorted list of sums to save for later
      List<int> sortedsums = new List<int>();
      foreach ( int i in sums ) { sortedsums.Add(i); }
      sortedsums.Sort();
      Console.WriteLine($"FULL SORTED SUM ARRAY: {String.Join(' ', sortedsums.ToArray())}");

      // sort list of numbers by their respective sums
      int lstlength = numbers.Count();
      for ( int i = 0; i < lstlength + i; i++ ) {
        int min = sums.AsQueryable().Min();
        ret.Add(Int32.Parse(numbers.ElementAt(sums.IndexOf(min))));
        numbers.RemoveAt(sums.IndexOf(min));
        sums.RemoveAt(sums.IndexOf(min));
        lstlength = numbers.Count();
      }

      // swap values based on alphabetical value ( 1 comes before 2, etc.)
      // check sorted sum array and if the values of index and index+1 are the same
      // if those values are equal, compare the first digits of the numbers at index and index+1 in ret
      // if both conditions are met, swap the two values (ret[index] <-> ret[index+1])
      for ( int i = 0; i != ret.Count() - 1; i++ ) {
        int current = Convert.ToInt32(ret[i].ToString().Substring(0, 1));
        int next = Convert.ToInt32(ret[i+1].ToString().Substring(0, 1));
        
        if (sortedsums[i] == sortedsums[i+1]){
          if (current > next) {
            Console.WriteLine($"{sortedsums[i]} equals {sortedsums[i+1]}, and {ret[i]} > {ret[i+1]}");
            int TMP = ret[i];
            ret[i] = ret[i+1];
            ret[i+1] = TMP;
          } else if (current == next) {
            if (Convert.ToInt32(ret[i+1].ToString().Substring(1, 2)) > Convert.ToInt32(ret[i+1].ToString().Substring(1, 2))) {
              Console.WriteLine($"{sortedsums[i]} equals {sortedsums[i+1]}, and {ret[i]} > {ret[i+1]}");
              int TMP = ret[i];
              ret[i] = ret[i+1];
              ret[i+1] = TMP;
            }
          }
        }
      }

      Console.WriteLine($"FULL SORTED NUMBERS: {String.Join(' ', ret.ToArray())}\n");
      return String.Join(' ', ret.ToArray());
    }
	}
}