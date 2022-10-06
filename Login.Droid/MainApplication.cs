using Android.App;
using Android.Runtime;
using Login.Core;
using MvvmCross.Platforms.Android.Views;
using System;

namespace Login.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}