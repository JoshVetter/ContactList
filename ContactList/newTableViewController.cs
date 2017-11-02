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
				Name = "Matthew Dunn",
				Number = "111-351-2785",
				ImagePath = "Images/images-1.jpeg",
				Location = "412 Country Cove NW,  Alberta CAN"
			});

			contactList.Add(new Contact()
			{
				Name = "Josh Vetter",
				Number = "403-356-0009",
				ImagePath = "Images/images.jpeg",
				Location = "50 Evanston Drive NW,  Alberta CAN"
			});

			contactList.Add(new Contact()
			{
				Name = "Tyler Gettle",
				Number = "888-767-7373",
				ImagePath = "Images/images.png",
				Location = "9 Panarama Coast NW,  Alberta CAN"
			});

			contactList.Add(new Contact()
			{
				Name = "Greg Abron",
				Number = "911-911-9119",
				ImagePath = "Images/profile_default.png",
				Location = "999 Last House on The Hill, Somewhere"
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
