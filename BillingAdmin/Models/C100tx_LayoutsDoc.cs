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
    
    public partial class C100tx_LayoutsDoc
    {
        public string id { get; set; }
        public string name { get; set; }
        public byte[] fileData { get; set; }
        public int layoutType { get; set; }
    
        public virtual C100tx_LayoutsDoc_types C100tx_LayoutsDoc_types { get; set; }
    }
}
