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
    
    public partial class catalog_goods
    {
        public long id { get; set; }
        public string pagetitle { get; set; }
        public string longtitle { get; set; }
        public string source_link { get; set; }
        public string alias { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public int parent { get; set; }
        public long editedon { get; set; }
        public long editedby { get; set; }
        public long createdon { get; set; }
        public long createdby { get; set; }
        public byte deleted { get; set; }
        public string sku { get; set; }
        public string sku_p { get; set; }
        public string sku_m { get; set; }
        public long views { get; set; }
        public long carts { get; set; }
        public long units { get; set; }
        public byte is_native { get; set; }
        public byte is_suite { get; set; }
        public byte is_service { get; set; }
        public byte on_moderate { get; set; }
    }
}
