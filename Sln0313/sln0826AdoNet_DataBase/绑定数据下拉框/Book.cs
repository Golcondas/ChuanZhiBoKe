using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 绑定数据下拉框
{
    public class Book
    {
        private string _vBMCode;
        private string _nBMMC;

        /// <summary>
        /// 部门Code
        /// </summary>
        public string vBmCode
        {
            get { return _vBMCode; }
            set { _vBMCode = value; }
        }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string nBMMC
        {
            get { return _nBMMC; }
            set { _nBMMC = value; }
        }
    }
}
