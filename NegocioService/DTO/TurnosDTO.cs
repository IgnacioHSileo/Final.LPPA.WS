using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioService.DTO
{
    public class TurnosDTO
    {
        public int Id { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }

    }
}
