﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidad.Usuario
{
    public class Rol
    {
        [Key]
        public int idrol { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre no debe de tener más de 30 caracteres, ni menos de 3 caracteres.")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        public ICollection<Usuario> usuarios { get; set; }
    }
}
