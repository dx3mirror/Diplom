using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Core;


namespace Examen.Main
{
    public partial class InformationFamilySotrudnik : Form
    {
        public InformationFamilySotrudnik()
        {
            InitializeComponent();

            btn_add.Click += (s, a) => MethodAdd();
            btn_upd.Click += (s, a) => MethodUpdate();
            btn_del.Click += (s, a) => MethodDelete();
            DGV_Family.DoubleClick += (s, a) => DoubleCl();
            tb_exit.Click += (s, a) => ExitApp();
        }

        private async void FamalyForm_Load(object sender, EventArgs e)
        {
           await LoadGridAsync();

        }
        private void ExitApp()
        {
            this.Close();
        }

        async private Task LoadGridAsync()
        {
            using (var dbContext = new Base.PP_KADNIKOV3Entities())
            {
                var familyRepository = new FamilyRepositoryLoad(dbContext);
                var familyList = await familyRepository.GetFamilyByUserId(Core.Database.userId);

                DGV_Family.DataSource = familyList;
            }

            groupBox1.Text = Core.Database.username;
        }

        private async void MethodUpdate()
        {
            try
            {
                var id = DGV_Family.CurrentRow.Cells[0].Value.ToString();
                var fio = tb_fio.Text;
                var stepenRodstva = cb_stepenrodstva.Text;
                var dataRojdeniya = dtp_godRojdeniya.Value.ToString();

                using (var context = new    Base.PP_KADNIKOV3Entities())
                {
                    var repository = new FamilyRepository(context);
                    var command = new UpdateCommand(repository, int.Parse(id), fio, stepenRodstva, dataRojdeniya);
                    await command.ExecuteAsync();
                }

                await LoadGridAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void MethodDelete()
        {
            try
            {
                var id = int.Parse(DGV_Family.CurrentRow.Cells[0].Value.ToString());

                using (var context = new Base.PP_KADNIKOV3Entities())
                {
                    var repository = new FamilyRepository(context);
                    var command = new DeleteCommand(repository, id);
                    await command.ExecuteAsync();
                }

                await LoadGridAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void MethodAdd()
        {
            try
            {
                var fio = tb_fio.Text;
                var stepenRodstva = cb_stepenrodstva.Text;
                var dataRojdeniya = dtp_godRojdeniya.Value;

                using (var context = new Base.PP_KADNIKOV3Entities())
                {
                    var repository = new FamilyRepository(context);
                    var command = new AddCommand(repository, Core.Database.userId, fio, stepenRodstva, dataRojdeniya);
                    await command.ExecuteAsync();
                }

                await LoadGridAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DoubleCl()
        {
            tb_fio.Text = GetCellValue(DGV_Family, 1);
            cb_stepenrodstva.Text = GetCellValue(DGV_Family, 2);
            dtp_godRojdeniya.Value = DateTime.Parse(GetCellValue(DGV_Family, 3));
        }

        private string GetCellValue(DataGridView dgv, int columnIndex)
        {
            return dgv.CurrentRow.Cells[columnIndex].Value.ToString();
        }
    }
       
        

        

        
    
}
