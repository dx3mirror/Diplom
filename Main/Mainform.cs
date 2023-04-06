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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            
            btn_myObyav.Click += (s, a) => openform();
            btn_history.Click += (s, a) => histryMethod();
            btn_createObyav.Click += (s, a) => CreateFormMethod();

        }
        private void CreateFormMethod()
        {
            new Main().Show();
            this.Hide();
        }
        private void openform()
        {
            new Lichnoe().Show(); 
            this.Hide();

        }
        private void histryMethod()
        {
            
            new HistoryForm().Show();
            this.Hide();
        }
    }
}
