﻿
namespace Examen.Main
{
    partial class autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autorization));
            this.footerLbl = new System.Windows.Forms.Label();
            this.headingPic = new System.Windows.Forms.PictureBox();
            this.headerLbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.forgetLink = new System.Windows.Forms.LinkLabel();
            this.errLb = new System.Windows.Forms.Label();
            this.btn_enter = new Examen.yt_Button();
            this.tb_log = new Examen.EgoldsGoogleTextBox();
            this.tb_pass = new Examen.EgoldsGoogleTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.headingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // footerLbl
            // 
            this.footerLbl.BackColor = System.Drawing.Color.Transparent;
            this.footerLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.footerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.footerLbl.Location = new System.Drawing.Point(7, 386);
            this.footerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.footerLbl.Name = "footerLbl";
            this.footerLbl.Size = new System.Drawing.Size(135, 36);
            this.footerLbl.TabIndex = 45;
            this.footerLbl.Text = "© 2022 KADNIKOV";
            this.footerLbl.Click += new System.EventHandler(this.footerLbl_Click_1);
            // 
            // headingPic
            // 
            this.headingPic.Image = ((System.Drawing.Image)(resources.GetObject("headingPic.Image")));
            this.headingPic.Location = new System.Drawing.Point(125, 17);
            this.headingPic.Margin = new System.Windows.Forms.Padding(4);
            this.headingPic.Name = "headingPic";
            this.headingPic.Size = new System.Drawing.Size(117, 94);
            this.headingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headingPic.TabIndex = 44;
            this.headingPic.TabStop = false;
            this.headingPic.Click += new System.EventHandler(this.headingPic_Click_1);
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.headerLbl.Location = new System.Drawing.Point(250, 17);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(301, 81);
            this.headerLbl.TabIndex = 43;
            this.headerLbl.Text = "СТРОИТЕЛЬНАЯ КОМПАНИЯ СИБИРЬ";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerLbl.Click += new System.EventHandler(this.headerLbl_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.linkLabel1.Location = new System.Drawing.Point(463, 380);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 38);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Exit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // forgetLink
            // 
            this.forgetLink.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.forgetLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.forgetLink.BackColor = System.Drawing.Color.Transparent;
            this.forgetLink.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetLink.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forgetLink.LinkColor = System.Drawing.Color.Brown;
            this.forgetLink.Location = new System.Drawing.Point(207, 343);
            this.forgetLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgetLink.Name = "forgetLink";
            this.forgetLink.Size = new System.Drawing.Size(140, 36);
            this.forgetLink.TabIndex = 36;
            this.forgetLink.TabStop = true;
            this.forgetLink.Text = "Нету аккаунта?";
            this.forgetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetLink_LinkClicked_1);
            // 
            // errLb
            // 
            this.errLb.BackColor = System.Drawing.Color.Transparent;
            this.errLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.errLb.Location = new System.Drawing.Point(177, 257);
            this.errLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errLb.Name = "errLb";
            this.errLb.Size = new System.Drawing.Size(212, 33);
            this.errLb.TabIndex = 41;
            this.errLb.Text = "Логин или пароль не верны";
            this.errLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errLb.Visible = false;
            this.errLb.Click += new System.EventHandler(this.errLb_Click_1);
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_enter.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_enter.BackColorGradientEnabled = true;
            this.btn_enter.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_enter.BorderColor = System.Drawing.Color.Tomato;
            this.btn_enter.BorderColorEnabled = false;
            this.btn_enter.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_enter.BorderColorOnHoverEnabled = false;
            this.btn_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enter.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.btn_enter.ForeColor = System.Drawing.Color.White;
            this.btn_enter.Location = new System.Drawing.Point(70, 293);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.RippleColor = System.Drawing.Color.Black;
            this.btn_enter.RoundingEnable = true;
            this.btn_enter.Size = new System.Drawing.Size(401, 47);
            this.btn_enter.TabIndex = 66;
            this.btn_enter.Text = "Войти";
            this.btn_enter.TextHover = null;
            this.btn_enter.UseDownPressEffectOnClick = false;
            this.btn_enter.UseRippleEffect = true;
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.UseZoomEffectOnHover = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tb_log
            // 
            this.tb_log.BackColor = System.Drawing.Color.White;
            this.tb_log.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_log.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_log.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_log.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_log.ForeColor = System.Drawing.Color.Black;
            this.tb_log.Location = new System.Drawing.Point(28, 158);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(492, 45);
            this.tb_log.TabIndex = 82;
            this.tb_log.TextInput = "";
            this.tb_log.TextPreview = "Введите логин";
            this.tb_log.UseSystemPasswordChar = false;
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
            this.tb_pass.Location = new System.Drawing.Point(29, 209);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(492, 45);
            this.tb_pass.TabIndex = 83;
            this.tb_pass.TextInput = "";
            this.tb_pass.TextPreview = "Введите пароль";
            this.tb_pass.UseSystemPasswordChar = false;
            // 
            // autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 417);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.footerLbl);
            this.Controls.Add(this.headingPic);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.forgetLink);
            this.Controls.Add(this.errLb);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "autorization";
            this.Text = "СИБИРЬ";
            this.Load += new System.EventHandler(this.autorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headingPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label footerLbl;
        private System.Windows.Forms.PictureBox headingPic;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel forgetLink;
        private System.Windows.Forms.Label errLb;
        private yt_Button btn_enter;
        private EgoldsGoogleTextBox tb_log;
        private EgoldsGoogleTextBox tb_pass;
    }
}