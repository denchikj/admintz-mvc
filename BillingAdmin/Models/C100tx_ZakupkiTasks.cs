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
    
    public partial class C100tx_ZakupkiTasks
    {
        public long id { get; set; }
        public string region { get; set; }
        public string url { get; set; }
        public string task_id { get; set; }
        public int status { get; set; }
    
        public virtual C100tx_TasksStatusesHB C100tx_TasksStatusesHB { get; set; }
    }
}
