using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using System.Threading.Tasks;

namespace MvxForms.Droid
{
    [Activity(
        Label = "MvxForms"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override Task RunAppStartAsync(Bundle bundle)
        {
            StartActivity(typeof(MainActivity));
            return Task.CompletedTask;
        }
    }
}
