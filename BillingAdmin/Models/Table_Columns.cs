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
    
    public partial class Table_Columns
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Columns()
        {
            this.Table_Data = new HashSet<Table_Data>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> type { get; set; }
        public int tableid { get; set; }
        public Nullable<int> posx { get; set; }
        public Nullable<int> posy { get; set; }
        public Nullable<int> width { get; set; }
        public Nullable<int> enumId { get; set; }
        public string description { get; set; }
        public Nullable<int> excelId { get; set; }
    
        public virtual Table_Column_Type Table_Column_Type { get; set; }
        public virtual Tablies_ Tablies_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Data> Table_Data { get; set; }
    }
}