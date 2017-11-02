using Foundation;
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using UIKit;

namespace ContactList
{

    public partial class TableViewController : UITableViewController
    {
        List<Contact> contactList;
        public TableViewController(IntPtr handle) : base(handle)
        {
            contactList = new List<Contact>();

			contactList.Add(new Contact()
			{
				Name = "Josh Vetter",
				Number = "123-456-9101",
				ImagePath = "Images/images-1.jpeg",
				Location = "213 Harvest Hills Drive N.E"
			});

			contactList.Add(new Contact()
			{
				Name = "Matt Dunn",
				Number = "423-323-4444",
				ImagePath = "Images/images.jpeg",
				Location = "232 Harvest hills Drive N.E"
			});

			contactList.Add(new Contact()
			{
				Name = "John De Leon",
				Number = "321-554-3332",
				ImagePath = "Images/images.png",
				Location = "236 Harvest Hills Drive N.E"
			});

			contactList.Add(new Contact()
			{
				Name = "Gregory Ebron",
				Number = "099-665-1243",
				ImagePath = "Images/profile_default.png",
				Location = "690 Harvest Park Way N.E"
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
            var cell = tableView.DequeueReusableCell("Contact") as ContactTableViewCell;

            var data = contactList[indexPath.Row];

            cell.ContactData = data;

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetailsSegue")
            {
                var navigationController = segue.DestinationViewController as DetailsViewController;

                if (navigationController != null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var selectedData = contactList[rowPath.Row];

                    navigationController.selectedContact = selectedData;
                }
            }


            base.PrepareForSegue(segue, sender);
        }
    }

    public class Contact
    {
        public string Name;
        public string Number;
        public string ImagePath;
        public string Location;
    }
}
