using Foundation;
using System;
using UIKit;
using Experiment2.Models;


namespace Experiment2
{
    public partial class ClientUserController : UIViewController
    {
        private ApiClientController ApiClient;
        private ClientModel client;

        public ClientUserController (IntPtr handle) : base (handle)
        {
        }

        partial void CreateUserButton_TouchUpInside(UIButton sender)
        {
            ApiClient = new ApiClientController();
            client = new ClientModel();
            client.Username = UserNameTextbox.Text;
            client.Password = PasswordTextbox.Text;
            client.Name = NameTextbox.Text;
            client.Lastname = LastnameTextbox.Text;
            client.Phonenumber = PhoneTextbox.Text;
            client.Email = EmailTextbox.Text;

            
            ApiClient.CreateClient(client);
            //Se llama al metodo de la api que inserta un nuevo 
            Console.WriteLine(client.Email);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var userConfirmationController = segue.DestinationViewController as UserConfirmationController;
            userConfirmationController.Username = this.client.Username;
        }
    }
}