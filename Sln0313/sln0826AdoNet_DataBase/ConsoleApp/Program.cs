using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using log4net;
using log4net.Config;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp
{
    class Program
    {
        private static string str = "server=127.0.0.1;database=27.CRMIntegrated;uid=sa;pwd=sa;";
        private static SqlConnection con = new SqlConnection(str);

        static void Main(string[] args)
        {
            Console.WriteLine("Begin Run");
            XmlConfigurator.Configure();
            Type type = MethodBase.GetCurrentMethod().DeclaringType;
            ILog m_log = LogManager.GetLogger(type);
            m_log.Debug("这是一个Debug日志");
            m_log.Info("这是一个Info日志");
            m_log.Warn("这是一个Warn日志");
            m_log.Error("这是一个Error日志");
            m_log.Fatal("这是一个Fatal日志");
            Console.WriteLine("End");
            AddData();
            Console.ReadLine();
        }

        #region 1.添加数据
        /// <summary>
        /// 添加数据
        /// </summary>
        public static void AddData()
        {
            con.Open();
            string sql = "insert into M_BM (vBMCode,nBMMC) values('BM00005','技术部')";
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("插入数据的了:" + i + "条");

            con.Close();
        }
        #endregion


        #region 2.删除数据
        /// <summary>
        /// 删除
        /// </summary>
        public static void DeleteData()
        {
            con.Open();
            Console.Write("请输入要删除的ID=");
            string a = Console.ReadLine();
            string sql = "delete from M_BM where iBMID=" + a;
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("删除成功!");
            }
            else
            {
                Console.WriteLine("删除失败");
            }
            con.Close();
        }
        #endregion

        #region 3.修改数据
        /// <summary>
        /// 修改数据
        /// </summary>
        public static void UpdateData()
        {
            con.Open();
            Console.WriteLine("输入需要更新的ID");
            string a = Console.ReadLine();
            string sql = "update M_BM set cIsRemove=1 where iBMID=" + a;
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("修改成功");
            }
            else
            {
                Console.WriteLine("删除失败");
            }
            con.Close();
        }
        #endregion

        #region 4.查找(参数)
        /// <summary>
        /// 查找数据
        /// </summary>
        /// <returns></returns>
        public static void QueryData()
        {
            con.Open();
            Console.WriteLine("查找ID=");
            string a = Console.ReadLine();
            string sql = string.Format("select * from M_BM where iBMID={0}",a);
            SqlCommand cmd = new SqlCommand(sql, con);
            //SqlParameter ps = new SqlParameter();
            //ps.ParameterName = "@ID";
            //ps.SqlDbType = SqlDbType.Int;
            //ps.SqlValue = Convert.ToInt32(a);
            //cmd.Parameters.Add(ps);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "M_BM");
            foreach (DataRow rows in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3}", rows[0], rows[1], rows[2], rows[3]);
            }

            con.Close();
        }
        #endregion


        #region 5.查找（Dataset）
        /// <summary>
        /// 查找
        /// </summary>
        public static void QueryParamData()
        {
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
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow rows in dt.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3}", rows[0], rows[1], rows[2], rows[3]);
            }

            con.Close();
        }
        #endregion

        public void add()
        {
            con.Open();
            string sql = "insert into M_BM (vBMCode,nBMMC) values('BM00005','技术部')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void QueryTest()
        {
            con.Open();
            string strSql = "select * from M_BM";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            DataSet ds = new DataSet();
            da.Fill(ds, "好表");
            DataTable dt = new DataTable();
            //ds.Tables.Add(dt);
            dt = ds.Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine("{0}  {1}", dt.Rows[i]["vBMCode"].ToString(), dt.Rows[i]["nBMMC"].ToString());
                }
            }

            con.Close();

        }
    }
}
