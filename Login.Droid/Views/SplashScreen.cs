using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace Login.Droid.Views
{
    [Activity(
        Label = "@string/loading",
        MainLauncher = true,
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.splashscreen)
        {
        }
    }
}