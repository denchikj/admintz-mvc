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
    
    public partial class C100tx_Orders
    {
        public int id { get; set; }
        public long account { get; set; }
        public Nullable<long> specification { get; set; }
        public Nullable<System.DateTime> dateadd { get; set; }
        public string plan_purchase { get; set; }
        public string name { get; set; }
        public Nullable<int> markup { get; set; }
        public Nullable<long> creatorAccount { get; set; }
        public string comment { get; set; }
        public Nullable<long> sum { get; set; }
        public string stage { get; set; }
        public Nullable<System.DateTime> term_stage { get; set; }
        public Nullable<System.DateTime> date_stage { get; set; }
    
        public virtual Accounts Accounts { get; set; }
    }
}
