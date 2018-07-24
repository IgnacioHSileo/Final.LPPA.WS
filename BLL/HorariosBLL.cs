using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class HorariosBLL
    {
        public HorariosBLL() { }

        public HorariosBLL(int Id)
        {

        }


        #region Properties

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string horario;
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        #endregion
    }
}



