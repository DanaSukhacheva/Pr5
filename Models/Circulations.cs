//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pr5BB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Circulations
    {
        public long ID_circulation { get; set; }
        public int quantity { get; set; }
        public System.DateTime print_data { get; set; }
    
        public virtual Albums Albums { get; set; }
    }
}
