using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Java.Util;
using Android.Icu.Text;

namespace AndroidXA
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            AppCenter.Start("474cb7fe-4c47-4dc2-b4f8-854f0eebe0d9", typeof(Analytics), typeof(Crashes));
            AppCenter.LogLevel = LogLevel.Verbose;

            SimpleDateFormat sdf = new SimpleDateFormat();
            sdf.ApplyPattern("yyyy-MM-dd HH:mm:ss a");
            Date date = new Date();
            Analytics.TrackEvent("Android Xamarin App started, at " + sdf.Format(date));
            
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}