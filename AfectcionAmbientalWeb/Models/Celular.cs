using AfectcionAmbientalWeb.Interfaces;
using System.Collections.Generic;

namespace AfectcionAmbientalWeb.Models
{
    public class Celular : ICelular
    {

        public int CelularId { get ; set ; }
        public string Marca { get; set; }
        public string Modelo { get ; set; }
       public List<PersonaCelular> PersonaCelular { get ; set ; }
    }
}