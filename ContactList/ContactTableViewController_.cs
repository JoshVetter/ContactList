using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace ContactList
{
    public partial class ContactTableViewController : UITableView
    {

        List<Contact> contactList;

        public ContactTableViewController (IntPtr handle) : base (handle)
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
        public override nint NumberOfSections()
        {
            return base.NumberOfSections();
        }
    }
    public class Contact
    {
        public string Name;
        public string Number;
        public string Location;
        public string Imagepath;

    }
}