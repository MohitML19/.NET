using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;
namespace DLL
{
    public class HRManager
    {
        public List<Department> GetDepartments()
        {
            List<Department> list = new List<Department>();
            list = DBManager.allDepartments();
            return list;
        }
    }
}
