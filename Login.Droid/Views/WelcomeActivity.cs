using Android.App;
using Android.OS;
using Login.Core.ViewModels;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace Login.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "@string/welcome", Theme = "@style/AppTheme")]
    public class WelcomeView : MvxActivity<WelcomeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.welcome);
        }
    }
}