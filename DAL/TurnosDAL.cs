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
                                                                //DataAccess.CreateParameter("Dv", registro.GetDV(Convert.ToString(registro.ID) +
                                                                //                                                Convert.ToString(registro.Nombre) +
                                                                //                                                C onvert.ToString(registro.Apellido) +
                                                                //                                                Convert.ToString(registro.Email) +
                                                                //                                                Convert.ToString(registro.Edad)))});
                return ret;
            }

        public static List<TurnosBLL> GetAll(string Dia)
        {
            List<TurnosBLL> turnos = new List<TurnosBLL>();
            DataTable table = DataAccess.Instance.Read("Turnos_Select", CommandType.StoredProcedure,
                                                        new SqlParameter[] { DataAccess.CreateParameter("Dia", Dia) });
            //foreach (DataRow row in table.Rows) { registros.Add(Conv(row)); }
            return turnos;
        }

        //private static TurnosBLL Conv(DataRow row)
        //{
        //    TurnosBLL turnos = null;
        //    if (row != null)
        //    {
        //    turnos = new TurnosBLL();
        //    turnos.DV = Int32.Parse(row[5].ToString());
        //    }
        //    return turnos;
        //}
    }
}




