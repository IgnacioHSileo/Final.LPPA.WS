using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using DAL;
using NegocioService;
using NegocioService.DTO;

namespace LPPA.FINAL.WS.v1
{
    public partial class Turnos : System.Web.UI.Page
    {

        private TurnosService _turnosService;

        public TurnosService TurnosService
        { 
            get
            {
                if (_turnosService == null)
                    _turnosService = new TurnosService();

                return _turnosService;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //List<TurnosDTO> turnos = TurnosService.GetAll();
            //Cmboxmed.DataSource = turnos;
            //Cmboxmed.DataBind();


        }

        protected void  Cale_SelectionChanged (object sender, EventArgs e)
        {
            string dia;
            dia = Cale.SelectedDate.ToShortDateString();
            List<HorariosDTO> turnos = HorariosService.GetAll(dia);
                Cmboxhs.DataSource = turnos;
                Cmboxhs.DataBind();

            
        }

        //protected void Unnamed4_SelectedIndexChanged(object sender, EventArgs e, string Hora)
        //{
        //    List<TurnosDTO> turnos = TurnosService.GetAll(Hora);
        //    Cmboxhs.DataSource = turnos;
        //    Cmboxhs.DataBind();


    }
}