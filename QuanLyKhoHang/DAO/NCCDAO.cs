using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.DAO
{
    public class NCCDAO
    {
        private static NCCDAO instance;
        public static NCCDAO Instance
        {
            get {if(instance == null) instance = new NCCDAO(); return NCCDAO.instance;}
            private set { NCCDAO.instance = value; }
        }

        public bool InsertNCC(string Idncc, string Tenncc, string Diachi, string Sdt)
        {
            string query = string.Format("INSERT INTO NCC (Idncc, Tenncc, Diachi, Sdt) VALUES('{0}', '{1}','{2}','{3}')", Idncc, Tenncc, Diachi, Sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



    }
}
