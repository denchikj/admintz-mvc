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
    
    public partial class Profile_Settings
    {
        public int id { get; set; }
        public string value { get; set; }
        public int typeId { get; set; }
        public int profileId { get; set; }
    
        public virtual Profiles Profiles { get; set; }
    }
}