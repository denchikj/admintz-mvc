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
    
    public partial class Help_Content
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Help_Content()
        {
            this.Help_Comments = new HashSet<Help_Comments>();
            this.Help_Roles = new HashSet<Help_Roles>();
        }
    
        public int ID_Content { get; set; }
        public string Header { get; set; }
        public string Information { get; set; }
        public Nullable<int> ID_Categories { get; set; }
        public string Link_To_Help { get; set; }
    
        public virtual Help_Categories Help_Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Help_Comments> Help_Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Help_Roles> Help_Roles { get; set; }
    }
}
