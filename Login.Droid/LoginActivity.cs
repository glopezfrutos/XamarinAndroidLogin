using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Google.Android.Material.FloatingActionButton;
using Login.Core.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login.Droid
{
    [Activity(Label = "LoginActivity", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        private EditText userId;
        private EditText pin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.login);

            // Get user id & pin values from edit text  
            userId = FindViewById<EditText>(Resource.Id.txtUserId);
            pin = FindViewById<EditText>(Resource.Id.txtPin);

            // Trigger click event of Login Button  
            var button = FindViewById<FloatingActionButton>(Resource.Id.btnLogin);
            button.Click += DoLogin;
        }

        public void DoLogin(object sender, EventArgs e)
        {
            User user = new User
            {
                UserId = userId.Text,
                Pin = pin.Text
            };

            if (userId.Text == "")
            {
                userId.Error = "Enter the User Id!";
            }

            if (user.Pin == "123")
            {
                // Create intent
                Android.Content.Intent activity = new Android.Content.Intent(this, typeof(WelcomeActivity));

                // Add User object to the intent and Navigate to the next screen
                activity.PutExtra("User", JsonConvert.SerializeObject(user));
                StartActivity(activity);

                Toast.MakeText(this, "Login successfully done!", ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(this, "Wrong credentials found!", ToastLength.Long).Show();
            }
        }
    }
}