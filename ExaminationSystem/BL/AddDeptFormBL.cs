using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL;

namespace ExaminationSystem.BL
{
    public static class AddDeptFormBL
    {
        public static DataTable GetDepts()
        {
            SqlCommand cmd = new SqlCommand("GetDeptsForStaff");
            return DALEXSYS.select(cmd);
        }

        public static int AddNewDept(string _Dept_Name, string _Dept_Desc)
        {
            SqlCommand cmd = new SqlCommand("AddNewDeptForStaff @Dept_Name, @Dept_Desc");
            cmd.Parameters.AddWithValue("Dept_Name", _Dept_Name);
            cmd.Parameters.AddWithValue("Dept_Desc", _Dept_Desc);
            return DALEXSYS.DML(cmd);
        }
        public static int UpdateDept(int _Dept_ID, string _Dept_Name, string _Dept_Desc)
        {
            SqlCommand cmd = new SqlCommand("UpdateDeptForStaff @Dept_ID, @Dept_Name, @Dept_Desc");
            cmd.Parameters.AddWithValue("@Dept_ID", _Dept_ID);
            cmd.Parameters.AddWithValue("@Dept_Name", _Dept_Name);
            cmd.Parameters.AddWithValue("@Dept_Desc", _Dept_Desc);
            return DALEXSYS.DML(cmd);
        } 
    }
}
