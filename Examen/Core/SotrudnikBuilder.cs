using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class SotrudnikBuilder
    {
        private DataTable tb;

        public SotrudnikBuilder()
        {
            tb = new DataTable();
            tb.Columns.Add("ID");
            tb.Columns.Add("Фамилия");
            tb.Columns.Add("Имя");
            tb.Columns.Add("Отчество");
            tb.Columns.Add("Место рождения");
            tb.Columns.Add("Телефон");
            tb.Columns.Add("Дата рождения");
            tb.Columns.Add("Иностранный язык");
            tb.Columns.Add("Гражданство");
            tb.Columns.Add("Пол");
            tb.Columns.Add("Идентификационный номер");
            tb.Columns.Add("Код по окин");
            tb.Columns.Add("Брак");
            tb.Columns.Add("Удаление");
        }

        public SotrudnikBuilder AddSotrudnik(Sotrudnik sotrudnik)
        {
            var row = tb.NewRow();
            row["ID"] = sotrudnik.ID;
            row["Фамилия"] = sotrudnik.lastname;
            row["Имя"] = sotrudnik.nam;
            row["Отчество"] = sotrudnik.patronomic;
            row["Место рождения"] = sotrudnik.mesto_rojd;
            row["Телефон"] = sotrudnik.telefon;
            row["Дата рождения"] = sotrudnik.datarojdeniya;
            row["Иностранный язык"] = sotrudnik.in_yaz;
            row["Гражданство"] = sotrudnik.grajdanstvo;
            row["Пол"] = sotrudnik.Pol;
            row["Идентификационный номер"] = sotrudnik.Identitynomer;
            row["Код по окин"] = sotrudnik.OKIN;
            row["Брак"] = sotrudnik.brak;

            if (sotrudnik.del == "del")
                row["Удаление"] = "(no) " + sotrudnik.del;
            else
                row["Удаление"] = sotrudnik.del;

            tb.Rows.Add(row);

            return this;
        }
        public DataTable Build()
        {
            return tb;
        }
    }
}
