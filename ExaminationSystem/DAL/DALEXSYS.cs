using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExaminationSystem.DAL
{
    public static class DALEXSYS
    {

        //connection with database
        public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Examination_SystemDB;Integrated Security=True");

        // Select
        public static DataTable select(SqlCommand _cmd)
        {
            DataTable _dt = new DataTable();
            _cmd.Connection = con;
            SqlDataAdapter _adabter = new SqlDataAdapter(_cmd);
            _adabter.Fill(_dt);
            return _dt;
        }

        public static int DML(SqlCommand _cmd)
        {
            _cmd.Connection = con;
            con.Open();
            int result = _cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static DataSet selectds(SqlCommand _cmd)
        {
            DataSet _ds = new DataSet();
            _cmd.Connection = con;
            SqlDataAdapter _adabter = new SqlDataAdapter(_cmd);
            _adabter.Fill(_ds);
            return _ds;
        }

    }
}
