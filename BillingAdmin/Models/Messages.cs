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
    
    public partial class Messages
    {
        public long id { get; set; }
        public string text { get; set; }
        public long chat_id { get; set; }
        public string user_id { get; set; }
        public System.DateTime date { get; set; }
        public int idtable { get; set; }
        public int typetable { get; set; }
        public Nullable<bool> parametr { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
