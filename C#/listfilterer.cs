using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
     List<int> lstINT = new List<int>();
     foreach (object element in listOfItems) {
        if (element is int) {
          lstINT.Add((int)element);
        }
     }
     return lstINT;
   }
}
