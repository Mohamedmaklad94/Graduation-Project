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
    public static class StudInfoFormBL
    {
        public static DataTable GetStudInfo(int _St_ID)
        {
            SqlCommand cmd = new SqlCommand("GetStudInfo " + _St_ID);
            return DALEXSYS.select(cmd);
        }
    }
}
