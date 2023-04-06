using MetroFramework.Forms;
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
    public partial class SferaUsers : MetroForm
    {
        public SferaUsers()
        {
            InitializeComponent();
        }

        private void SferaUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Core.Database.Query(@"SELECT ItemCode AS КодПредмета, ItemName AS НазваниеПредмета, ItemDescription AS Индификация, ItemQuantity AS Колличество, Unit AS Измерение, ItemUsed AS ПредметИспользования, ItemBalance AS Баланс, 
                  ReorderLevel AS Уровень, LastUpdated AS ПоследниеОбнавление, SupplierId AS [идентификатор поставщика], StatusId AS СтатусИД, CategoryId AS КатегорияИД, Cost AS Разходы
FROM     itemsfera");
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            aboutUsers saz = new aboutUsers(); saz.Show(); this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormbinUsers sas = new FormbinUsers(); sas.Show(); this.Hide();
        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            GraalUsers a = new GraalUsers(); a.Show(); this.Hide();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            GraalUsers a = new GraalUsers(); a.Show(); this.Hide();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            aboutUsers saz = new aboutUsers(); saz.Show(); this.Hide();
        }
    }
}
