using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class TurnosBLL
    {
        public TurnosBLL() { }

        public TurnosBLL(int Id)
        {
           
        }


        #region Properties

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string paciente;
        public string Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        private string medico;
        public string Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        private string dia;
        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        private string hora;
        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
    
        #endregion
    }
}



