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

namespace Experiment2
{
    [Register ("SelectUserController")]
    partial class SelectUserController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClientUserButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GoBackButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ServiceProviderUserButton { get; set; }

        [Action ("GoBackButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GoBackButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ClientUserButton != null) {
                ClientUserButton.Dispose ();
                ClientUserButton = null;
            }

            if (GoBackButton != null) {
                GoBackButton.Dispose ();
                GoBackButton = null;
            }

            if (ServiceProviderUserButton != null) {
                ServiceProviderUserButton.Dispose ();
                ServiceProviderUserButton = null;
            }
        }
    }
}