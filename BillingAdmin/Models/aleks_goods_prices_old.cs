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
    
    public partial class aleks_goods_prices_old
    {
        public int good_id { get; set; }
        public long in_price { get; set; }
        public string currency { get; set; }
        public int discount { get; set; }
        public int markup { get; set; }
        public byte has_vat { get; set; }
        public int vat { get; set; }
        public int custom_vat_changing { get; set; }
        public int deployment_rate { get; set; }
        public int delivery_warehouse_rate { get; set; }
        public int delivery_client_rate { get; set; }
        public int opdate { get; set; }
        public byte is_auto_recount { get; set; }
    }
}
