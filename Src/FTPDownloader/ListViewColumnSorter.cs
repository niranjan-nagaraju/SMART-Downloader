using System.Collections;	
using System.Windows.Forms;


/// <summary>
/// This class is an implementation of the 'IComparer' interface.
/// </summary>
public class ListViewColumnSorter : IComparer
{
	/// <summary>
	/// Specifies the column to be sorted
	/// </summary>
	private int ColumnToSort;
	/// <summary>
	/// Specifies the order in which to sort (i.e. 'Ascending').
	/// </summary>
	private SortOrder OrderOfSort;
	/// <summary>
	/// Case insensitive comparer object
	/// </summary>
	private CaseInsensitiveComparer ObjectCompare;

	/// <summary>
	/// Class constructor.  Initializes various elements
	/// </summary>
	public ListViewColumnSorter()
	{
		// Initialize the column to '1'
		ColumnToSort = 1;

		// Initialize the sort order to 'Ascending'
		OrderOfSort = SortOrder.Ascending;

		// Initialize the CaseInsensitiveComparer object
		ObjectCompare = new CaseInsensitiveComparer();
	}

	/// <summary>
	/// This method is inherited from the IComparer interface.  
	/// It compares the two objects passed using a case insensitive comparison.
	/// 
	/// Comparison rules: 
	/// - directories are listed before (ascending) or after (descending) than files;
	/// - both directories both files are listed in ascending or descending order.
	/// </summary>
	/// <param name="x">First object to be compared</param>
	/// <param name="y">Second object to be compared</param>
	/// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
	public int Compare(object x, object y)
	{
		int compareResult;
		ListViewItem listviewX, listviewY;

		// Cast the objects to be compared to ListViewItem objects
		listviewX = (ListViewItem)x;
		listviewY = (ListViewItem)y;

	
		if ( (listviewX.ImageIndex == listviewY.ImageIndex) ||  ((listviewX.ImageIndex +listviewY.ImageIndex) == 2) )
		{
			// items are of the same type (2 directory or 2 files)
			// with a tirck (listviewX.ImageIndex +listviewY.ImageIndex)
			// one is a link, one is a dir
			// Compare the two items
			compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text,listviewY.SubItems[ColumnToSort].Text);
		}
		else
		{
			// items are of different type
			// directory are listed before (ascending order) than files
			// or after (descending order) than files
			// Note: in my FTP client
			// ImageIndex = 0 means that item is a directory
			// ImageIndex = 1 means that item is a file
			// ImageIndex = 2 means that item is a link
			compareResult = ((listviewX.ImageIndex < listviewY.ImageIndex)?-1:1);
		}
	
		// Calculate correct return value based on object comparison
		if (OrderOfSort == SortOrder.Ascending)
		{
			// Ascending sort is selected, return normal result of compare operation
			return compareResult;
		}
		else if (OrderOfSort == SortOrder.Descending)
		{
			// Descending sort is selected, return negative result of compare operation
			return (-compareResult);
		}
		else
		{
			// Return '0' to indicate they are equal
			return 0;
		}
	}
    
	/// <summary>
	/// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
	/// </summary>
	public int SortColumn
	{
		set
		{
			ColumnToSort = value;
		}
		get
		{
			return ColumnToSort;
		}
	}

	/// <summary>
	/// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
	/// </summary>
	public SortOrder Order
	{
		set
		{
			OrderOfSort = value;
		}
		get
		{
			return OrderOfSort;
		}
	}
    
}
