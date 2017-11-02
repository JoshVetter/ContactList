using Foundation;
using System;
using UIKit;

namespace ContactList
{
    
    public partial class detailsViewController : UIViewController
    {
		public Contact selectedContact;

		public detailsViewController (IntPtr handle) : base (handle)
        {
			contactNameLabel.Text = selectedContact.Name;
			ContactImg.Image = UIImage.FromFile(selectedContact.ImagePath);
			contactLocation.Text = selectedContact.Location;
			contactPhoneNumber.Text = selectedContact.Number;
        }
    }
}