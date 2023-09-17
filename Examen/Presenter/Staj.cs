using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Core;
using Examen.Models;
using MetroFramework.Forms;

namespace Examen.Main
{
    public partial class Staj : MetroForm
    {
        
        public Staj()
        {
            InitializeComponent();
            btn_save.Click += (s, a) => SaveMethod();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        async private void FormLoad()
        {
            using (var context = new PP_KADNIKOV3Entities()) 
            {
                using (var unitOfWork = new UnitOfWorkStaj(context))
                {
                    var experience = await unitOfWork.ExperienceRepository.GetByIdAsync(Core.Database.userId);

                    groupBox4.Text = Core.Database.username;

                    if (experience == null)
                    {
                        MessageBox.Show("Новая запись у сотрудника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        tb_ObshiyDay.Text = experience.obchyi_day.ToString();
                        tb_ObshiyMonth.Text = experience.obchyi_month.ToString();
                        tb_ObshiyYear.Text = experience.obchyi_year.ToString();
                        tb_NeprerivniyDay.Text = experience.nepreryvniy_day.ToString();
                        tb_NeprerivniyMonth.Text = experience.nepreryvniy_month.ToString();
                        tb_NeprerivniyYear.Text = experience.nepreryvniy_year.ToString();
                        tb_PravoDay.Text = experience.vislugalet_day.ToString();
                        tb_PravoMonth.Text = experience.vislugalet_month.ToString();
                        tb_PravoYear.Text = experience.vislugalet_year.ToString();
                        dtp_stajRaboti.Value = DateTime.Parse(experience.stajrabotyposostoyaniyna.ToString());
                    }
                }
            }
        }

        async private void SaveMethod()
        {
            try
            {
                using (var context = new PP_KADNIKOV3Entities())
                {
                    using (var unitOfWork = new UnitOfWorkStaj(context))
                    {
                        var experience = await unitOfWork.ExperienceRepository.GetByIdAsync(Core.Database.userId);

                        if (experience == null)
                        {
                            experience = new Experience
                            {
                                FK_Sotrudnik = Core.Database.userId,
                                obchyi_day = tb_ObshiyDay.Text,
                                obchyi_month = tb_ObshiyMonth.Text,
                                obchyi_year = tb_ObshiyYear.Text,
                                nepreryvniy_day = tb_NeprerivniyDay.Text,
                                nepreryvniy_month = tb_NeprerivniyMonth.Text,
                                nepreryvniy_year = tb_NeprerivniyYear.Text,
                                vislugalet_day = tb_PravoDay.Text,
                                vislugalet_month = tb_PravoMonth.Text,
                                vislugalet_year = tb_PravoYear.Text,
                                stajrabotyposostoyaniyna = DateTime.Parse(dtp_stajRaboti.Value.ToString())
                            };

                            unitOfWork.ExperienceRepository.Add(experience);
                            await unitOfWork.SaveAsync();

                            MessageBox.Show("Успешное добавление записи", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            experience.obchyi_day = tb_ObshiyDay.Text;
                            experience.obchyi_month = tb_ObshiyMonth.Text;
                            experience.obchyi_year = tb_ObshiyYear.Text;
                            experience.nepreryvniy_day = tb_NeprerivniyDay.Text;
                            experience.nepreryvniy_month = tb_NeprerivniyMonth.Text;
                            experience.nepreryvniy_year = tb_NeprerivniyYear.Text;
                            experience.vislugalet_day = tb_PravoDay.Text;
                            experience.vislugalet_month = tb_PravoMonth.Text;
                            experience.vislugalet_year = tb_PravoYear.Text;
                            experience.stajrabotyposostoyaniyna = DateTime.Parse(dtp_stajRaboti.Value.ToString());

                            unitOfWork.ExperienceRepository.Update(experience);
                            await unitOfWork.SaveAsync();

                            MessageBox.Show("Успешное изменение записи", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
    
}
