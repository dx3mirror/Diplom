using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Main
{
    public partial class autorization : Form
    {
        public autorization()
        {
            InitializeComponent();
        }

        private void autorization_Load(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = '*';
            
        }


        private void btn_enter_Click(object sender, EventArgs e)
        {
            DataTable dt = Core.Database.Query($@"SELECT * FROM users WHERE (login = N'{tb_log.Text}') AND (password = N'{tb_pass.Text}')");

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Core.Database.acces = dt.Rows[0][0].ToString();
                switch (dt.Rows[0][0].ToString())
                {
                    case "Admin":
                        new Main().Show(); this.Hide();
                        Core.Database.userId = 1;
                        break;
                    case "User":
                        new Main().Show(); this.Hide();
                        Core.Database.userId = 2;
                        break;

                }
            }

        }
    }
}
