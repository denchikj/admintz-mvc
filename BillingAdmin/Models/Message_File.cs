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
    
    public partial class Message_File
    {
        public int Id { get; set; }
        public Nullable<int> messageId { get; set; }
        public string fileId { get; set; }
    
        public virtual Files Files { get; set; }
        public virtual Message Message { get; set; }
    }
}
