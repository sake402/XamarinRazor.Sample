using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LivingThing.Core.Frameworks.XamarinRazor;

namespace XamarinRazor.Sample
{
    public partial class App : Application
    {

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(HowPage), new ComponentRouteFactory<HowPage>(serviceProvider));
            MainPage = Razor.Create<AppShell, Shell>(serviceProvider).Element;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
