using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Entity;
using System;


namespace DAL
{
    public  class HorarioDAL
    {
        public static HorariosBLL GetByDia(string Dia)
        {
            HorarioDAL horario = null;
            DataTable table = DataAccess.Instance.Read("Horarios_Select", CommandType.StoredProcedure, new SqlParameter[]{
               DataAccess.CreateParameter("Dia", Dia)});

            if (table.Rows.Count == 1)
                horario = Convert(table.Rows[0]);

            return horario;
        }

        private static HorariosBLL Convert(DataRow row)
        {
            HorariosBLL horarios = null;
            if (row != null)
            {
                horarios = new HorariosBLL();
                horarios.ID = Int32.Parse(row[0].ToString());
                horarios.Horario = row[1].ToString();


            }   
            return horarios;
        }
    }
}
