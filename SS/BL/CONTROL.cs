using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SS.BL
{
    class CONTROL
    {
        DAL.ACESSLAYER dal = new DAL.ACESSLAYER();
        DataTable dt = new DataTable();
        public DataTable prof_login(string id)
        {
            string y, x = string.Empty;
            y = Convert.ToString(DateTime.Now.ToLongTimeString());
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = id;
            param[1] = new SqlParameter("@TIME ", SqlDbType.Time, 7);
            param[1].Value = y;
            dt = dal.selectdata("prof_login", param);
            return dt;
        }
        public DataTable loginuser(string id)
        {
            
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = dal.selectdata("loginuser", param);
            return dt;
        }
        public DataTable ALLLECTURE()
        {
            dt = dal.selectdata("ALLLECTURE", null);
            return dt;
        }
        public DataTable ALLLSTUDENTS()
        {
            dt = dal.selectdata("ALLLSTUDENTS", null);
            return dt;
        }
        public DataTable ALLUSERS()
        {
            dt = dal.selectdata("ALLUSERS", null);
            return dt;
        }
        public DataTable ALL_PROF()
        {
            dt = dal.selectdata("ALL_PROF", null);
            return dt;
        }
        public DataTable endlec()
        {
            string y = string.Empty;
            y = Convert.ToString(DateTime.Now.ToLongTimeString());
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TIME ", SqlDbType.Time, 7);
            param[0].Value = y;
            dt = dal.selectdata("endlec", param);
            return dt;
        }
        public DataTable verify_stu(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = id;
            dt = dal.selectdata("verify_stu", param);
            return dt;
        }
        public void insertstu(string stu_name, string lec_name, string doc_name, int stage, string id)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar, 20);
            param[0].Value = stu_name;
            param[1] = new SqlParameter("@Stage", SqlDbType.Int);
            param[1].Value = stage;
            param[2] = new SqlParameter("@doc_name", SqlDbType.VarChar, 20);
            param[2].Value = doc_name;
            param[3] = new SqlParameter("@lec_name", SqlDbType.VarChar, 20);
            param[3].Value = lec_name;
            param[4] = new SqlParameter("@stuid", SqlDbType.VarChar, 20);
            param[4].Value = id;
            dal.Open();
            dal.excutecommond("insertstu", param);
            dal.Close();
        }
        public DataTable allstu(int stage)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Stage", SqlDbType.Int);
            param[0].Value = stage;
            dt = dal.selectdata("allstu", param);
            return dt;
        }
        public DataTable allINCLASSstu()
        {
            dt = dal.selectdata("allINCLASSstu", null);
            return dt;
        }
        public DataTable PRallINCLASSstu()
        {
            dt = dal.selectdata("PRallINCLASSstu", null);
            return dt;
        }
        public DataTable allstu(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Stage", SqlDbType.Int);
            param[0].Value = id;
            dt = dal.selectdata("allstu", param);
            return dt;
        }
        public void deletestu(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 20);
            param[0].Value = id;
            dal.Open();
            dal.excutecommond("deletestu", param);
            dal.Close();
        }
        public void CLEARCLASS()
        {
            dal.Open();
            dal.excutecommond("CLEARCLASS",null);
            dal.Close();
        }

        public void addprof(string name, string id)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar,25);
            param[0].Value = name;
            param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[1].Value = id;
            dal.Open();
            dal.excutecommond("addprof", param);
            dal.Close();
        }
        public void updateprof(string name, string id)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 25);
            param[0].Value = name;
            param[1] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[1].Value = id;
            dal.Open();
            dal.excutecommond("updateprof", param);
            dal.Close();
        }
        public void DELPROF( string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[0].Value = id;
            dal.Open();
            dal.excutecommond("DELPROF", param);
            dal.Close();
        }
        public DataTable STAGES()
        {
            dt = dal.selectdata("STAGES", null);
            return dt;
        }
        public void addstu(string name, string id,int stage)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar, 25);
            param[0].Value = name;
            param[1] = new SqlParameter("@ID", SqlDbType.NVarChar, 25);
            param[1].Value = id;
            param[2] = new SqlParameter("@stage", SqlDbType.Int );
            param[2].Value = stage;
            dal.Open();
            dal.excutecommond("addstu", param);
            dal.Close();
        }
        public void UPDATEstu(string name, string id, int stage)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar, 25);
            param[0].Value = name;
            param[1] = new SqlParameter("@ID", SqlDbType.NVarChar, 25);
            param[1].Value = id;
            param[2] = new SqlParameter("@stage", SqlDbType.Int);
            param[2].Value = stage;
            dal.Open();
            dal.excutecommond("UPDATEstu", param);
            dal.Close();
        }
        public void delstu(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 25);
            param[0].Value = id;
            dal.Open();
            dal.excutecommond("delstu", param);
            dal.Close();
        }
        public void adduser(string name, string id, string pos)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[1].Value = id;
            param[2] = new SqlParameter("@POSTION", SqlDbType.NVarChar, 50);
            param[2].Value = pos;
            dal.Open();
            dal.excutecommond("adduser", param);
            dal.Close();
        }
        public void updateuser(string name, string id, string pos)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@NAME", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[1].Value = id;
            param[2] = new SqlParameter("@POSTION", SqlDbType.NVarChar, 50);
            param[2].Value = pos;
            dal.Open();
            dal.excutecommond("updateuser", param);
            dal.Close();
        }
        public void deluser(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            dal.Open();
            dal.excutecommond("deluser", param);
            dal.Close();
        }
        public void addSTAGE(string name, int id)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 20);
            param[0].Value = name;
            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = id;
            dal.Open();
            dal.excutecommond("addSTAGE", param);
            dal.Close();
        }
        public void updateSTAGE(string name, int id)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 20);
            param[0].Value = name;
            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = id;
            dal.Open();
            dal.excutecommond("updateSTAGE", param);
            dal.Close();
        }
        public void delSTAGE(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.Open();
            dal.excutecommond("delSTAGE", param);
            dal.Close();
        }
        public DataTable search_PROF(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,25);
            param[0].Value = id;
            dt = dal.selectdata("search_PROF", param);
            return dt;
        }
        public DataTable search_stu(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[0].Value = id;
            dt = dal.selectdata("search_stu", param);
            return dt;
        }
        public DataTable search_USERS(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = dal.selectdata("search_USERS", param);
            return dt;
        }
        public DataTable search_STAGE(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 20);
            param[0].Value = id;
            dt = dal.selectdata("search_STAGE", param);
            return dt;
        }
        public DataTable SERAECH_LECTURE(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[0].Value = id;
            dt = dal.selectdata("SERAECH_LECTURE", param);
            return dt;
        }
        public void addlec(string lecname,  string place, string profid, int lecstage, string day)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@lecname", SqlDbType.NVarChar, 25);
            param[0].Value = lecname;
            param[1] = new SqlParameter("@place", SqlDbType.NVarChar, 25);
            param[1].Value = place;
            param[2] = new SqlParameter("@profid", SqlDbType.NVarChar, 25);
            param[2].Value = profid;
            param[3] = new SqlParameter("@lecstage", SqlDbType.Int);
            param[3].Value = lecstage;
            param[4] = new SqlParameter("@day", SqlDbType.NVarChar, 25);
            param[4].Value = day;
            dal.Open();
            dal.excutecommond("addlec", param);
            dal.Close();
        }
        public void updatelec(string lecname, string place, string profid, int lecstage, string day)
        {
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@lecname", SqlDbType.NVarChar, 25);
            param[0].Value = lecname;
            param[1] = new SqlParameter("@place", SqlDbType.NVarChar, 25);
            param[1].Value = place;
            param[2] = new SqlParameter("@profid", SqlDbType.NVarChar, 25);
            param[2].Value = profid;
            param[3] = new SqlParameter("@lecstage", SqlDbType.Int);
            param[3].Value = lecstage;
            param[4] = new SqlParameter("@day", SqlDbType.NVarChar, 25);
            param[4].Value = day;
            dal.Open();
            dal.excutecommond("updatelec", param);
            dal.Close();
        }
        public void deldatelec(string lecname)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@lecname", SqlDbType.NVarChar, 25);
            param[0].Value = lecname;
            dal.Open();
            dal.excutecommond("deldatelec", param);
            dal.Close();
        }
    }
}
