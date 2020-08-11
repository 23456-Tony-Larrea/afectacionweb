using AfectcionAmbientalWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfectcionAmbientalWeb.Interfaces
{
    public interface IPersona
    {
        [Key]
         int PersonaId { get; set; }
        
         string Nombre { get; set; }
        
         string Apellido { get; set; }
         Celular Celular { get; set; }
         byte[] FotografiaPerfil { get; set; }
        
         string FotografiaBase64 { get; set; }
        public List<PersonaCelular> PersonaCelular { get; set; }
    }

}
