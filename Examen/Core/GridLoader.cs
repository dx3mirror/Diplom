using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Core
{
    public class GridLoader
    {
        private readonly ISotrudnikRepository sotrudnikRepository;
        private readonly SotrudnikBuilder sotrudnikBuilder;

        public GridLoader(ISotrudnikRepository sotrudnikRepository, SotrudnikBuilder sotrudnikBuilder)
        {
            this.sotrudnikRepository = sotrudnikRepository;
            this.sotrudnikBuilder = sotrudnikBuilder;
        }
        public async Task LoadGrid(DataGridView DGV_Sotrudniki, CheckBox checkBox_deleted, string customSelect = null)
        {
            if (customSelect == null)
            {
                using (var dbContext = new PP_KADNIKOV3Entities())
                {
                    var queryResult = await sotrudnikRepository.GetAllSotrudniki(checkBox_deleted.Checked);

                    DataTable tb = sotrudnikBuilder.Build();

                    foreach (var item in queryResult)
                    {
                        sotrudnikBuilder.AddSotrudnik(item);
                    }
                }
            }

            DGV_Sotrudniki.DataSource = sotrudnikBuilder.Build();
            DGV_Sotrudniki.Columns[0].Visible = false;
            DGV_Sotrudniki.Columns[13].Visible = false;
        }
    }
}

