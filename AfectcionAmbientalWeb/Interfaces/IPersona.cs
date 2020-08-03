using AfectcionAmbientalWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectcionAmbientalWeb.Interfaces
{
    public interface IPersona
    {
         int Id { get; set; }
        
         string Nombre { get; set; }
        
         string Apellido { get; set; }
         Celular Celular { get; set; }
         byte[] FotografiaPerfil { get; set; }
        
         string FotografiaBase64 { get; set; }
    }
}
