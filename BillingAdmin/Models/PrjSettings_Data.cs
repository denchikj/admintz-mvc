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
    
    public partial class PrjSettings_Data
    {
        public int id { get; set; }
        public Nullable<int> projects_id { get; set; }
        public Nullable<int> preferences_id { get; set; }
        public string value { get; set; }
    
        public virtual PrjPreferences PrjPreferences { get; set; }
        public virtual Projects Projects { get; set; }
    }
}