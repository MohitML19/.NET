using BOL;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using System.Transactions;

namespace DAL
{
    public class DBManager
    {
        public static string conString =@"server=localhost;port=3306;user=root;password=root;database=test";
        public static List<Department> allDepartments()
        {
            List<Department> list = new List<Department>();
           MySqlConnection con = new MySqlConnection(conString);
            con.ConnectionString = conString;
            string query = "select * from departments";

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string location = reader["location"].ToString();

                    Department dept = new Department { 
                        Id = id,
                        Name = name,
                        Location = location
                    };
                    list.Add(dept);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally { con.Close(); }
            return list;
        } 
        
        public static Department getDepartment(int id)
        {
            Department d1 = null;
            MySqlConnection con1 = new MySqlConnection(conString);
            con1.ConnectionString = conString;

            try
            {
                string query = "select * from departments where id =" + id;
                con1.Open();
                MySqlCommand cmd = new MySqlCommand(query,con1);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string location = reader["location"].ToString();

                    d1 = new Department
                    {
                        Id = id,
                        Name = name,
                        Location = location
                    };
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally { con1.Close(); }

            return d1;
            

        }

        public static bool insertDept(Department dept)
        {
            bool status = false;
            string query = "INSERT INTO departments(name,location)" +
                            "VALUES('" + dept.Name + "','" + dept.Location + "')";
            MySqlConnection conn = new MySqlConnection(conString);
            conn.ConnectionString = conString;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query,conn);
                cmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return status;
        }

    }
}