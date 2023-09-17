
namespace Examen.Main
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label7 = new System.Windows.Forms.Label();
            this.headerLbl = new System.Windows.Forms.Label();
            this.headingPic = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errLb = new System.Windows.Forms.Label();
            this.tb_dol = new Examen.EgoldsGoogleTextBox();
            this.tb_patronomic = new Examen.EgoldsGoogleTextBox();
            this.tb_logim = new Examen.EgoldsGoogleTextBox();
            this.yt_Button1 = new Examen.yt_Button();
            this.tb_fam = new Examen.EgoldsGoogleTextBox();
            this.tb_tel = new Examen.EgoldsGoogleTextBox();
            this.tb_nam = new Examen.EgoldsGoogleTextBox();
            this.tb_pass = new Examen.EgoldsGoogleTextBox();
            this.tb_pass2 = new Examen.EgoldsGoogleTextBox();
            this.btn_autorization = new Examen.yt_Button();
            this.btn_reg = new Examen.yt_Button();
            ((System.ComponentModel.ISupportInitialize)(this.headingPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.label7.Location = new System.Drawing.Point(216, 413);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 36);
            this.label7.TabIndex = 56;
            this.label7.Text = "Уже зарегестрированы?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.headerLbl.Location = new System.Drawing.Point(574, 18);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(304, 81);
            this.headerLbl.TabIndex = 58;
            this.headerLbl.Text = "СТРОИТЕЛЬНАЯ КОМПАНИЯ СИБИРЬ";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headingPic
            // 
            this.headingPic.Image = ((System.Drawing.Image)(resources.GetObject("headingPic.Image")));
            this.headingPic.Location = new System.Drawing.Point(437, 18);
            this.headingPic.Margin = new System.Windows.Forms.Padding(4);
            this.headingPic.Name = "headingPic";
            this.headingPic.Size = new System.Drawing.Size(117, 94);
            this.headingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headingPic.TabIndex = 59;
            this.headingPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(883, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // errLb
            // 
            this.errLb.BackColor = System.Drawing.Color.Transparent;
            this.errLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.errLb.Location = new System.Drawing.Point(2, 793);
            this.errLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errLb.Name = "errLb";
            this.errLb.Size = new System.Drawing.Size(375, 33);
            this.errLb.TabIndex = 76;
            this.errLb.Text = "Пароль должен содержать от 8 до 12 символов";
            this.errLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errLb.Visible = false;
            // 
            // tb_dol
            // 
            this.tb_dol.BackColor = System.Drawing.Color.White;
            this.tb_dol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_dol.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_dol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_dol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_dol.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_dol.ForeColor = System.Drawing.Color.Black;
            this.tb_dol.Location = new System.Drawing.Point(487, 324);
            this.tb_dol.Name = "tb_dol";
            this.tb_dol.Size = new System.Drawing.Size(234, 52);
            this.tb_dol.TabIndex = 75;
            this.tb_dol.TextInput = "";
            this.tb_dol.TextPreview = "E-mail";
            this.tb_dol.UseSystemPasswordChar = false;
            // 
            // tb_patronomic
            // 
            this.tb_patronomic.BackColor = System.Drawing.Color.White;
            this.tb_patronomic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_patronomic.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_patronomic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_patronomic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_patronomic.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_patronomic.ForeColor = System.Drawing.Color.Black;
            this.tb_patronomic.Location = new System.Drawing.Point(487, 264);
            this.tb_patronomic.Name = "tb_patronomic";
            this.tb_patronomic.Size = new System.Drawing.Size(234, 52);
            this.tb_patronomic.TabIndex = 74;
            this.tb_patronomic.TextInput = "";
            this.tb_patronomic.TextPreview = "Отчество";
            this.tb_patronomic.UseSystemPasswordChar = false;
            // 
            // tb_logim
            // 
            this.tb_logim.BackColor = System.Drawing.Color.White;
            this.tb_logim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_logim.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_logim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_logim.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_logim.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_logim.ForeColor = System.Drawing.Color.Black;
            this.tb_logim.Location = new System.Drawing.Point(5, 148);
            this.tb_logim.Name = "tb_logim";
            this.tb_logim.Size = new System.Drawing.Size(226, 52);
            this.tb_logim.TabIndex = 73;
            this.tb_logim.TextInput = "";
            this.tb_logim.TextPreview = "Логин";
            this.tb_logim.UseSystemPasswordChar = false;
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.DarkBlue;
            this.yt_Button1.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.yt_Button1.BackColorGradientEnabled = true;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button1.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorEnabled = false;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorOnHoverEnabled = false;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(883, 324);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(234, 30);
            this.yt_Button1.TabIndex = 72;
            this.yt_Button1.Text = "Загрузить аватар";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // tb_fam
            // 
            this.tb_fam.BackColor = System.Drawing.Color.White;
            this.tb_fam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_fam.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_fam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_fam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_fam.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_fam.ForeColor = System.Drawing.Color.Black;
            this.tb_fam.Location = new System.Drawing.Point(487, 206);
            this.tb_fam.Name = "tb_fam";
            this.tb_fam.Size = new System.Drawing.Size(234, 52);
            this.tb_fam.TabIndex = 70;
            this.tb_fam.TextInput = "";
            this.tb_fam.TextPreview = "Фамилия";
            this.tb_fam.UseSystemPasswordChar = false;
            // 
            // tb_tel
            // 
            this.tb_tel.BackColor = System.Drawing.Color.White;
            this.tb_tel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_tel.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_tel.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_tel.ForeColor = System.Drawing.Color.Black;
            this.tb_tel.Location = new System.Drawing.Point(5, 324);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(226, 50);
            this.tb_tel.TabIndex = 69;
            this.tb_tel.TextInput = "";
            this.tb_tel.TextPreview = "Телефон";
            this.tb_tel.UseSystemPasswordChar = false;
            // 
            // tb_nam
            // 
            this.tb_nam.BackColor = System.Drawing.Color.White;
            this.tb_nam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_nam.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_nam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nam.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nam.ForeColor = System.Drawing.Color.Black;
            this.tb_nam.Location = new System.Drawing.Point(487, 149);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(234, 51);
            this.tb_nam.TabIndex = 68;
            this.tb_nam.TextInput = "";
            this.tb_nam.TextPreview = "Имя";
            this.tb_nam.UseSystemPasswordChar = false;
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.White;
            this.tb_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_pass.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pass.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pass.ForeColor = System.Drawing.Color.Black;
            this.tb_pass.Location = new System.Drawing.Point(5, 206);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(226, 52);
            this.tb_pass.TabIndex = 67;
            this.tb_pass.TextInput = "";
            this.tb_pass.TextPreview = "Пароль";
            this.tb_pass.UseSystemPasswordChar = false;
            // 
            // tb_pass2
            // 
            this.tb_pass2.BackColor = System.Drawing.Color.White;
            this.tb_pass2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_pass2.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_pass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tb_pass2.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pass2.ForeColor = System.Drawing.Color.Black;
            this.tb_pass2.Location = new System.Drawing.Point(5, 264);
            this.tb_pass2.Name = "tb_pass2";
            this.tb_pass2.Size = new System.Drawing.Size(226, 52);
            this.tb_pass2.TabIndex = 66;
            this.tb_pass2.TextInput = "";
            this.tb_pass2.TextPreview = "Подвердите пароль";
            this.tb_pass2.UseSystemPasswordChar = false;
            // 
            // btn_autorization
            // 
            this.btn_autorization.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_autorization.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_autorization.BackColorGradientEnabled = true;
            this.btn_autorization.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_autorization.BorderColor = System.Drawing.Color.Tomato;
            this.btn_autorization.BorderColorEnabled = false;
            this.btn_autorization.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_autorization.BorderColorOnHoverEnabled = false;
            this.btn_autorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_autorization.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.btn_autorization.ForeColor = System.Drawing.Color.White;
            this.btn_autorization.Location = new System.Drawing.Point(202, 452);
            this.btn_autorization.Name = "btn_autorization";
            this.btn_autorization.RippleColor = System.Drawing.Color.Black;
            this.btn_autorization.RoundingEnable = true;
            this.btn_autorization.Size = new System.Drawing.Size(336, 31);
            this.btn_autorization.TabIndex = 65;
            this.btn_autorization.Text = "Войти";
            this.btn_autorization.TextHover = null;
            this.btn_autorization.UseDownPressEffectOnClick = false;
            this.btn_autorization.UseRippleEffect = true;
            this.btn_autorization.UseVisualStyleBackColor = false;
            this.btn_autorization.UseZoomEffectOnHover = false;
            this.btn_autorization.Click += new System.EventHandler(this.btn_autorization_Click_1);
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_reg.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_reg.BackColorGradientEnabled = true;
            this.btn_reg.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_reg.BorderColor = System.Drawing.Color.Tomato;
            this.btn_reg.BorderColorEnabled = false;
            this.btn_reg.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_reg.BorderColorOnHoverEnabled = false;
            this.btn_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reg.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.btn_reg.ForeColor = System.Drawing.Color.White;
            this.btn_reg.Location = new System.Drawing.Point(5, 380);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.RippleColor = System.Drawing.Color.Black;
            this.btn_reg.RoundingEnable = true;
            this.btn_reg.Size = new System.Drawing.Size(716, 30);
            this.btn_reg.TabIndex = 64;
            this.btn_reg.Text = "Регестрация";
            this.btn_reg.TextHover = null;
            this.btn_reg.UseDownPressEffectOnClick = false;
            this.btn_reg.UseRippleEffect = true;
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.UseZoomEffectOnHover = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click_1);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 836);
            this.Controls.Add(this.errLb);
            this.Controls.Add(this.tb_dol);
            this.Controls.Add(this.tb_patronomic);
            this.Controls.Add(this.tb_logim);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_fam);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_nam);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_pass2);
            this.Controls.Add(this.btn_autorization);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.headingPic);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.Text = "СИБИРЬ";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headingPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.PictureBox headingPic;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private yt_Button btn_reg;
        private yt_Button btn_autorization;
        private EgoldsGoogleTextBox tb_pass2;
        private EgoldsGoogleTextBox tb_pass;
        private EgoldsGoogleTextBox tb_nam;
        private EgoldsGoogleTextBox tb_tel;
        private EgoldsGoogleTextBox tb_fam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private yt_Button yt_Button1;
        private EgoldsGoogleTextBox tb_logim;
        private EgoldsGoogleTextBox tb_patronomic;
        private EgoldsGoogleTextBox tb_dol;
        private System.Windows.Forms.Label errLb;
    }
}