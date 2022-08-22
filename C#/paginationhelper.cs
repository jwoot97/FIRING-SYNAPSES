using System;
using System.Linq;
using System.Collections.Generic;

public class PagnationHelper<T>
{
  /// Constructor, takes in a list of items and the number of items that fit within a single page
  IList<T> collection;
  int itemsPerPage;
  /// <param name="collection">A list of items</param>
  /// <param name="itemsPerPage">The number of items that fit within a single page</param>
  public PagnationHelper(IList<T> collection, int itemsPerPage) {
    this.collection = collection;
    this.itemsPerPage = itemsPerPage;
  }
  
  /// The number of items within the collection
  public int ItemCount { get { return collection.Count; } }

  /// The number of pages
  public int PageCount { get { return (ItemCount / itemsPerPage) + 1; } }

  /// Returns the number of items in the page at the given page index 
  /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
  /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
  public int PageItemCount(int pageIndex) {
    if (pageIndex == 0) {
      return itemsPerPage;
    } else if ( pageIndex > 0 && pageIndex + 1 == PageCount) {
      return ItemCount % itemsPerPage;
    } else if ( pageIndex > 0 && pageIndex < PageCount ) {
      return pageIndex * itemsPerPage;
    } else {
      return -1;
    }
  }

  /// Returns the page index of the page containing the item at the given item index.
  /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
  /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
  public int PageIndex(int itemIndex) {
    return itemIndex >= 0 && itemIndex < ItemCount ? itemIndex / itemsPerPage : -1;
  }
}
