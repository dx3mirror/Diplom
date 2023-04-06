


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Examen.Components;
using Examen.Controls;

namespace Examen
{
    public partial class frmMain : Controls.ShadowedForm
    {
        public frmMain()
        {
            InitializeComponent();

            buttonAnim.Value = button1.Width;
            Animation.Animator.Start();


            if (cmbStyle.Items.Count == 0)
            {
                Components.EgoldsFormStyle.fStyle selectedStyle = egoldsFormStyle1.FormStyle;
                cmbStyle.DataSource = Enum.GetValues(typeof(Components.EgoldsFormStyle.fStyle));
                cmbStyle.SelectedItem = selectedStyle;
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Моя кнопка!");
        }
        
        Animation.Animation buttonAnim = new Animation.Animation();
        int BtnWidthTarget = 150;
        int BtnWidthBase = 75;

        private void test_button_animation(bool MouseEnter)
        {
            if (MouseEnter)
            {
                buttonAnim = new Animation.Animation("test", button1.Invalidate, button1.Width, BtnWidthTarget);
            }
            else
            {
                buttonAnim = new Animation.Animation("test", button1.Invalidate, button1.Width, BtnWidthBase);
            }

            buttonAnim.StepDivider = 6;
            Animation.Animator.Request(buttonAnim, true);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            test_button_animation(true);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            test_button_animation(false);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            button1.Width = (int)buttonAnim.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            egoldsProgressBar1.Value = trackBar1.Value;
        }

        private void contextExitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int i = 0;
        private void yt_Button5_Click(object sender, EventArgs e)
        {
            i++;
            yt_Button1.Text = i.ToString();
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            egoldsFormStyle1.FormStyle = (Components.EgoldsFormStyle.fStyle)cmbStyle.SelectedItem;
        }

        private void btnFlatButton_Click(object sender, EventArgs e)
        {
            egoldsToggleSwitch1.Checked = !egoldsToggleSwitch1.Checked;
        }

       

        private int clickscount = 0;
        private void yt_Button4_Click(object sender, EventArgs e)
        {
            clickscount++;
            egoldsCard1.Text = clickscount.ToString();
            egoldsCard1.Invalidate();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void egoldsGoogleTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
