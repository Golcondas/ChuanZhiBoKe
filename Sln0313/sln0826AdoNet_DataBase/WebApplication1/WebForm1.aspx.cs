using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using log4net.Config;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static string str = @"server=127.0.0.1;database=27.CRMIntegrated;uid=sa;pwd=sa;";
        private static SqlConnection con = new SqlConnection(str);
        protected void Page_Load(object sender, EventArgs e)
        {
             //创建日志记录组件实例
            ILog gSqlLog = log4net.LogManager.GetLogger("SQL");
            con.Open();
            Console.WriteLine("查找ID=");
            string a = Console.ReadLine();
            string sql = "select * from M_BM where iBMID=@ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter ps = new SqlParameter();
            ps.ParameterName = "@ID";
            ps.SqlDbType = SqlDbType.Int;
            ps.SqlValue = Convert.ToInt32(a);
            cmd.Parameters.Add(ps);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "M_BM");
            foreach (DataRow rows in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3}", rows[0], rows[1], rows[2], rows[3]);
            }
            con.Close();
        }
    }
}