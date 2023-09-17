using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Core;
using MetroFramework.Forms;

namespace Examen.Main
{
    public partial class InformationObrozovaniySotrudnik : MetroForm
    {
        private readonly ObrazovanieManager _obrazovanieManager;
        public InformationObrozovaniySotrudnik()
        {
            InitializeComponent();
            LoadGrid();
            btn_add.Click += (s, a) => MethodAdd();
            btn_upd.Click += (s, a) => MethodUpdate();
            btn_del.Click += (s, a) => MethodDelete();
            _obrazovanieManager = new ObrazovanieManager(new DataAccess());
        }

        private void ObrazovanieForm_Load(object sender, EventArgs e)
        {
            
            AddFormElements();
            CustomizeDataGridView();
        }
        

        private void AddFormElements()
        {
            // Добавляем элементы на форму
            Label label1 = new Label();
            label1.Text = "Пример текста";
            this.Controls.Add(label1);

            Button button1 = new Button();
            button1.Text = "Пример кнопки";
            this.Controls.Add(button1);
            // Продолжайте добавлять необходимые элементы на форму
        }

        private void CustomizeDataGridView()
        {
            // Если у вас есть элемент DataGridView, также пример настройки его внешнего вида:
            DGV_Obrazovanie.BackgroundColor = System.Drawing.Color.White;
            DGV_Obrazovanie.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DGV_Obrazovanie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        async private void LoadGrid()
        {
            using (var context = new Models.PP_KADNIKOV3Entities())
            {
                IObrazovanieRepository obrazovanieRepository = new ObrazovanieRepository(context);

                List<ObrazovanieDto> obrazovanieList = obrazovanieRepository.GetByUserId(Core.Database.userId);

                DGV_Obrazovanie.DataSource = obrazovanieList;
            }

            DGV_Obrazovanie.Columns[0].Visible = false;
            groupBox1.Text = Core.Database.username;
        }
        async private void MethodAdd()
        {
            await _obrazovanieManager.AddObrazovanie(tb_obrazovanie.Text,
                tb_nazvanieUchrejdenia.Text,
                tb_kvalifikaziya.Text,
                tb_nazvanieUchrejdenia2.Text,
                tb_kvalifikaziya2.Text, tb_vuz.Text, tb_professiyaOsnovnaya.Text, tb_professiaDrugaya.Text);
            LoadGrid();
        }

        async private void MethodUpdate()
        {
            int obrazovanieId = Convert.ToInt32(DGV_Obrazovanie.CurrentRow.Cells[0].Value.ToString());
            await _obrazovanieManager.UpdateObrazovanie(obrazovanieId, tb_obrazovanie.Text,
                tb_nazvanieUchrejdenia.Text, 
                tb_kvalifikaziya.Text, 
                tb_nazvanieUchrejdenia2.Text, 
                tb_kvalifikaziya2.Text, 
                tb_vuz.Text, 
                tb_professiyaOsnovnaya.Text, 
                tb_professiaDrugaya.Text);
            LoadGrid();
        }

        async private void MethodDelete()
        {
            int obrazovanieId = Convert.ToInt32(DGV_Obrazovanie.CurrentRow.Cells[0].Value.ToString());
            await _obrazovanieManager.DeleteObrazovanie(obrazovanieId);
            LoadGrid();
        }

        private void DGV_Obrazovanie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DGV_Obrazovanie.CurrentRow;

            tb_obrazovanie.Text = GetDataFromCell(selectedRow, 1);
            tb_nazvanieUchrejdenia.Text = GetDataFromCell(selectedRow, 2);
            tb_kvalifikaziya.Text = GetDataFromCell(selectedRow, 3);
            tb_nazvanieUchrejdenia2.Text = GetDataFromCell(selectedRow, 4);
            tb_kvalifikaziya2.Text = GetDataFromCell(selectedRow, 5);
            tb_vuz.Text = GetDataFromCell(selectedRow, 6);
            tb_professiyaOsnovnaya.Text = GetDataFromCell(selectedRow, 7);
            tb_professiaDrugaya.Text = GetDataFromCell(selectedRow, 8);
        }

        private string GetDataFromCell(DataGridViewRow row, int columnIndex)
        {
            return row.Cells[columnIndex].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void tb_exit_Click(object sender, EventArgs e)
        {
            InformationSotrudnik ad = new InformationSotrudnik(); ad.Show(); this.Hide();
        }
    }
    
}
