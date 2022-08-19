public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    // handle values under 0 or over 255
    if ( r < 0 ) { r = 0; }
    if ( g < 0 ) { g = 0; }
    if ( b < 0 ) { b = 0; }
    if ( r > 255 ) { r = 255; }
    if ( g > 255 ) { g = 255; }
    if ( b > 255 ) { b = 255; }

    // return values as a hex string
    return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
  }
}
