//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillingAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu_Items_in_category
    {
        public string id { get; set; }
        public Nullable<int> Id_categories { get; set; }
        public Nullable<int> id_item { get; set; }
        public Nullable<int> position { get; set; }
    
        public virtual Menu_Category Menu_Category { get; set; }
        public virtual Menu_Items Menu_Items { get; set; }
    }
}