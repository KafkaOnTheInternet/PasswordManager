using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class User
    {
        int id;
        String passwd;
        public SqlConnection con;

        public User(int id, string passwd)
        {
            this.id = id;
            this.passwd = passwd;

            this.con = null;
        }

        public void AddWebsite()
        {

        }
        public bool AuthUser()
        {
            return false;
        }
        public String TestDB()
        {
 
            String connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rupal\source\repos\PasswordManager\PasswordManager\Database1.mdf;Integrated Security=True";
            String ret = "Nothing happened";
            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                ret = "Started connection successfully";
                Console.WriteLine("Started connection successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("Fucky wucky " + e);
                ret = "Fucky wucky" + e;
            }
            finally
            {
                con.Close();
            }
            return ret;
        }

    }


}
