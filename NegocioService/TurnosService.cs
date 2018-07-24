using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using NegocioService.DTO;
using NegocioService;

namespace NegocioService
{
    public class TurnosService
    {


        public static List<TurnosDTO> GetAll(string Hora)
        {
            List<TurnosDTO> ret = new List<TurnosDTO>();
            List<TurnosBLL> turnos = TurnosDAL.GetAll(Hora);

            return ret;
        }

      
    }
}
