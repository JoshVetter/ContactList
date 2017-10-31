using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace ContactList
{
    public partial class newTableViewController : UITableViewController
	{
		List<Contact> contactList;

		public newTableViewController(IntPtr handle) : base(handle)
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
            var cell = tableView.DequeueReusableCell("Contact") as newTableViewCell;

            var data = contactList[indexPath.Row];

            cell.ContactData = data;

            return cell;
        }



		}
	}

    public class Contact
    {
	    public string Name;
    	public string Number;
    	public string Location;
    	public string Imagepath;

}