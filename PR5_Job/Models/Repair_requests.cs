//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR5_Job.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Repair_requests
    {
        public int ID_Repair_requests { get; set; }
        public int ID_Equipment { get; set; }
        public Nullable<int> ID_Staff { get; set; }
        public System.DateTime Date { get; set; }
        public string Name_organization { get; set; }
        public string The_nature_of_the_fault { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
