using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Core
{
    class Database
    {
        public static string constr = "Data Source=62.78.81.19;Initial Catalog=PP_KADNIKOV1;User ID=27-бдКадников;Password=982939";

        public static string con = "Data Source=62.78.81.19;Initial Catalog=PP_KADNIKOV3;User ID=27-бдКадников;Password=982939";

        public static string acces;

        public static int userId;
       
        public static string username;

        public static string Name;


        public static DataTable Query(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, constr);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обращения к БД!\nПроверьте вводимые данные \n {ex.Message}", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            return dt;
        }

        public static DataTable Query1(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обращения к БД!\nПроверьте вводимые данные \n {ex.Message}", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            return dt;
        }
    }
}
