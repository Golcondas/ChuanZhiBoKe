using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 数据库操作
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //连接
            //p.ConnectionData();

            //新增
            //p.AddData();

            //删除
            //p.DeletData();

            //软删除
            //p.SoftDeleteData();

            //查找单个数据
            //p.QuerySingleData();

            //查找单条数据
            //p.QueryOneLineData();

            //查找
            //p.QueryGetStringData();

            //p.QueryTableData();

            //p.QueryTableAdData();

            //p.QueryByProcedure();

            p.QueryByMutilProcedure();
            Console.ReadKey();
        }

        #region 1.连接
        public void ConnectionData()
        {
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            Console.Write("连接成功!");

            con.Close();
            Console.Write("连接成功!");
            Console.ReadKey();
        }
        #endregion

        #region 2.新增
        public void AddData()
        {
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str;
            string s = "insert into M_BM (vBMCode,nBMMC) values('Nibs01','宝山')";
            con.Open();
            SqlCommand cmd = new SqlCommand(s, con);
            int resultRows = 0;
            resultRows = cmd.ExecuteNonQuery();
            con.Close();
            Console.Write("成功插入:" + resultRows);
            Console.ReadKey();
        } 
        #endregion

        #region 3.删除
        public void DeletData()
        {
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            string sql = "delete from M_BM where iBMID='49'";
            SqlCommand cmd = new SqlCommand(sql,con);
            con.Open();
            int resultRow = 0;
            resultRow = cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine(resultRow);
            Console.ReadKey();
        } 
        #endregion

        #region 4.软删除
        public void SoftDeleteData()
        {
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string sql = "update M_BM set cIsRemove='1' where iBMID='51'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int result = 0;
            result = cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("软删除了：" + result);
            Console.ReadKey();
        } 
        #endregion

        #region 5.查找单条数据
        /// <summary>
        /// 5.查找单条数据
        /// </summary>
        public void QuerySingleData()
        {
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str;
            con.Open();
            string sql = "select * from M_BM where iBMID='51'";
            SqlCommand cmd = new SqlCommand(sql, con);
            var obj=cmd.ExecuteScalar();
            Console.WriteLine(obj);
            Console.ReadKey();
            con.Close();
        } 
        #endregion


        #region 6.查找一条数据
        public void QueryOneLineData()
        {
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 20;
            //string sql = "select * from M_BM where iBMID='51'";
            string sql = "select * from M_BM";
            cmd.CommandText = sql;
            cmd.Connection = con;
            //SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dr =cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Console.WriteLine("有数据");
                int i = 0;
                while (dr.Read())
                {
                    Console.WriteLine(i+++"  "+dr[0].ToString() + "_" + dr[1].ToString());
                }
            }
            else
            {
                Console.WriteLine("没有数据");
            }
            dr.Close();
            con.Close();
            Console.ReadKey();
        } 
        #endregion

        #region 6.1查找一条数据
        public void QueryGetStringData()
        {
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 20;
            //string sql = "select * from M_BM where iBMID='51'";
            string sql = "select * from M_BM";
            cmd.CommandText = sql;
            cmd.Connection = con;
            //SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Console.WriteLine("有数据");
                while (dr.Read())
                {
                    System.Console.WriteLine(dr.GetValue(0)+" "+dr.GetString(2));
                }
            }
            else
            {
                Console.WriteLine("没有数据");
            }
            dr.Close();
            con.Close();
            Console.ReadKey();
        }
        #endregion

        #region 7.一整个表(使用适配器读取数据)
        /// <summary>
        /// 一整个表(使用适配器读取数据)
        /// </summary>
        public void QueryTableData()
        {
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string sql = "select * from M_BM";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i=0;i<dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
            }

            con.Close();

        } 
        #endregion

        #region 7.1一整个表(使用适配器填充数表)
        /// <summary>
        /// 一整个表(使用适配器填充数据表)
        /// </summary>
        public void QueryTableAdData()
        {
            Console.WriteLine("一整个表(使用适配器填充数据)");
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string sql = "select * from M_BM";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
            }

            con.Close();
            Console.ReadKey();
        }
        #endregion

        #region 8.调用存储过程(单个参数)
        /// <summary>
        /// 8.调用存储过程(单个参数)
        /// </summary>
        public void QueryByProcedure()
        {
            Console.WriteLine("8.调用存储过程");
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("ChuanZhiBoKeTest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sp = new SqlParameter();
            sp.ParameterName = "@id";
            sp.SqlDbType = SqlDbType.Int;
            sp.SqlValue = 51;
            cmd.Parameters.Add(sp);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
            }
            con.Close();
        }
        #endregion

        #region 8.调用存储过程(多个参数)
        /// <summary>
        /// 8.调用存储过程(单个参数)
        /// </summary>
        public void QueryByMutilProcedure()
        {
            Console.WriteLine("8.调用存储过程(多个参数)");
            string str = "server=.;database=CRM_Study;uid=sa;pwd=sa;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("ChuanZhiBoKeTest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter sp = new SqlParameter();
            //sp.ParameterName = "@id";
            //sp.SqlDbType = SqlDbType.Int;
            //sp.SqlValue = 51;
            //cmd.Parameters.Add(sp);
            SqlParameter[] param =
            {
                new SqlParameter("@nBMMC", SqlDbType.VarChar, 50),
                new SqlParameter("@cIsRemove", SqlDbType.Char, 1)
            };

            param[0].Value = "宝山";
            param[1].Value = "0";

            cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
            }
            con.Close();
        }
        #endregion
    }
}
