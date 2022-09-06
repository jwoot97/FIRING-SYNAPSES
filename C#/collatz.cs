public class Kata
{
  public static string Collatz(int n)
  {
    string fullstring = n.ToString();
    while (n != 1) {
      n = n % 2 == 0 ? n/2 : (3 * n) + 1;
      fullstring += $"->{n}";
    }
    return fullstring;
  }
}
