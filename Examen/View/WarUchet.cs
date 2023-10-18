using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Examen.Base;
using System.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Examen.Main
{
    public partial class WarUchet : Form
    {
        public WarUchet()
        {
            InitializeComponent();
            btn_add.Click += (s, a) => MethodAdd();
            btn_upd.Click += (s, a) => MethodUpdate();
            btn_del.Click += (s, a) => MethodDelete();
        }

        private void WarUchet_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private async Task<List<Waruchet>> GetWaruchetData()
        {
            using (var context = new PP_KADNIKOV3Entities())
            {
                var query = from w in context.Waruchet
                            where w.FK_sotrudnik == Core.Database.userId
                            select w;

                return await query.ToListAsync();
            }
        }

        private void LoadGrid(List<Waruchet> waruchetData)
        {
            var dataSource = waruchetData.Select(w => new
            {
                w.ID,
                Категория_запаса = w.Kategorya,
                Воинское_звание = w.Zvanie,
                Состав = w.Sostav,
                Код_по_ВУС = w.kod_VUS,
                Воинский_учёт = w.Sostoyanie_voinskogo,
                Название_коммисариата = w.Nazvanie_komisariata,
                Категория = w.Kategoria
            }).ToList();

            DGV_Family.DataSource = dataSource;
            DGV_Family.Columns[0].Visible = false;
            groupBox1.Text = Core.Database.username;
        }

        private async Task<bool> AddWaruchetData()
        {
            try
            {
                using (var context = new PP_KADNIKOV3Entities())
                {
                    var newWaruchet = new Waruchet
                    {
                        FK_sotrudnik = Core.Database.userId,
                        Kategorya = cb_stepenrodstva.Text,
                        Zvanie = tb_fio.Text,
                        Sostav = tb_sostav.Text,
                        kod_VUS = tb_VUS.Text,
                        Sostoyanie_voinskogo = cb_UCHET.Text,
                        Nazvanie_komisariata = tb_voinskiy.Text,
                        Kategoria = tb_category.Text
                    };

                    context.Waruchet.Add(newWaruchet);
                    await context.SaveChangesAsync();

                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task<bool> UpdateWaruchetData(int id)
        {
            try
            {
                using (var context = new PP_KADNIKOV3Entities())
                {
                    var waruchet = await context.Waruchet.FirstOrDefaultAsync(w => w.ID == id);
                    if (waruchet != null)
                    {
                        waruchet.Kategorya = cb_stepenrodstva.Text;
                        waruchet.Zvanie = tb_fio.Text;
                        waruchet.Sostav = tb_sostav.Text;
                        waruchet.kod_VUS = tb_VUS.Text;
                        waruchet.Sostoyanie_voinskogo = cb_UCHET.Text;
                        waruchet.Nazvanie_komisariata = tb_voinskiy.Text;
                        waruchet.Kategoria = tb_category.Text;

                        await context.SaveChangesAsync();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private async Task<bool> DeleteWaruchetData(int id)
        {
            try
            {
                using (var context = new PP_KADNIKOV3Entities())
                {
                    var waruchet = await context.Waruchet.FirstOrDefaultAsync(w => w.ID == id);
                    if (waruchet != null)
                    {
                        context.Waruchet.Remove(waruchet);
                        await context.SaveChangesAsync();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private async void LoadGrid()
        {
            var waruchetData = await GetWaruchetData();
            LoadGrid(waruchetData);
        }

        private async void MethodAdd()
        {
            if (await AddWaruchetData())
            {
                LoadGrid();
            }
        }

        private async void MethodUpdate()
        {
            int id = Convert.ToInt32(DGV_Family.CurrentRow.Cells[0].Value);
            if (await UpdateWaruchetData(id))
            {
                LoadGrid();
            }
        }

        private async void MethodDelete()
        {
            int id = Convert.ToInt32(DGV_Family.CurrentRow.Cells[0].Value);
            if (await DeleteWaruchetData(id))
            {
                LoadGrid();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
