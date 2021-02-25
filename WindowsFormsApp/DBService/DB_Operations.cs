using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.DBService
{
    public class DB_Operations
    {
        private string conStr = @"Data Source=CL-LK-03; Initial Catalog=POS;Integrated Security=True";
        //tharinda
        //private string conStr = @"Data Source=DESKTOP-MVPCO3O; Initial Catalog=POS;Integrated Security=True";
        //jazal
        //private string conStr = @"Data Source=DESKTOP-FIDBVES; Initial Catalog=POS;Integrated Security=True";
        private SqlConnection con;

        public DB_Operations()
        {
            con = new SqlConnection(conStr);
        }
        public bool exeQuery(string qry)
        {

            try
            {
                con.Open();
                new SqlCommand(qry, con).ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;

            }
            finally
            {
                con.Close();
            }
        }

        public DataSet selData(String q)
        {
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
