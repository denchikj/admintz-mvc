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
    
    public partial class Profiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profiles()
        {
            this.Profile_Settings = new HashSet<Profile_Settings>();
        }
    
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public Nullable<System.DateTime> dateBirdth { get; set; }
        public string userId { get; set; }
        public int statusId { get; set; }
        public Nullable<int> functionId { get; set; }
        public Nullable<int> officeId { get; set; }
        public string avatar { get; set; }
        public Nullable<bool> createEmail { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Functions Functions { get; set; }
        public virtual Offices Offices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Profile_Settings> Profile_Settings { get; set; }
        public virtual Profile_StatusHB Profile_StatusHB { get; set; }
    }
}