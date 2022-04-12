using System;
using System.Collections.Generic;
using ADOPXF_E_DarkStore.Model;
using Xamarin.Forms;

namespace ADOPXF_E_DarkStore.View
{
    public partial class DetailPage 
    {
        public DetailPage(ItemModel itemModel)
        {
            InitializeComponent();
            BindingContext = itemModel;
        }

        void Back(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
