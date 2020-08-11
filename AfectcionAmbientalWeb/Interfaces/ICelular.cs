using AfectcionAmbientalWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfectcionAmbientalWeb.Interfaces
{
    public interface ICelular
    {
       [Key]
        int CelularId { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        public List<PersonaCelular> PersonaCelular { get; set; }
    }
}
