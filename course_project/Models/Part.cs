//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace course_project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Part
    {
        public Part()
        {
            this.Modification = new HashSet<Modification>();
            this.Machine = new HashSet<Machine>();
        }
    
        public int id_part { get; set; }
        public string namePart { get; set; }
        public string firmPart { get; set; }
    
        public virtual ICollection<Modification> Modification { get; set; }
        public virtual ICollection<Machine> Machine { get; set; }
    }
}