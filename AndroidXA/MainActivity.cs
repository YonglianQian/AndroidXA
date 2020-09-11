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
using System.Text;
using System.IO;
using System;

namespace AndroidXA
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            
            
            
            Crashes.GetErrorAttachments = (ErrorReport report) =>
            {

                SimpleDateFormat sdf = new SimpleDateFormat();
                sdf.ApplyPattern("yyyy-MM-dd HH:mm:ss a");
                Date date = new Date();

                //Stream stream = Assets.Open("a.png");
                //MemoryStream ms = new MemoryStream();
                //stream.CopyTo(ms);
                //byte[] data = ms.ToArray();

                return new ErrorAttachmentLog[]
                {
                    ErrorAttachmentLog.AttachmentWithText("Hello world! \r\n at "+sdf.Format(date), "hello.txt"),
                    //ErrorAttachmentLog.AttachmentWithBinary(data,"a.png","image/png")
            };
            };


            AppCenter.Start("474cb7fe-4c47-4dc2-b4f8-854f0eebe0d9", typeof(Analytics), typeof(Crashes));
            AppCenter.LogLevel = LogLevel.Verbose;

            

            Button translateButton = FindViewById<Button>(Resource.Id.TranslateButton);
            translateButton.Click += (sender, e) =>
            {
                // Translate user's alphanumeric phone number to numeric
                //string translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);
                //if (string.IsNullOrWhiteSpace(translatedNumber))
                //{
                //    translatedPhoneWord.Text = string.Empty;
                //}
                //else
                //{
                //    translatedPhoneWord.Text = translatedNumber;
                //}

                SimpleDateFormat sdf = new SimpleDateFormat();
                sdf.ApplyPattern("yyyy-MM-dd HH:mm:ss a");
                Date date = new Date();
                Analytics.TrackEvent("Button is clicked, at " + sdf.Format(date));

                Crashes.GenerateTestCrash();
            };


            // Set our view from the "main" layout resource
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        }
    }
}