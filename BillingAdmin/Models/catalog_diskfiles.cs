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
    
    public partial class catalog_diskfiles
    {
        public int id { get; set; }
        public string module { get; set; }
        public string submodule { get; set; }
        public int item_id { get; set; }
        public int createdon { get; set; }
        public int createdby { get; set; }
        public string filename { get; set; }
        public string type { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public string full_path { get; set; }
        public byte is_default { get; set; }
    }
}
