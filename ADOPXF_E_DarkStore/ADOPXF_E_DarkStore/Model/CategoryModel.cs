
using System;
using System.Collections.Generic;
using ADOPXF_E_DarkStore.View;
using ADOPXF_E_DarkStore.ViewModel;
using Xamarin.Forms;

namespace ADOPXF_E_DarkStore.Model
{
    public class CategoryModel : BaseVM
    {
        public string Name { get; set; }
        private bool select;
        public bool Select
        {
            get { return select; }
            set { SetProperty(ref select, value); }
        }

    }
}
