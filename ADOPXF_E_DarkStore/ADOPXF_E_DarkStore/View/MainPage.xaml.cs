using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPXF_E_DarkStore.Model;
using ADOPXF_E_DarkStore.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ADOPXF_E_DarkStore.View
{
    [DesignTimeVisible(false)]
    public partial class MainPage 
    {
        MainPageVM MainPageVM;
        public MainPage()
        {
            MainPageVM = new MainPageVM(Navigation);
            InitializeComponent();
            BindingContext = MainPageVM;
        }
    }
}
