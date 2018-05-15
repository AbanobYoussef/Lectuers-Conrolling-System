using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SS.DAL
{
    class ACESSLAYER
    {
        SqlConnection sqlcon;
        public ACESSLAYER()
        {
            sqlcon = new SqlConnection(@"Server=MAX_DOMA\SQLEXPRESS;Database=DOOR;Integrated Security=true");
        }
        public void Open()
        {
            if (sqlcon.State != ConnectionState.Open)
                sqlcon.Open();
        }
        public void Close()
        {
            if (sqlcon.State == ConnectionState.Open)
                sqlcon.Close();
        }
        public DataTable selectdata(string stored_prog, SqlParameter[] param)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.CommandText = stored_prog;
            sqlcom.Connection = sqlcon;
            if(param !=null)
            {
                for(int i=0;i<param.Length;i++)
                {

                    sqlcom.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void excutecommond(string stored_prog, SqlParameter[] param)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.CommandText = stored_prog;
            sqlcom.Connection = sqlcon;
            if (param != null)
            {
                sqlcom.Parameters.AddRange(param);
            }
            sqlcom.ExecuteNonQuery();
        }
    }
}
