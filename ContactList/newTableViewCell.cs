using Foundation;
using System;
using UIKit;

namespace ContactList
{
    public partial class newTableViewCell : UITableViewCell
    {

        private Contact contactData;
		public Contact ContactData
		{
			get { return contactData; }
			set
			{
				contactData = value;
			}
		}


        public newTableViewCell (IntPtr handle) : base (handle)
        {
            
        }
    }
}