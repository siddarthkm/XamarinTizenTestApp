using System;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;

namespace BuildTaskTest
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            LoadApplication(new App());

            try
            {
                MobileCenter.Start("7532674f-eb96-401e-ab2b-0f296db3a71e", typeof(Analytics));
            }
            catch (Exception e)
            {
                MobileCenterLog.Debug(MobileCenterLog.LogTag, "Exception!!! " + e.GetType() + "\n" + e.Message);
            }
        }

        static void Main(string[] args)
        {
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            app.Run(args);
        }
    }

    public class SampleClass
    {
    }

}
