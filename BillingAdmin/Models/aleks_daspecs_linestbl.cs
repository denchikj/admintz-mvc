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
    
    public partial class aleks_daspecs_linestbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aleks_daspecs_linestbl()
        {
            this.aleks_daspecs_accounts = new HashSet<aleks_daspecs_accounts>();
        }
    
        public long spec_id { get; set; }
        public long line_id { get; set; }
        public string mark { get; set; }
        public string number { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public long count { get; set; }
        public decimal compare_cost { get; set; }
        public string units { get; set; }
        public string comment { get; set; }
        public string empty_line_comment { get; set; }
        public string additional_info { get; set; }
        public byte is_wrong { get; set; }
        public byte is_infoblock { get; set; }
        public Nullable<long> position_id { get; set; }
        public long id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aleks_daspecs_accounts> aleks_daspecs_accounts { get; set; }
    }
}