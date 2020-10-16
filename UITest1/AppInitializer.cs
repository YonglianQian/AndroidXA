using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                    //在本地执行，需要有下面的两个方法
                    //.InstalledApp("com.companyname.androidxa")
                    //注意目录
                    //.ApkFile("‪../../../../com.companyname.androidxa.apk")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}