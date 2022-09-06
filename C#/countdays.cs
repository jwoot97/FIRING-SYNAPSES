namespace DayCount {
  using System;
  
  public class Day
  {
    public string countDays(DateTime d){
      int daycount = (int)((d - DateTime.Now).TotalDays);
      if (daycount == 0) { return "Today is the day!"; }
      else if (daycount < 0) { return "The day is in the past!"; }
      else { return $"{daycount.ToString()} days"; }
    }
  }
}
