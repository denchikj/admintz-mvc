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
    
    public partial class Log_Pattern
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Log_Pattern()
        {
            this.Log_Pattern_To_Users = new HashSet<Log_Pattern_To_Users>();
        }
    
        public int Id { get; set; }
        public Nullable<int> typetable { get; set; }
        public Nullable<int> idtable { get; set; }
        public Nullable<int> actionid { get; set; }
        public string userid { get; set; }
        public string text { get; set; }
        public string verification { get; set; }
        public Nullable<double> notification { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Log_Action Log_Action { get; set; }
        public virtual Log_PropertySaveTable Log_PropertySaveTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log_Pattern_To_Users> Log_Pattern_To_Users { get; set; }
        public virtual Type_Table Type_Table { get; set; }
        public virtual Type_Table Type_Table1 { get; set; }
    }
}