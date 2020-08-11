using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AfectcionAmbientalWeb.Models
{
    public class PersonaCelular {
        [Key]
        public int PersonaCelularId  {get; set; }
        [ForeignKey(name:"Persona")]
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        [ForeignKey(name: "Celular")]
        public int CelularId { get; set; }
        public Celular Celular { get; set; }
    }
}