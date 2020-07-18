using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfectcionAmbientalWeb.ViewModels
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = @"el ""Apellido""es obligatorio:")]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Display(Name = "Su fotografía")]
        public IFormFile FotografiaPerfil { get; set; }
    }
}
