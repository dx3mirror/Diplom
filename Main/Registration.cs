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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            btn_reg.Click += (s, a) => RegistrationMethod();
            btn_autorization.Click += (s, a) => Autorizationmethod();
            tb_pass.PasswordChar = '*';
            tb_pass2.PasswordChar = '*';
        }
        private void Autorizationmethod()
        {
            new autorization().Show(); this.Hide();

        }
        private void ClearAll() 
        {
            tb_adress.Clear();
            tb_fam.Clear();
            tb_log.Clear();
            tb_nam.Clear();
            tb_pass.Clear();
            tb_pass2.Clear();
            tb_tel.Clear();
        }
        private void RegistrationMethod()
        {
            Core.Database.Query($@"INSERT INTO users
                                                     (login       ,
                                                     password    ,
                                                     name        ,
                                                     surname     ,
                                                     adress      ,
                                                     phone       )
                                             VALUES
                                                   ('{tb_log.Text}'   ,
                                                   '{tb_pass.Text}'   ,
                                                   '{tb_nam.Text}'    ,
                                                   '{tb_fam.Text}'    ,
                                                   '{tb_adress.Text}' ,
                                                   '{tb_tel.Text}'     )");
            MessageBox.Show("Данные успешно введены","Внимание",MessageBoxButtons.OK);
            ClearAll();
        }
    }
}
