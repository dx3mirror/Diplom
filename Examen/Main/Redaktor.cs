using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Xml;

namespace Examen.Main
{
    public partial class Redaktor : MetroForm
    {
        public Redaktor()
        {
            InitializeComponent();
            LoadGridReg();
            LoadGridTrans();
            LoadGridUser();
            btn_insert.Click += (s, a) => CreateUser();
            btn_update.Click += (s, a) => UpdateUser();
            btn_delete.Click += (s, a) => Delete();
        }

        private void LoadGridReg()
        {
            DGV_reg.DataSource = Core.Database.Query1($@"SELECT        ID,
                                                                            LastName AS Фамилия,
                                                                            FirstName AS Имя,
                                                                            Patronomic AS Отчество,
                                                                            Telefon AS [Номер телефона],
                                                                           
                                                                            Dol AS Должность,
                                                                            PasswordN AS Пароль,
                                                                            Login AS Логин
                                                                            FROM            ZayvleniyRegestration");
        }
        private void LoadGridTrans()
        {
            DGV_activity.DataSource = Core.Database.Query1($@"SELECT        ID
                                                                       AS Номер,
                                                                       NameLog AS [Логин зашедшего],
                                                                       DateLog AS Дата
                                                                       FROM            Transactionprogram");
        }

        private void CreateUser()
        {
            DVG_Users.DataSource = Core.Database.Query1($@"INSERT INTO usersProgram
                                                                         (
                                                                         [loginI],
                                                                         [PasI],
                                                                         [acces])
                                                                   VALUES
                                                                         (
                                                                          '{tb_log.Text}',
                                                                          '{tb_pas.Text}',
                                                                          '{tb_acces.Text}')");
            LoadGridUser();
        }
        private void LoadGridUser()
        {
            DVG_Users.DataSource = Core.Database.Query1($@"SELECT        ID_dol AS [Номер аккаунта],
                                                                            loginI AS Логин,
                                                                            PasI AS Пароль,
                                                                            acces AS Доступ
                                                                            FROM            usersProgram");
        }
        private void UpdateUser()
        {
            DVG_Users.DataSource = Core.Database.Query1($@"UPDATE usersProgram SET
                                                                                  loginI              = '{tb_log.Text}',          
                                                                                  PasI   = '{tb_pas.Text}',      
                                                                                  acces   = '{tb_acces.Text}'     
                                                                    WHERE ID_dol = @currValue " + DVG_Users.CurrentRow.Cells[0].Value.ToString());
            
                LoadGridUser();
        }

        private void Redaktor_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_exit_Click(object sender, EventArgs e)
        {

        }

        private void Delete()
        {
            DVG_Users.DataSource = Core.Database.Query1($@" Delete from usersProgram   
                                                                    WHERE ID_dol = " + DVG_Users.CurrentRow.Cells[0].Value.ToString());
            LoadGridUser();
        }

        private void DVG_Users_DoubleClick(object sender, EventArgs e)
        {
            tb_log.Text =   DVG_Users.CurrentRow.Cells[1].Value.ToString();
            tb_pas.Text =   DVG_Users.CurrentRow.Cells[2].Value.ToString();
            tb_acces.Text = DVG_Users.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
