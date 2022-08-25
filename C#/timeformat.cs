public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
      // a bit of a simpler solution - this one is good to know for future string formatting reference
      return string.Format("{0:D2}:{1:D2}:{2:D2}", seconds / 3600, (seconds % 3600) / 60, seconds % 60);
    }
}
