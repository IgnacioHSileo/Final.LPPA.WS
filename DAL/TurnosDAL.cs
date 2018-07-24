using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Entity;
using System;


namespace DAL
{
    public class TurnosDAL
    {
 
            public static int Insert(TurnosBLL turnos)
            {
                int ret = 0;
            ret = DataAccess.Instance.Write("Turnos_insert",
                                            CommandType.StoredProcedure,
                                            new SqlParameter[] {DataAccess.CreateParameter("Id", turnos.ID),
                                                                DataAccess.CreateParameter("Paciente", turnos.Paciente),
                                                                DataAccess.CreateParameter("Medico", turnos.Medico),
                                                                DataAccess.CreateParameter("Dia", turnos.Dia),
                                                                DataAccess.CreateParameter("Hora", turnos.Hora) });
                                                             
                return ret;
            }

        public static List<TurnosBLL> GetAll()
        {
            List<TurnosBLL> turnos = new List<TurnosBLL>();
            DataTable table = DataAccess.Instance.Read("Turnos_Select", CommandType.StoredProcedure);

            foreach (DataRow row in table.Rows)
            {
                turnos.Add(ConvertRow(row));
            }
                return turnos;
        }


        private static TurnosBLL ConvertRow(DataRow row)
        {
            TurnosBLL turnos = null;
            if (row != null)
            {
                turnos = new TurnosBLL();
                turnos.ID = Int32.Parse(row[0].ToString());
                turnos.Paciente = row[1].ToString();
                turnos.Medico = row[2].ToString();
                turnos.Dia = row[3].ToString();
                turnos.Hora = row[4].ToString();

            }
            return turnos;
        }
    }
}




