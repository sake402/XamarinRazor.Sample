using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Extensions.DependencyInjection;
using Android.Content;
using Xamarin.Forms.Internals;
using RAGPWealthGate.Droid.Startup;
using LivingThing.Core.Frameworks.XamarinRazor;

namespace XamarinRazor.Sample.Droid
{
    [Activity(Label = "XamarinRazor.Sample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            var serviceProvider = Initializer.Initialize((services) =>
            {
                services.RegisterServices();
                services.AddSingleton<Context>((x) => this);
                services.AddSingleton<App>();
            });

            DependencyResolver.ResolveUsing(type =>
            {
                return serviceProvider.GetService(type);
            });

            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(serviceProvider.GetRequiredService<App>());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}