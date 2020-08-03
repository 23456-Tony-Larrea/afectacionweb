using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectcionAmbientalWeb.Interfaces
{
    public interface ICelular
    {
        int Id { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        
    }
}
