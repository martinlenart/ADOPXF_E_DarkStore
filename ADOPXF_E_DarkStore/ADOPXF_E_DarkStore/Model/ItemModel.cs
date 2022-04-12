using System;
using ADOPXF_E_DarkStore.Enum;

namespace ADOPXF_E_DarkStore.Model
{
    public class ItemModel
    {
        public string Name { get; set; }
        public String Image { get; set; }
        public string Price { get; set; }
        public ItemType ItemType { get;set; } 
    }
}
