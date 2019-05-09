using Foundation;
using System;
using UIKit;
using Experiment2.Models;

namespace Experiment2
{
    public partial class UserConfirmationController : UIViewController
    {
        public string Username;

        public UserConfirmationController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            UserNameLabel.Text += "'" + Username + "'" + "has been created successfully!";

        }
    }
}