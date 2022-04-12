using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ADOPXF_E_DarkStore
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental" });
            InitializeComponent();

            MainPage = new NavigationPage( new ADOPXF_E_DarkStore.View.MainPage());
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
