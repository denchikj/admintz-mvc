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
    
    public partial class Tables_In_Entity
    {
        public int Id { get; set; }
        public Nullable<int> typeTable { get; set; }
        public Nullable<int> entityId { get; set; }
        public Nullable<int> tableId { get; set; }
    
        public virtual Tables Tables { get; set; }
        public virtual Type_Table Type_Table { get; set; }
        public virtual Type_Table Type_Table1 { get; set; }
    }
}
