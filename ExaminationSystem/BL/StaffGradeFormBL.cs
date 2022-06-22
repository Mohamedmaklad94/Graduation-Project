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
    public static class StaffGradeFormBL
    {
        public static DataTable GetGradesStuff(string _Crs_Name)
        {
            SqlCommand cmd = new SqlCommand("GetGradesForStaff @Crs_Name");
            cmd.Parameters.AddWithValue("Crs_Name", _Crs_Name);
            return DALEXSYS.select(cmd);
        }
    }
}
