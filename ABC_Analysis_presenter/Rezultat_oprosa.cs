//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABC_Analysis_presenter
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezultat_oprosa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rezultat_oprosa()
        {
            this.Opros = new HashSet<Opro>();
        }
    
        public int ID_rezultat_oprosa { get; set; }
        public int Kvantil { get; set; }
        public int Mediana { get; set; }
        public System.DateTime Data { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opro> Opros { get; set; }
    }
}
