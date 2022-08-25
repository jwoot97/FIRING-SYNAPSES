using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

public class HumanTimeFormat{
  public static string formatDuration(int seconds){
    int years = seconds / 31536000;
    int days = (seconds / 86400) % 365;
    TimeSpan t = TimeSpan.FromSeconds(seconds);
    string fulltime = "";
    List<int> time = new List<int>{years, days, t.Hours, t.Minutes, t.Seconds};
    Console.WriteLine( $"YEARS: {time[0]}\nDAYS: {time[1]}\nHOURS: {time[2]}\nMINUTES: {time[3]}\nSECONDS: {time[4]}\n" );
    if ( seconds == 0 ) { return "now"; }
    
    // handle singular and plural output
    int index = 0;
    foreach ( int comp in time ) {
      if ( comp == 1 ) {
        switch ( index ) {
            case 0:
              fulltime += $"{comp} year";
              break;
            case 1:
              fulltime += $"{comp} day";
              break;
            case 2:
              fulltime += $"{comp} hour";
              break;
            case 3:
              fulltime += $"{comp} minute";
              break;
            case 4:
              fulltime += $"{comp} second";
              break;
        }
      } else if ( comp != 0 ) {
          switch (index) {
            case 0:
              fulltime += $"{comp} years";
              break;
            case 1:
              fulltime += $"{comp} days";
              break;
            case 2:
              fulltime += $"{comp} hours";
              break;
            case 3:
              fulltime += $"{comp} minutes";
              break;
            case 4:
              fulltime += $"{comp} seconds";
              break;
        }
      }
      // handle delimiting text 'and' or ','
      if (( fulltime != "" && index == 3 && time[4] != 0 ) || ( fulltime != "" && index < 3 && ( time[index+2] == 0 ))) { fulltime += " and "; }
      else if ( index < 3 && time[index+1] != 0 && fulltime != "" ) { fulltime += ", "; }
      index++;
    }
    Console.WriteLine($"FULL TIME: {fulltime}\n\n");
    return fulltime;
  }
}
