using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Login.Core.Model;
using Newtonsoft.Json;

namespace Login.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class WelcomeActivity : AppCompatActivity
    {
        private User user;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.welcome);

            //Get txt_Result TextView control from the Main.xaml Layout.      
            TextView txt_Result = FindViewById<TextView>(Resource.Id.message);

            // Get User object from previous activity
            user = JsonConvert.DeserializeObject<User>(Intent.GetStringExtra("User"));
            txt_Result.Text = "Hello, your User Id is " + user.UserId + " and your Pin is " + user.Pin;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}