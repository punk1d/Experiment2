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
    [Register ("SelectLoginController")]
    partial class SelectLoginController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CreateUserButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FbLoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GoogleLoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginButton { get; set; }

        [Action ("CreateUserButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CreateUserButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LoginButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LoginButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton3502_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton3502_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CreateUserButton != null) {
                CreateUserButton.Dispose ();
                CreateUserButton = null;
            }

            if (FbLoginButton != null) {
                FbLoginButton.Dispose ();
                FbLoginButton = null;
            }

            if (GoogleLoginButton != null) {
                GoogleLoginButton.Dispose ();
                GoogleLoginButton = null;
            }

            if (LoginButton != null) {
                LoginButton.Dispose ();
                LoginButton = null;
            }
        }
    }
}