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
    
    public partial class Tablies_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tablies_()
        {
            this.Table_Columns = new HashSet<Table_Columns>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string typeId { get; set; }
        public System.DateTime updateDate { get; set; }
        public System.DateTime createDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Columns> Table_Columns { get; set; }
        public virtual Table_type Table_type { get; set; }
    }
}
