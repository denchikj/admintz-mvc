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
    
    public partial class Task_Check_List
    {
        public int id { get; set; }
        public Nullable<int> tasksId { get; set; }
        public string text { get; set; }
        public int ordering { get; set; }
        public string color { get; set; }
        public string userId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public bool ischeck { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Tasks Tasks { get; set; }
    }
}
