//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;


    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Proyecto = new HashSet<Proyecto>();
        }

        [Key]
        [Required(ErrorMessage = "El campo es requerido")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Caracteres invalidos")]
        [StringLength(12, MinimumLength = 9, ErrorMessage = "La c�dula debe estar entre un rango de 9 a 12 digitos")]
        public string cedula { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [RegularExpression("^[a-zA-z]*$", ErrorMessage = "Caracteres invalidos")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [RegularExpression("^[a-zA-z]*$", ErrorMessage = "Caracteres invalidos")]
        public string apellido1 { get; set; }

        [RegularExpression("^[a-zA-z]*$", ErrorMessage = "Caracteres invalidos")]
        public string apellido2 { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Caracteres invalidos")]
        public string telefono { get; set; }

        [RegularExpression("^[a-zA-z]*$", ErrorMessage = "Caracteres invalidos")]
        public string direccionExacta { get; set; }
        public string distrito { get; set; }
        public string canton { get; set; }
        public string provincia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto> Proyecto { get; set; }
    }
}
