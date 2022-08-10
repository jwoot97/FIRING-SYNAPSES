public static class Kata
{
  public static int Solution(int value)
  {
    int sum = 0;
    do {
      value--;
      if (value % 3 == 0 || value % 5 == 0) {
          sum += value;
      }
    } while(value > 0);
    return sum;
  }
}
