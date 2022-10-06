using Android.App;
using Android.OS;
using Android.Text;
using Android.Widget;
using Login.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace Login.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class LoginView : MvxActivity<LoginViewModel>
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

            userId.AfterTextChanged += ValidateForm;
            pin.AfterTextChanged += ValidateForm;
        }

        private void ValidateForm(object sender, AfterTextChangedEventArgs e)
        {
            if (userId.Text == "")
            {
                userId.Error = "Please, enter the User Id";
            }

            if (pin.Text == "")
            {
                pin.Error = "Please, enter the Pin";
            }
        }
    }
}