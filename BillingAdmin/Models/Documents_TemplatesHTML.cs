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
    
    public partial class Documents_TemplatesHTML
    {
        public int ID { get; set; }
        public string name_template { get; set; }
        public byte[] html { get; set; }
        public Nullable<int> type_template_id { get; set; }
        public Nullable<int> account_role_id { get; set; }
    
        public virtual Accounts_RolesHB Accounts_RolesHB { get; set; }
        public virtual Documents_TypesHB Documents_TypesHB { get; set; }
    }
}