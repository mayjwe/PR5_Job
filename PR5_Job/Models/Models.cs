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
    
    public partial class Models
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Models()
        {
            this.More = new HashSet<More>();
            this.Ordedrs = new HashSet<Ordedrs>();
        }
    
        public int ID_Models { get; set; }
        public int ID_Cloth { get; set; }
        public int ID_Season { get; set; }
        public int ID_Status_model { get; set; }
        public int ID_Accessories { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public int Size { get; set; }
        public bool Lining { get; set; }
        public bool Belt { get; set; }
    
        public virtual Cloth Cloth { get; set; }
        public virtual Season Season { get; set; }
        public virtual Status_model Status_model { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<More> More { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordedrs> Ordedrs { get; set; }
    }
}
