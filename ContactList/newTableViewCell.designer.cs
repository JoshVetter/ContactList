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
    [Register ("newTableViewCell")]
    partial class newTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel contactNumberLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (contactNameLabel != null) {
                contactNameLabel.Dispose ();
                contactNameLabel = null;
            }

            if (contactNumberLabel != null) {
                contactNumberLabel.Dispose ();
                contactNumberLabel = null;
            }
        }
    }
}