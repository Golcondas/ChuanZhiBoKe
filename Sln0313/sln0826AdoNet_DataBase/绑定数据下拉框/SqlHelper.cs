using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 绑定数据下拉框
{
    public class SqlHelper
    {
        private static string str = "server=127.0.0.1;database=Ex;uid=sa;pwd=sa;";
        private static SqlConnection conn;

        #region 连接
        /// <summary>
        /// 链接
        /// </summary>
        public static SqlConnection con
        {
            get
            {

                if (conn == null || conn.State == ConnectionState.Broken)
                {
                    conn = new SqlConnection(str);
                }
                return conn;
            }
        } 
        #endregion


        #region 获取数据表
        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sqlStr, params SqlParameter[] param)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            if (param!=null&&param.Length > 0)
            {
                cmd.Parameters.AddRange(param);
                //多个
                //foreach (SqlParameter sp in param)
                //{
                //    cmd.Parameters.Add(sp);
                //}
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            con.Close();
            return dt;
        } 
        #endregion
    }
}
