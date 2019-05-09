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
    [Register ("ClientUserController")]
    partial class ClientUserController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CreateUserButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel EmailAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EmailTextbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LastnameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LastnameTextbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NameTextbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PasswordLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordTextbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PhoneNumberLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PhoneTextbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UserNameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField UserNameTextbox { get; set; }

        [Action ("CreateUserButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CreateUserButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CreateUserButton != null) {
                CreateUserButton.Dispose ();
                CreateUserButton = null;
            }

            if (EmailAddress != null) {
                EmailAddress.Dispose ();
                EmailAddress = null;
            }

            if (EmailTextbox != null) {
                EmailTextbox.Dispose ();
                EmailTextbox = null;
            }

            if (LastnameLabel != null) {
                LastnameLabel.Dispose ();
                LastnameLabel = null;
            }

            if (LastnameTextbox != null) {
                LastnameTextbox.Dispose ();
                LastnameTextbox = null;
            }

            if (NameLabel != null) {
                NameLabel.Dispose ();
                NameLabel = null;
            }

            if (NameTextbox != null) {
                NameTextbox.Dispose ();
                NameTextbox = null;
            }

            if (PasswordLabel != null) {
                PasswordLabel.Dispose ();
                PasswordLabel = null;
            }

            if (PasswordTextbox != null) {
                PasswordTextbox.Dispose ();
                PasswordTextbox = null;
            }

            if (PhoneNumberLabel != null) {
                PhoneNumberLabel.Dispose ();
                PhoneNumberLabel = null;
            }

            if (PhoneTextbox != null) {
                PhoneTextbox.Dispose ();
                PhoneTextbox = null;
            }

            if (UserNameLabel != null) {
                UserNameLabel.Dispose ();
                UserNameLabel = null;
            }

            if (UserNameTextbox != null) {
                UserNameTextbox.Dispose ();
                UserNameTextbox = null;
            }
        }
    }
}