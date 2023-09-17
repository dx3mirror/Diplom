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
        public static string constr = "Data Source=sql1c;Initial Catalog=Examen_kostya;User ID=24-тппоповкд;Password=982939";

        public static string acces;

        public static int userId;
        


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
    }
}
