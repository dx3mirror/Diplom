namespace Examen.Main
{
    partial class Infomaterial
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
            this.DGV_Sotrudniki = new System.Windows.Forms.DataGridView();
            this.btn_sklad = new Examen.yt_Button();
            this.btn_Update = new Examen.yt_Button();
            this.btn_insetr = new Examen.yt_Button();
            this.btn_kah = new Examen.EgoldsGoogleTextBox();
            this.btn_KOL = new Examen.EgoldsGoogleTextBox();
            this.btn_tabNom = new Examen.EgoldsGoogleTextBox();
            this.tb_naz = new Examen.EgoldsGoogleTextBox();
            this.yt_Button1 = new Examen.yt_Button();
            this.errLb = new System.Windows.Forms.Label();
            this.yt_Button2 = new Examen.yt_Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sotrudniki)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Sotrudniki
            // 
            this.DGV_Sotrudniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Sotrudniki.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Sotrudniki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Sotrudniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sotrudniki.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_Sotrudniki.Location = new System.Drawing.Point(15, 60);
            this.DGV_Sotrudniki.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Sotrudniki.Name = "DGV_Sotrudniki";
            this.DGV_Sotrudniki.RowHeadersWidth = 51;
            this.DGV_Sotrudniki.RowTemplate.Height = 24;
            this.DGV_Sotrudniki.Size = new System.Drawing.Size(901, 264);
            this.DGV_Sotrudniki.TabIndex = 0;
            this.DGV_Sotrudniki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Sotrudniki_CellClick);
            this.DGV_Sotrudniki.DoubleClick += new System.EventHandler(this.DGV_Sotrudniki_DoubleClick);
            // 
            // btn_sklad
            // 
            this.btn_sklad.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_sklad.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_sklad.BackColorGradientEnabled = true;
            this.btn_sklad.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_sklad.BorderColor = System.Drawing.Color.Tomato;
            this.btn_sklad.BorderColorEnabled = false;
            this.btn_sklad.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_sklad.BorderColorOnHoverEnabled = false;
            this.btn_sklad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sklad.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.btn_sklad.ForeColor = System.Drawing.Color.White;
            this.btn_sklad.Location = new System.Drawing.Point(617, 393);
            this.btn_sklad.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sklad.Name = "btn_sklad";
            this.btn_sklad.RippleColor = System.Drawing.Color.Black;
            this.btn_sklad.RoundingEnable = true;
            this.btn_sklad.Size = new System.Drawing.Size(284, 24);
            this.btn_sklad.TabIndex = 70;
            this.btn_sklad.Text = "Просмотреть нахождение";
            this.btn_sklad.TextHover = null;
            this.btn_sklad.UseDownPressEffectOnClick = false;
            this.btn_sklad.UseRippleEffect = true;
            this.btn_sklad.UseVisualStyleBackColor = false;
            this.btn_sklad.UseZoomEffectOnHover = false;
            this.btn_sklad.Click += new System.EventHandler(this.btn_sklad_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Update.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_Update.BackColorGradientEnabled = true;
            this.btn_Update.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_Update.BorderColor = System.Drawing.Color.Tomato;
            this.btn_Update.BorderColorEnabled = false;
            this.btn_Update.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_Update.BorderColorOnHoverEnabled = false;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(617, 365);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.RippleColor = System.Drawing.Color.Black;
            this.btn_Update.RoundingEnable = true;
            this.btn_Update.Size = new System.Drawing.Size(284, 24);
            this.btn_Update.TabIndex = 69;
            this.btn_Update.Text = "Изменить";
            this.btn_Update.TextHover = null;
            this.btn_Update.UseDownPressEffectOnClick = false;
            this.btn_Update.UseRippleEffect = true;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.UseZoomEffectOnHover = false;
            // 
            // btn_insetr
            // 
            this.btn_insetr.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_insetr.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_insetr.BackColorGradientEnabled = true;
            this.btn_insetr.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_insetr.BorderColor = System.Drawing.Color.Tomato;
            this.btn_insetr.BorderColorEnabled = false;
            this.btn_insetr.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_insetr.BorderColorOnHoverEnabled = false;
            this.btn_insetr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insetr.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.btn_insetr.ForeColor = System.Drawing.Color.White;
            this.btn_insetr.Location = new System.Drawing.Point(617, 337);
            this.btn_insetr.Margin = new System.Windows.Forms.Padding(2);
            this.btn_insetr.Name = "btn_insetr";
            this.btn_insetr.RippleColor = System.Drawing.Color.Black;
            this.btn_insetr.RoundingEnable = true;
            this.btn_insetr.Size = new System.Drawing.Size(284, 24);
            this.btn_insetr.TabIndex = 68;
            this.btn_insetr.Text = "Добавить";
            this.btn_insetr.TextHover = null;
            this.btn_insetr.UseDownPressEffectOnClick = false;
            this.btn_insetr.UseRippleEffect = true;
            this.btn_insetr.UseVisualStyleBackColor = false;
            this.btn_insetr.UseZoomEffectOnHover = false;
            // 
            // btn_kah
            // 
            this.btn_kah.BackColor = System.Drawing.Color.White;
            this.btn_kah.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_kah.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btn_kah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_kah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_kah.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_kah.ForeColor = System.Drawing.Color.Black;
            this.btn_kah.Location = new System.Drawing.Point(322, 403);
            this.btn_kah.Name = "btn_kah";
            this.btn_kah.Size = new System.Drawing.Size(280, 50);
            this.btn_kah.TabIndex = 67;
            this.btn_kah.TextInput = "";
            this.btn_kah.TextPreview = "Качество";
            this.btn_kah.UseSystemPasswordChar = false;
            // 
            // btn_KOL
            // 
            this.btn_KOL.BackColor = System.Drawing.Color.White;
            this.btn_KOL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_KOL.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btn_KOL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_KOL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_KOL.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_KOL.ForeColor = System.Drawing.Color.Black;
            this.btn_KOL.Location = new System.Drawing.Point(322, 330);
            this.btn_KOL.Name = "btn_KOL";
            this.btn_KOL.Size = new System.Drawing.Size(280, 50);
            this.btn_KOL.TabIndex = 66;
            this.btn_KOL.TextInput = "";
            this.btn_KOL.TextPreview = "Колличество";
            this.btn_KOL.UseSystemPasswordChar = false;
            // 
            // btn_tabNom
            // 
            this.btn_tabNom.BackColor = System.Drawing.Color.White;
            this.btn_tabNom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_tabNom.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btn_tabNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_tabNom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_tabNom.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_tabNom.ForeColor = System.Drawing.Color.Black;
            this.btn_tabNom.Location = new System.Drawing.Point(15, 403);
            this.btn_tabNom.Name = "btn_tabNom";
            this.btn_tabNom.Size = new System.Drawing.Size(280, 50);
            this.btn_tabNom.TabIndex = 65;
            this.btn_tabNom.TextInput = "";
            this.btn_tabNom.TextPreview = "Табельный номер";
            this.btn_tabNom.UseSystemPasswordChar = false;
            // 
            // tb_naz
            // 
            this.tb_naz.BackColor = System.Drawing.Color.White;
            this.tb_naz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_naz.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_naz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_naz.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_naz.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_naz.ForeColor = System.Drawing.Color.Black;
            this.tb_naz.Location = new System.Drawing.Point(15, 330);
            this.tb_naz.Name = "tb_naz";
            this.tb_naz.Size = new System.Drawing.Size(280, 50);
            this.tb_naz.TabIndex = 64;
            this.tb_naz.TextInput = "";
            this.tb_naz.TextPreview = "Название материала";
            this.tb_naz.UseSystemPasswordChar = false;
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
            this.yt_Button1.Location = new System.Drawing.Point(617, 449);
            this.yt_Button1.Margin = new System.Windows.Forms.Padding(2);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(290, 24);
            this.yt_Button1.TabIndex = 71;
            this.yt_Button1.Text = "Вернуться обратно";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // errLb
            // 
            this.errLb.BackColor = System.Drawing.Color.Transparent;
            this.errLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.errLb.Location = new System.Drawing.Point(334, 457);
            this.errLb.Name = "errLb";
            this.errLb.Size = new System.Drawing.Size(253, 27);
            this.errLb.TabIndex = 72;
            this.errLb.Text = "От 0% до 100%";
            this.errLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yt_Button2
            // 
            this.yt_Button2.BackColor = System.Drawing.Color.DarkBlue;
            this.yt_Button2.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.yt_Button2.BackColorGradientEnabled = true;
            this.yt_Button2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button2.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button2.BorderColorEnabled = false;
            this.yt_Button2.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button2.BorderColorOnHoverEnabled = false;
            this.yt_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button2.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
            this.yt_Button2.ForeColor = System.Drawing.Color.White;
            this.yt_Button2.Location = new System.Drawing.Point(617, 421);
            this.yt_Button2.Margin = new System.Windows.Forms.Padding(2);
            this.yt_Button2.Name = "yt_Button2";
            this.yt_Button2.RippleColor = System.Drawing.Color.Black;
            this.yt_Button2.RoundingEnable = true;
            this.yt_Button2.Size = new System.Drawing.Size(284, 24);
            this.yt_Button2.TabIndex = 73;
            this.yt_Button2.Text = "Удалить";
            this.yt_Button2.TextHover = null;
            this.yt_Button2.UseDownPressEffectOnClick = false;
            this.yt_Button2.UseRippleEffect = true;
            this.yt_Button2.UseVisualStyleBackColor = false;
            this.yt_Button2.UseZoomEffectOnHover = false;
            this.yt_Button2.Click += new System.EventHandler(this.yt_Button2_Click);
            // 
            // Infomaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 500);
            this.Controls.Add(this.yt_Button2);
            this.Controls.Add(this.errLb);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.btn_sklad);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_insetr);
            this.Controls.Add(this.btn_kah);
            this.Controls.Add(this.btn_KOL);
            this.Controls.Add(this.btn_tabNom);
            this.Controls.Add(this.tb_naz);
            this.Controls.Add(this.DGV_Sotrudniki);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Infomaterial";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "СИБИРЬ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sotrudniki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Sotrudniki;
        private EgoldsGoogleTextBox tb_naz;
        private EgoldsGoogleTextBox btn_tabNom;
        private EgoldsGoogleTextBox btn_KOL;
        private EgoldsGoogleTextBox btn_kah;
        private yt_Button btn_insetr;
        private yt_Button btn_Update;
        private yt_Button btn_sklad;
        private yt_Button yt_Button1;
        private System.Windows.Forms.Label errLb;
        private yt_Button yt_Button2;
    }
}