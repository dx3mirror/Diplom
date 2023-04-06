
namespace Examen.Main
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.headerLbl = new System.Windows.Forms.Label();
            this.footerLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headingPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_setting = new Examen.yt_Button();
            this.btn_history = new Examen.yt_Button();
            this.btn_createObyav = new Examen.yt_Button();
            this.btn_myObyav = new Examen.yt_Button();
            this.btn_allObyav = new Examen.yt_Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headingPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.headerLbl.Location = new System.Drawing.Point(440, 15);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(464, 81);
            this.headerLbl.TabIndex = 44;
            this.headerLbl.Text = "СТРОИТЕЛЬНАЯ КОМПАНИЯ СИБИРЬ";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // footerLbl
            // 
            this.footerLbl.BackColor = System.Drawing.Color.Transparent;
            this.footerLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.footerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.footerLbl.Location = new System.Drawing.Point(295, 548);
            this.footerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.footerLbl.Name = "footerLbl";
            this.footerLbl.Size = new System.Drawing.Size(337, 36);
            this.footerLbl.TabIndex = 46;
            this.footerLbl.Text = "© 2022 KADNIKOV";
            this.footerLbl.Click += new System.EventHandler(this.footerLbl_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(317, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 81);
            this.label1.TabIndex = 48;
            this.label1.Text = "Информация о поставщиках";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // headingPic
            // 
            this.headingPic.Image = ((System.Drawing.Image)(resources.GetObject("headingPic.Image")));
            this.headingPic.Location = new System.Drawing.Point(287, 15);
            this.headingPic.Margin = new System.Windows.Forms.Padding(4);
            this.headingPic.Name = "headingPic";
            this.headingPic.Size = new System.Drawing.Size(117, 94);
            this.headingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headingPic.TabIndex = 47;
            this.headingPic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_setting);
            this.groupBox1.Controls.Add(this.btn_history);
            this.groupBox1.Controls.Add(this.btn_createObyav);
            this.groupBox1.Controls.Add(this.btn_myObyav);
            this.groupBox1.Controls.Add(this.btn_allObyav);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 540);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Категории";
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.Violet;
            this.btn_setting.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_setting.BackColorGradientEnabled = true;
            this.btn_setting.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_setting.BorderColor = System.Drawing.Color.Tomato;
            this.btn_setting.BorderColorEnabled = false;
            this.btn_setting.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_setting.BorderColorOnHoverEnabled = false;
            this.btn_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_setting.ForeColor = System.Drawing.Color.Black;
            this.btn_setting.Location = new System.Drawing.Point(95, 458);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.RippleColor = System.Drawing.Color.Black;
            this.btn_setting.RoundingEnable = true;
            this.btn_setting.Size = new System.Drawing.Size(167, 72);
            this.btn_setting.TabIndex = 63;
            this.btn_setting.Text = "Об программе";
            this.btn_setting.TextHover = null;
            this.btn_setting.UseDownPressEffectOnClick = false;
            this.btn_setting.UseRippleEffect = true;
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.UseZoomEffectOnHover = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click_1);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.Violet;
            this.btn_history.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_history.BackColorGradientEnabled = true;
            this.btn_history.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_history.BorderColor = System.Drawing.Color.Tomato;
            this.btn_history.BorderColorEnabled = false;
            this.btn_history.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_history.BorderColorOnHoverEnabled = false;
            this.btn_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_history.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_history.ForeColor = System.Drawing.Color.Black;
            this.btn_history.Location = new System.Drawing.Point(100, 358);
            this.btn_history.Name = "btn_history";
            this.btn_history.RippleColor = System.Drawing.Color.Black;
            this.btn_history.RoundingEnable = true;
            this.btn_history.Size = new System.Drawing.Size(167, 72);
            this.btn_history.TabIndex = 62;
            this.btn_history.Text = "История платежей";
            this.btn_history.TextHover = null;
            this.btn_history.UseDownPressEffectOnClick = false;
            this.btn_history.UseRippleEffect = true;
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.UseZoomEffectOnHover = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_createObyav
            // 
            this.btn_createObyav.BackColor = System.Drawing.Color.Violet;
            this.btn_createObyav.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_createObyav.BackColorGradientEnabled = true;
            this.btn_createObyav.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_createObyav.BorderColor = System.Drawing.Color.Tomato;
            this.btn_createObyav.BorderColorEnabled = false;
            this.btn_createObyav.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_createObyav.BorderColorOnHoverEnabled = false;
            this.btn_createObyav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createObyav.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_createObyav.ForeColor = System.Drawing.Color.Black;
            this.btn_createObyav.Location = new System.Drawing.Point(94, 244);
            this.btn_createObyav.Name = "btn_createObyav";
            this.btn_createObyav.RippleColor = System.Drawing.Color.Black;
            this.btn_createObyav.RoundingEnable = true;
            this.btn_createObyav.Size = new System.Drawing.Size(167, 88);
            this.btn_createObyav.TabIndex = 61;
            this.btn_createObyav.Text = "Утвердить заявку";
            this.btn_createObyav.TextHover = null;
            this.btn_createObyav.UseDownPressEffectOnClick = false;
            this.btn_createObyav.UseRippleEffect = true;
            this.btn_createObyav.UseVisualStyleBackColor = false;
            this.btn_createObyav.UseZoomEffectOnHover = false;
            this.btn_createObyav.Click += new System.EventHandler(this.btn_createObyav_Click_1);
            // 
            // btn_myObyav
            // 
            this.btn_myObyav.BackColor = System.Drawing.Color.Violet;
            this.btn_myObyav.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_myObyav.BackColorGradientEnabled = true;
            this.btn_myObyav.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_myObyav.BorderColor = System.Drawing.Color.Tomato;
            this.btn_myObyav.BorderColorEnabled = false;
            this.btn_myObyav.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_myObyav.BorderColorOnHoverEnabled = false;
            this.btn_myObyav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_myObyav.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_myObyav.ForeColor = System.Drawing.Color.Black;
            this.btn_myObyav.Location = new System.Drawing.Point(94, 155);
            this.btn_myObyav.Name = "btn_myObyav";
            this.btn_myObyav.RippleColor = System.Drawing.Color.Black;
            this.btn_myObyav.RoundingEnable = true;
            this.btn_myObyav.Size = new System.Drawing.Size(167, 60);
            this.btn_myObyav.TabIndex = 60;
            this.btn_myObyav.Text = "История предложений";
            this.btn_myObyav.TextHover = null;
            this.btn_myObyav.UseDownPressEffectOnClick = false;
            this.btn_myObyav.UseRippleEffect = true;
            this.btn_myObyav.UseVisualStyleBackColor = false;
            this.btn_myObyav.UseZoomEffectOnHover = false;
            this.btn_myObyav.Click += new System.EventHandler(this.btn_myObyav_Click);
            // 
            // btn_allObyav
            // 
            this.btn_allObyav.BackColor = System.Drawing.Color.Violet;
            this.btn_allObyav.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_allObyav.BackColorGradientEnabled = true;
            this.btn_allObyav.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_allObyav.BorderColor = System.Drawing.Color.Tomato;
            this.btn_allObyav.BorderColorEnabled = false;
            this.btn_allObyav.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_allObyav.BorderColorOnHoverEnabled = false;
            this.btn_allObyav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_allObyav.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_allObyav.ForeColor = System.Drawing.Color.Black;
            this.btn_allObyav.Location = new System.Drawing.Point(94, 58);
            this.btn_allObyav.Name = "btn_allObyav";
            this.btn_allObyav.RippleColor = System.Drawing.Color.Black;
            this.btn_allObyav.RoundingEnable = true;
            this.btn_allObyav.Size = new System.Drawing.Size(167, 60);
            this.btn_allObyav.TabIndex = 59;
            this.btn_allObyav.Text = "Главная страница";
            this.btn_allObyav.TextHover = null;
            this.btn_allObyav.UseDownPressEffectOnClick = false;
            this.btn_allObyav.UseRippleEffect = true;
            this.btn_allObyav.UseVisualStyleBackColor = false;
            this.btn_allObyav.UseZoomEffectOnHover = false;
            this.btn_allObyav.Click += new System.EventHandler(this.btn_allObyav_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Examen.Properties.Resources.about;
            this.pictureBox6.Location = new System.Drawing.Point(-6, 458);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(79, 56);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Examen.Properties.Resources._1438215397_edit_find_replace;
            this.pictureBox5.Location = new System.Drawing.Point(0, 358);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(79, 72);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Examen.Properties.Resources._1438206469_Add;
            this.pictureBox4.Location = new System.Drawing.Point(0, 244);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Examen.Properties.Resources.view;
            this.pictureBox3.Location = new System.Drawing.Point(0, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Examen.Properties.Resources.options;
            this.pictureBox2.Location = new System.Drawing.Point(0, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headingPic);
            this.Controls.Add(this.footerLbl);
            this.Controls.Add(this.headerLbl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "СИБИРЬ";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headingPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label footerLbl;
        private System.Windows.Forms.PictureBox headingPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private yt_Button btn_setting;
        private yt_Button btn_history;
        private yt_Button btn_createObyav;
        private yt_Button btn_myObyav;
        private yt_Button btn_allObyav;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}