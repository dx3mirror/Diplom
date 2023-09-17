namespace Examen.Main
{
    partial class Redaktor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pP_KADNIKOV3DataSet = new Examen.PP_KADNIKOV3DataSet();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.DVG_Users = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.DGV_activity = new System.Windows.Forms.DataGridView();
            this.btn_delete = new Examen.yt_Button();
            this.btn_update = new Examen.yt_Button();
            this.btn_insert = new Examen.yt_Button();
            this.tb_acces = new Examen.EgoldsGoogleTextBox();
            this.tb_pas = new Examen.EgoldsGoogleTextBox();
            this.tb_log = new Examen.EgoldsGoogleTextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Examen.PP_KADNIKOV3DataSetTableAdapters.UsersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DGV_reg = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pP_KADNIKOV3DataSet)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_Users)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_activity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1359, 515);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.DGV_reg);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1351, 476);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Просмотреть заявки на регестрацию";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.pP_KADNIKOV3DataSet;
            // 
            // pP_KADNIKOV3DataSet
            // 
            this.pP_KADNIKOV3DataSet.DataSetName = "PP_KADNIKOV3DataSet";
            this.pP_KADNIKOV3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.DVG_Users);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1351, 476);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Информация об аккаунтах";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // DVG_Users
            // 
            this.DVG_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVG_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DVG_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DVG_Users.DefaultCellStyle = dataGridViewCellStyle2;
            this.DVG_Users.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DVG_Users.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DVG_Users.Location = new System.Drawing.Point(0, 240);
            this.DVG_Users.Margin = new System.Windows.Forms.Padding(4);
            this.DVG_Users.Name = "DVG_Users";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVG_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DVG_Users.RowHeadersWidth = 51;
            this.DVG_Users.Size = new System.Drawing.Size(1351, 236);
            this.DVG_Users.TabIndex = 73;
            this.DVG_Users.DoubleClick += new System.EventHandler(this.DVG_Users_DoubleClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.DGV_activity);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1351, 476);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Журнал активности";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // DGV_activity
            // 
            this.DGV_activity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_activity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_activity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_activity.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_activity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_activity.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_activity.Location = new System.Drawing.Point(0, 240);
            this.DGV_activity.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_activity.Name = "DGV_activity";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_activity.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_activity.RowHeadersWidth = 51;
            this.DGV_activity.Size = new System.Drawing.Size(1351, 236);
            this.DGV_activity.TabIndex = 72;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_delete.BackColorAdditional = System.Drawing.Color.Gray;
            this.btn_delete.BackColorGradientEnabled = false;
            this.btn_delete.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btn_delete.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_delete.BorderColorEnabled = false;
            this.btn_delete.BorderColorOnHover = System.Drawing.Color.MidnightBlue;
            this.btn_delete.BorderColorOnHoverEnabled = false;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(859, 581);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RippleColor = System.Drawing.Color.Black;
            this.btn_delete.RoundingEnable = false;
            this.btn_delete.Size = new System.Drawing.Size(244, 31);
            this.btn_delete.TabIndex = 88;
            this.btn_delete.Text = "Удалить аккаунт";
            this.btn_delete.TextHover = "Просмотреть";
            this.btn_delete.UseDownPressEffectOnClick = false;
            this.btn_delete.UseRippleEffect = true;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.UseZoomEffectOnHover = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_update.BackColorAdditional = System.Drawing.Color.Gray;
            this.btn_update.BackColorGradientEnabled = false;
            this.btn_update.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btn_update.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_update.BorderColorEnabled = false;
            this.btn_update.BorderColorOnHover = System.Drawing.Color.MidnightBlue;
            this.btn_update.BorderColorOnHoverEnabled = false;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(609, 581);
            this.btn_update.Name = "btn_update";
            this.btn_update.RippleColor = System.Drawing.Color.Black;
            this.btn_update.RoundingEnable = false;
            this.btn_update.Size = new System.Drawing.Size(244, 31);
            this.btn_update.TabIndex = 87;
            this.btn_update.Text = "Изменить данные аккаунта";
            this.btn_update.TextHover = "Просмотреть";
            this.btn_update.UseDownPressEffectOnClick = false;
            this.btn_update.UseRippleEffect = true;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.UseZoomEffectOnHover = false;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_insert.BackColorAdditional = System.Drawing.Color.Gray;
            this.btn_insert.BackColorGradientEnabled = false;
            this.btn_insert.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btn_insert.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_insert.BorderColorEnabled = false;
            this.btn_insert.BorderColorOnHover = System.Drawing.Color.MidnightBlue;
            this.btn_insert.BorderColorOnHoverEnabled = false;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(359, 581);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.RippleColor = System.Drawing.Color.Black;
            this.btn_insert.RoundingEnable = false;
            this.btn_insert.Size = new System.Drawing.Size(244, 31);
            this.btn_insert.TabIndex = 86;
            this.btn_insert.Text = "Создать аккаунт";
            this.btn_insert.TextHover = "Просмотреть";
            this.btn_insert.UseDownPressEffectOnClick = false;
            this.btn_insert.UseRippleEffect = true;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.UseZoomEffectOnHover = false;
            // 
            // tb_acces
            // 
            this.tb_acces.BackColor = System.Drawing.Color.White;
            this.tb_acces.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_acces.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_acces.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_acces.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_acces.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_acces.ForeColor = System.Drawing.Color.Black;
            this.tb_acces.Location = new System.Drawing.Point(27, 683);
            this.tb_acces.Name = "tb_acces";
            this.tb_acces.Size = new System.Drawing.Size(312, 45);
            this.tb_acces.TabIndex = 85;
            this.tb_acces.TextInput = "";
            this.tb_acces.TextPreview = "Введите уровень доступа";
            this.tb_acces.UseSystemPasswordChar = false;
            // 
            // tb_pas
            // 
            this.tb_pas.BackColor = System.Drawing.Color.White;
            this.tb_pas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_pas.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_pas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pas.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pas.ForeColor = System.Drawing.Color.Black;
            this.tb_pas.Location = new System.Drawing.Point(24, 632);
            this.tb_pas.Name = "tb_pas";
            this.tb_pas.Size = new System.Drawing.Size(315, 45);
            this.tb_pas.TabIndex = 84;
            this.tb_pas.TextInput = "";
            this.tb_pas.TextPreview = "Введите пароль";
            this.tb_pas.UseSystemPasswordChar = false;
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
            this.tb_log.Location = new System.Drawing.Point(24, 581);
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(315, 45);
            this.tb_log.TabIndex = 83;
            this.tb_log.TextInput = "";
            this.tb_log.TextPreview = "Введите логин";
            this.tb_log.UseSystemPasswordChar = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.pP_KADNIKOV3DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.pP_KADNIKOV3DataSet;
            // 
            // DGV_reg
            // 
            this.DGV_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_reg.Location = new System.Drawing.Point(208, 89);
            this.DGV_reg.Name = "DGV_reg";
            this.DGV_reg.Size = new System.Drawing.Size(240, 150);
            this.DGV_reg.TabIndex = 2;
            // 
            // Redaktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 773);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_acces);
            this.Controls.Add(this.tb_pas);
            this.Controls.Add(this.tb_log);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Redaktor";
            this.Text = "Сибирь";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pP_KADNIKOV3DataSet)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVG_Users)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_activity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_reg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView DGV_activity;
        private EgoldsGoogleTextBox tb_log;
        private EgoldsGoogleTextBox tb_pas;
        private EgoldsGoogleTextBox tb_acces;
        private yt_Button btn_insert;
        private yt_Button btn_update;
        private yt_Button btn_delete;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.DataGridView DVG_Users;
        private PP_KADNIKOV3DataSet pP_KADNIKOV3DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PP_KADNIKOV3DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.DataGridView DGV_reg;
    }
}