using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Core;
using Examen.Models;
using MetroFramework.Forms;


namespace Examen.Main
{
    public partial class SotrudnikDopDokument : MetroForm
    {
        public SotrudnikDopDokument()
        {
            InitializeComponent();
            _ = LoadData();
            btn_save.Click += async (s, a) => await SaveData();
        }
        private async Task LoadData()
        {
            using (var dbContext = new PP_KADNIKOV3Entities())
            {
                var unitOfWork = new UnitOfWorkAddicitionDocument(dbContext);
                var userId = Core.Database.userId;
                var username = Core.Database.username;
                var additionalDocuments = await unitOfWork.AdditionalDocumentsRepository.GetByUserId(userId);

                groupBox1.Text = username;

                if (additionalDocuments == null)
                {
                    MessageBox.Show("Новая запись у сотрудника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FillTextBoxes(additionalDocuments);
                }
            }
        }

        private async Task SaveData()
        {
            using (var dbContext = new PP_KADNIKOV3Entities())
            {
                var unitOfWork = new UnitOfWorkAddicitionDocument(dbContext);
                var additionalDocuments = await unitOfWork.AdditionalDocumentsRepository.GetByUserId(Core.Database.userId);

                if (additionalDocuments == null)
                {
                    additionalDocuments = new AdditionalDocuments
                    {
                        fk = Core.Database.userId,
                        SNILS = tb_SNILS.Text,
                        POLIS = tb_POLIS.Text,
                        INN = tb_INN.Text,
                        KPP = tb_KPP.Text,
                        TrudKnijka = tb_TRUD.Text,
                        MedKnikjka = tb_MED.Text
                    };
                    await unitOfWork.AdditionalDocumentsRepository.AddOrUpdate(additionalDocuments);
                    await unitOfWork.SaveChangesAsync();

                    MessageBox.Show("Запись успешно добавлена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UpdateAdditionalDocuments(additionalDocuments);

                    await unitOfWork.SaveChangesAsync();

                    MessageBox.Show("Запись успешно изменена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FillTextBoxes(AdditionalDocuments additionalDocuments)
        {
            tb_SNILS.Text = additionalDocuments.SNILS;
            tb_POLIS.Text = additionalDocuments.POLIS;
            tb_INN.Text = additionalDocuments.INN;
            tb_KPP.Text = additionalDocuments.KPP;
            tb_MED.Text = additionalDocuments.MedKnikjka;
            tb_TRUD.Text = additionalDocuments.TrudKnijka;
        }

        private void UpdateAdditionalDocuments(AdditionalDocuments additionalDocuments)
        {
            additionalDocuments.SNILS = tb_SNILS.Text;
            additionalDocuments.POLIS = tb_POLIS.Text;
            additionalDocuments.INN = tb_INN.Text;
            additionalDocuments.KPP = tb_KPP.Text;
            additionalDocuments.TrudKnijka = tb_TRUD.Text;
            additionalDocuments.MedKnikjka = tb_MED.Text;
        }

    }
}

