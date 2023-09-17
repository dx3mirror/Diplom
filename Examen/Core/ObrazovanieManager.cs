using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Core
{
    public class ObrazovanieManager
    {
        private readonly IDataAccess _dataAccess;

        public ObrazovanieManager(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task AddObrazovanie(string obrazovanie, string nazvanieUchrejdenia, string kvalifikaziya, string nazvanieUchrejdenia2, string kvalifikaziya2, string vuz, string professiyaOsnovnaya, string professiaDrugaya)
        {
            try
            {
                var obrazovanieModel = new Models.Obrazovanie
                {
                    fk_kod_sotrudnika = Core.Database.userId,
                    obrazovanie1 = obrazovanie,
                    nazvanieuchrejdeniya = nazvanieUchrejdenia,
                    kvalifikachiyapoObrazovaniyu = kvalifikaziya,
                    nazvanieuchrejdeniya2 = nazvanieUchrejdenia2,
                    kvalifikachiyapoObrazovaniyu2 = kvalifikaziya2,
                    poslevuzovoe = vuz,
                    professiaOsnova = professiyaOsnovnaya,
                    professiaDopolnitel = professiaDrugaya
                };

                await _dataAccess.AddObrazovanie(obrazovanieModel);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task UpdateObrazovanie(int obrazovanieId, string obrazovanie, string nazvanieUchrejdenia, string kvalifikaziya, string nazvanieUchrejdenia2, string kvalifikaziya2, string vuz, string professiyaOsnovnaya, string professiaDrugaya)
        {
            try
            {
                var obrazovanieModel = await _dataAccess.GetObrazovanieById(obrazovanieId);
                if (obrazovanieModel != null)
                {
                    obrazovanieModel.obrazovanie1 = obrazovanie;
                    obrazovanieModel.nazvanieuchrejdeniya = nazvanieUchrejdenia;
                    obrazovanieModel.kvalifikachiyapoObrazovaniyu = kvalifikaziya;
                    obrazovanieModel.nazvanieuchrejdeniya2 = nazvanieUchrejdenia2;
                    obrazovanieModel.kvalifikachiyapoObrazovaniyu2 = kvalifikaziya2;
                    obrazovanieModel.poslevuzovoe = vuz;
                    obrazovanieModel.professiaOsnova = professiyaOsnovnaya;
                    obrazovanieModel.professiaDopolnitel = professiaDrugaya;

                    await _dataAccess.UpdateObrazovanie(obrazovanieModel);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task DeleteObrazovanie(int obrazovanieId)
        {
            try
            {
                await _dataAccess.DeleteObrazovanie(obrazovanieId);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
