using Android.App;
using Android.Widget;
using Android.OS;

namespace Android_with_Xamarin_Tutorial
{
    [Activity(Label = "Android_with_Xamarin_Tutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

