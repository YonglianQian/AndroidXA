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
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Indigo,
        Violet
    }
    public class RGBColor
    {
        public int A { get; set; } = 0;
        public int B { get; set; } = 1;
        public int C { get; set; } = 2;

        public RGBColor(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            Console.WriteLine(a + b + c);
        }

    }
    /// <summary>
    /// C#9 feature
    /// </summary>
    //public record Person
    //{
    //    public string LastName { get; }
    //    public string FirstName { get; }

    //    public Person(string first, string last) => (FirstName, LastName) = (first, last);
    //    public override string ToString()
    //    {
    //        return $"My Name is {FirstName} {LastName}";
    //    }
    //}

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            SimpleDateFormat sdf = new SimpleDateFormat();
            sdf.ApplyPattern("yyyy-MM-dd HH:mm:ss a");
            Date date = new Date();

            Crashes.GetErrorAttachments = (ErrorReport report) =>
            {
                return new ErrorAttachmentLog[]
                {
                    ErrorAttachmentLog.AttachmentWithText("Crash happened: Hello world! \r\n at "+sdf.Format(date), "hello.txt"),
                    //ErrorAttachmentLog.AttachmentWithBinary(data,"a.png","image/png")
            };
            };
            AppCenter.Start("474cb7fe-4c47-4dc2-b4f8-854f0eebe0d9", typeof(Analytics), typeof(Crashes));
            AppCenter.LogLevel = LogLevel.Verbose;


            Analytics.TrackEvent("Loading Main activity... , at " + sdf.Format(date));

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
                var result = FromRainbow(Rainbow.Indigo);
                //Person p = new Person("Abraham", "Qian");
                Analytics.TrackEvent($"Now is: {sdf.Format(date)}. Result is: {result.C}");
                //Crashes.GenerateTestCrash();
                translateButton.Text = $"{result.C}";
            };


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {

            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        }
        public static RGBColor FromRainbow(Rainbow colorBand) =>
    colorBand switch
    {
        Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
        Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
        Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
        Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
        Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
        Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
        Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
        _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
    };


    }
    
}