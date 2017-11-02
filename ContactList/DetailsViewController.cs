using Foundation;
using System;
using UIKit;

namespace ContactList
{
	public partial class DetailsViewController : UIViewController
	{

		public Contact selectedContact;
		public DetailsViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewWillAppear(bool animated)
		{
			labelContactName.Text = selectedContact.Name;
			ContactImg.Image = UIImage.FromFile(selectedContact.ImagePath);
			contactLocation.Text = selectedContact.Location;
			contactPhoneNumber.Text = selectedContact.Number;

		}
	}
}