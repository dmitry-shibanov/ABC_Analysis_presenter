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
    
    public partial class Uslugy
    {
        public int ID_kategory { get; set; }
        public decimal Prise { get; set; }
        public Nullable<int> ID_uslugy { get; set; }
        public string Naimenovanie { get; set; }
    
        public virtual Kategory Kategory { get; set; }
    }
}
