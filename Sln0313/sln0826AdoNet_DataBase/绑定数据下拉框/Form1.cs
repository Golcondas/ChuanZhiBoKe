using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 绑定数据下拉框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDept();
            LoadDatagrid();
        }

        /// <summary>
        /// 部门
        /// </summary>
        public void LoadDept()
        {
            string strSql = "select * from M_BM";
            DataTable dt=SqlHelper.GetDataTable(strSql);
            //MessageBox.Show(dt.Rows.Count.ToString());
            foreach(DataRow dr in dt.Rows)
            {
                Book m = new Book();
                m.vBmCode = dr["vBmCode"].ToString();
                m.nBMMC = dr["nBMMC"].ToString();
                cobDeptName.Items.Add(m);
            }
            cobDeptName.DisplayMember = "nBMMC";
            cobDeptName.ValueMember = "vBmCode";
            cobDeptName.SelectedIndex = 0;
        }

        public void LoadDatagrid()
        {
            string strSql = "select * from M_BM";
            DataTable dt = SqlHelper.GetDataTable(strSql);
            dgvInfo.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text.Trim();
            string cateID = ((Book)cobDeptName.SelectedItem).vBmCode;
            string sql = "select vBmCode,nBMMC from M_BM where vBMCode like @vBMCode";
            SqlParameter[] param = {new SqlParameter(
                    "@vBMCode",string.Format("%{0}%",key))
                                   };
            //param.ParameterName = "@vBMCode";
            //param.SqlValue = key;
            DataTable dt = SqlHelper.GetDataTable(sql, param);
            dgvInfo.DataSource = dt;
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //MessageBox.Show(rowIndex.ToString());
            txtName.Text = dgvInfo.Rows[rowIndex].Cells["nBMMC"].Value.ToString();
        }


    }
}
