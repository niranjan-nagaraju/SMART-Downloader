using System;
using System.Collections;

namespace SmartDownloader.FTPDownloader
{
	[Serializable]
	public class connectiondata
	{
		public String address;
		public String username;
		public String password;
		public String port;
		public Boolean anonymous;
	}

	/// <summary>
	/// Summary description for noteslist.
	/// </summary>
	public class connectionlist
	{
		private ArrayList mylist;

		public connectionlist()
		{
			mylist = new System.Collections.ArrayList();
		}


		public int AddItem(connectiondata obj ) 
		{
			return mylist.Add(obj);
		}

		public connectiondata Item(int index)
		{
			return (connectiondata) mylist[index];
		}

		public Boolean RemoveItem(connectiondata obj)
		{
			int i;
			Boolean bRemoved = false;

			for (i = 0; i <mylist.Count ;i++)
			{
				if (obj.Equals(mylist[i]))
				{
					mylist.RemoveAt(i);
					bRemoved = true;
					break;
				}			
			}
			return bRemoved;
		}

		public Boolean SearchItem(connectiondata obj)
		{
			int i;
			connectiondata cdata;
			Boolean bFound = false;

			for (i = 0; i <mylist.Count ;i++)
			{
				cdata = (connectiondata) mylist[i];
				if ( (obj.address == cdata.address) &&
					(obj.username == cdata.username) &&
					(obj.password == cdata.password) &&
					(obj.port == cdata.port) &&
					(obj.anonymous == cdata.anonymous) )
				{
					bFound = true;
					break;
				}			
			}
			return bFound;
		}

		public int ItemCount()
		{
			return mylist.Count;
		}
		
	}
}