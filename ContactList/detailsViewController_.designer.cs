// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ContactList
{
    [Register ("detailsViewController")]
    partial class detailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ContactImg { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactLocation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactPhoneNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ContactImg != null) {
                ContactImg.Dispose ();
                ContactImg = null;
            }

            if (contactLocation != null) {
                contactLocation.Dispose ();
                contactLocation = null;
            }

            if (contactPhoneNumber != null) {
                contactPhoneNumber.Dispose ();
                contactPhoneNumber = null;
            }

            if (labelName != null) {
                labelName.Dispose ();
                labelName = null;
            }
        }
    }
}