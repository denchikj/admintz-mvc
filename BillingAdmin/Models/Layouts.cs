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
    
    public partial class Layouts
    {
        public int Id { get; set; }
        public Nullable<int> tableId { get; set; }
        public Nullable<int> colums { get; set; }
        public Nullable<int> ordering { get; set; }
    
        public virtual Tables Tables { get; set; }
    }
}