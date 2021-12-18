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
    using System.ComponentModel.DataAnnotations;

    public partial class Modification
    {
        public Modification()
        {
            this.Part = new HashSet<Part>();
        }
    
        public int id_mod { get; set; }
        
        [Required]
        [StringLength(30)]
        public string nameMod { get; set; }
        [Required]
        [Range(0.01, 2)]
        public Nullable<double> LabourInput { get; set; }
    
        public virtual ICollection<Part> Part { get; set; }
    }
}
