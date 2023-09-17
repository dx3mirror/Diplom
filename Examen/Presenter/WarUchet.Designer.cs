namespace Examen.Main
{
    partial class WarUchet
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
            this.DGV_Family = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new Examen.yt_Button();
            this.btn_upd = new Examen.yt_Button();
            this.btn_del = new Examen.yt_Button();
            this.cb_stepenrodstva = new Examen.EgoldsGoogleTextBox();
            this.tb_fio = new Examen.EgoldsGoogleTextBox();
            this.tb_sostav = new Examen.EgoldsGoogleTextBox();
            this.tb_VUS = new Examen.EgoldsGoogleTextBox();
            this.cb_UCHET = new Examen.EgoldsGoogleTextBox();
            this.tb_voinskiy = new Examen.EgoldsGoogleTextBox();
            this.tb_category = new Examen.EgoldsGoogleTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Family)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Family
            // 
            this.DGV_Family.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Family.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Family.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Family.Location = new System.Drawing.Point(15, 49);
            this.DGV_Family.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Family.Name = "DGV_Family";
            this.DGV_Family.RowHeadersWidth = 51;
            this.DGV_Family.Size = new System.Drawing.Size(893, 221);
            this.DGV_Family.TabIndex = 72;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_category);
            this.groupBox1.Controls.Add(this.tb_voinskiy);
            this.groupBox1.Controls.Add(this.cb_UCHET);
            this.groupBox1.Controls.Add(this.tb_VUS);
            this.groupBox1.Controls.Add(this.tb_sostav);
            this.groupBox1.Controls.Add(this.tb_fio);
            this.groupBox1.Controls.Add(this.cb_stepenrodstva);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.btn_upd);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(15, 270);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(893, 241);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_add.BackColorAdditional = System.Drawing.Color.Gray;
            this.btn_add.BackColorGradientEnabled = false;
            this.btn_add.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btn_add.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_add.BorderColorEnabled = false;
            this.btn_add.BorderColorOnHover = System.Drawing.Color.MidnightBlue;
            this.btn_add.BorderColorOnHoverEnabled = false;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(645, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.RippleColor = System.Drawing.Color.Black;
            this.btn_add.RoundingEnable = false;
            this.btn_add.Size = new System.Drawing.Size(244, 50);
            this.btn_add.TabIndex = 87;
            this.btn_add.Text = "Добавить";
            this.btn_add.TextHover = "Просмотреть";
            this.btn_add.UseDownPressEffectOnClick = false;
            this.btn_add.UseRippleEffect = true;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.UseZoomEffectOnHover = false;
            // 
            // btn_upd
            // 
            this.btn_upd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_upd.BackColorAdditional = System.Drawing.Color.Gray;
            this.btn_upd.BackColorGradientEnabled = false;
            this.btn_upd.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btn_upd.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_upd.BorderColorEnabled = false;
            this.btn_upd.BorderColorOnHover = System.Drawing.Color.MidnightBlue;
            this.btn_upd.BorderColorOnHoverEnabled = false;
            this.btn_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_upd.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_upd.ForeColor = System.Drawing.Color.White;
            this.btn_upd.Location = new System.Drawing.Point(644, 75);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.RippleColor = System.Drawing.Color.Black;
            this.btn_upd.RoundingEnable = false;
            this.btn_upd.Size = new System.Drawing.Size(244, 50);
            this.btn_upd.TabIndex = 88;
            this.btn_upd.Text = "Обновить запись";
            this.btn_upd.TextHover = "Просмотреть";
            this.btn_upd.UseDownPressEffectOnClick = false;
            this.btn_upd.UseRippleEffect = true;
            this.btn_upd.UseVisualStyleBackColor = false;
            this.btn_upd.UseZoomEffectOnHover = false;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_del.BackColorAdditional = System.Drawing.Color.Gray;
            this.btn_del.BackColorGradientEnabled = false;
            this.btn_del.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btn_del.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_del.BorderColorEnabled = false;
            this.btn_del.BorderColorOnHover = System.Drawing.Color.MidnightBlue;
            this.btn_del.BorderColorOnHoverEnabled = false;
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(644, 131);
            this.btn_del.Name = "btn_del";
            this.btn_del.RippleColor = System.Drawing.Color.Black;
            this.btn_del.RoundingEnable = false;
            this.btn_del.Size = new System.Drawing.Size(244, 50);
            this.btn_del.TabIndex = 89;
            this.btn_del.Text = "Удалить аккаунт ";
            this.btn_del.TextHover = "Просмотреть";
            this.btn_del.UseDownPressEffectOnClick = false;
            this.btn_del.UseRippleEffect = true;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.UseZoomEffectOnHover = false;
            // 
            // cb_stepenrodstva
            // 
            this.cb_stepenrodstva.BackColor = System.Drawing.Color.White;
            this.cb_stepenrodstva.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cb_stepenrodstva.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.cb_stepenrodstva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cb_stepenrodstva.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_stepenrodstva.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_stepenrodstva.ForeColor = System.Drawing.Color.Black;
            this.cb_stepenrodstva.Location = new System.Drawing.Point(5, 19);
            this.cb_stepenrodstva.Name = "cb_stepenrodstva";
            this.cb_stepenrodstva.Size = new System.Drawing.Size(280, 50);
            this.cb_stepenrodstva.TabIndex = 90;
            this.cb_stepenrodstva.TextInput = "";
            this.cb_stepenrodstva.TextPreview = "Категория запаса";
            this.cb_stepenrodstva.UseSystemPasswordChar = false;
            // 
            // tb_fio
            // 
            this.tb_fio.BackColor = System.Drawing.Color.White;
            this.tb_fio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_fio.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_fio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_fio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_fio.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_fio.ForeColor = System.Drawing.Color.Black;
            this.tb_fio.Location = new System.Drawing.Point(5, 75);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(280, 50);
            this.tb_fio.TabIndex = 91;
            this.tb_fio.TextInput = "";
            this.tb_fio.TextPreview = "Воинское звание";
            this.tb_fio.UseSystemPasswordChar = false;
            // 
            // tb_sostav
            // 
            this.tb_sostav.BackColor = System.Drawing.Color.White;
            this.tb_sostav.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_sostav.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_sostav.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sostav.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sostav.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_sostav.ForeColor = System.Drawing.Color.Black;
            this.tb_sostav.Location = new System.Drawing.Point(4, 131);
            this.tb_sostav.Name = "tb_sostav";
            this.tb_sostav.Size = new System.Drawing.Size(280, 50);
            this.tb_sostav.TabIndex = 92;
            this.tb_sostav.TextInput = "";
            this.tb_sostav.TextPreview = "Состав (профиль)";
            this.tb_sostav.UseSystemPasswordChar = false;
            // 
            // tb_VUS
            // 
            this.tb_VUS.BackColor = System.Drawing.Color.White;
            this.tb_VUS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_VUS.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_VUS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_VUS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_VUS.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_VUS.ForeColor = System.Drawing.Color.Black;
            this.tb_VUS.Location = new System.Drawing.Point(291, 19);
            this.tb_VUS.Name = "tb_VUS";
            this.tb_VUS.Size = new System.Drawing.Size(306, 50);
            this.tb_VUS.TabIndex = 93;
            this.tb_VUS.TextInput = "";
            this.tb_VUS.TextPreview = "Полное кодовое обозначение ВУС";
            this.tb_VUS.UseSystemPasswordChar = false;
            // 
            // cb_UCHET
            // 
            this.cb_UCHET.BackColor = System.Drawing.Color.White;
            this.cb_UCHET.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cb_UCHET.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.cb_UCHET.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cb_UCHET.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_UCHET.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_UCHET.ForeColor = System.Drawing.Color.Black;
            this.cb_UCHET.Location = new System.Drawing.Point(291, 75);
            this.cb_UCHET.Name = "cb_UCHET";
            this.cb_UCHET.Size = new System.Drawing.Size(306, 50);
            this.cb_UCHET.TabIndex = 94;
            this.cb_UCHET.TextInput = "";
            this.cb_UCHET.TextPreview = "Состоит на воинском учете: ";
            this.cb_UCHET.UseSystemPasswordChar = false;
            // 
            // tb_voinskiy
            // 
            this.tb_voinskiy.BackColor = System.Drawing.Color.White;
            this.tb_voinskiy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_voinskiy.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_voinskiy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_voinskiy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_voinskiy.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_voinskiy.ForeColor = System.Drawing.Color.Black;
            this.tb_voinskiy.Location = new System.Drawing.Point(4, 187);
            this.tb_voinskiy.Name = "tb_voinskiy";
            this.tb_voinskiy.Size = new System.Drawing.Size(593, 50);
            this.tb_voinskiy.TabIndex = 95;
            this.tb_voinskiy.TextInput = "";
            this.tb_voinskiy.TextPreview = "Наименование военного   комиссариата по месту жительства ";
            this.tb_voinskiy.UseSystemPasswordChar = false;
            // 
            // tb_category
            // 
            this.tb_category.BackColor = System.Drawing.Color.White;
            this.tb_category.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_category.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_category.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_category.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_category.ForeColor = System.Drawing.Color.Black;
            this.tb_category.Location = new System.Drawing.Point(291, 131);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(306, 50);
            this.tb_category.TabIndex = 96;
            this.tb_category.TextInput = "";
            this.tb_category.TextPreview = "Категория годности к военной службе ";
            this.tb_category.UseSystemPasswordChar = false;
            // 
            // WarUchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 527);
            this.Controls.Add(this.DGV_Family);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WarUchet";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Сибирь";
            this.Load += new System.EventHandler(this.WarUchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Family)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Family;
        private System.Windows.Forms.GroupBox groupBox1;
        private yt_Button btn_del;
        private yt_Button btn_upd;
        private yt_Button btn_add;
        private EgoldsGoogleTextBox tb_category;
        private EgoldsGoogleTextBox tb_voinskiy;
        private EgoldsGoogleTextBox cb_UCHET;
        private EgoldsGoogleTextBox tb_VUS;
        private EgoldsGoogleTextBox tb_sostav;
        private EgoldsGoogleTextBox tb_fio;
        private EgoldsGoogleTextBox cb_stepenrodstva;
    }
}