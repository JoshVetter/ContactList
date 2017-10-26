using Foundation;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System;
using UIKit;

namespace ContactList
{
    public partial class TableViewController : UITableViewController
    {
		List<Contact> contactList;

        public TableViewController (IntPtr handle) : base (handle)
        {
			contactList = new List<Contact>();

			contactList.Add(new Contact()
			{
				Name = "Jeff",
				Number = "403",
				Location = "House",
				Imagepath = "picture"


			});
			contactList.Add(new Contact()
			{
				Name = "Jeff",
				Number = "403",
				Location = "House",
				Imagepath = "picture"


			});
			contactList.Add(new Contact()
			{
				Name = "Jeff",
				Number = "403",
				Location = "House",
				Imagepath = "picture"


			});
			contactList.Add(new Contact()
			{
				Name = "Jeff",
				Number = "403",
				Location = "House",
				Imagepath = "picture"


			});



        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return contactList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            return base.GetCell(tableView, indexPath);
        }

		public class Contact
		{
            public string Name;
            public string Number;
            public string Location;
            public string Imagepath;

	    }
    }


}