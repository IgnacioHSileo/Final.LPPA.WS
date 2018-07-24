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
    public class HorariosService
    { 


        public static List<HorariosDTO> GetByDia(string Dia)
        {
            List<HorariosDTO> ret = new List<HorariosDTO>();
            List<HorariosBLL> turnos = HorarioDAL.GetByDia(Dia);

            return ret;
        }
    }
}
