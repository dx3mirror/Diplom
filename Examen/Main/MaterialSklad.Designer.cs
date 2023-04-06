namespace Examen.Main
{
    partial class MaterialSklad
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_Sotrudniki = new System.Windows.Forms.DataGridView();
            this.btn_save = new Examen.yt_Button();
            this.tb_nomer = new Examen.EgoldsGoogleTextBox();
            this.btn_xraneniy = new Examen.EgoldsGoogleTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_datavidachi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sotrudniki)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Sotrudniki);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.tb_nomer);
            this.groupBox1.Controls.Add(this.btn_xraneniy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_datavidachi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 282);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // DGV_Sotrudniki
            // 
            this.DGV_Sotrudniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Sotrudniki.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Sotrudniki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Sotrudniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sotrudniki.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_Sotrudniki.Location = new System.Drawing.Point(3, 22);
            this.DGV_Sotrudniki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV_Sotrudniki.Name = "DGV_Sotrudniki";
            this.DGV_Sotrudniki.RowHeadersWidth = 51;
            this.DGV_Sotrudniki.RowTemplate.Height = 24;
            this.DGV_Sotrudniki.Size = new System.Drawing.Size(596, 129);
            this.DGV_Sotrudniki.TabIndex = 71;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Violet;
            this.btn_save.BackColorAdditional = System.Drawing.Color.MediumTurquoise;
            this.btn_save.BackColorGradientEnabled = true;
            this.btn_save.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_save.BorderColor = System.Drawing.Color.Tomato;
            this.btn_save.BorderColorEnabled = false;
            this.btn_save.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.btn_save.BorderColorOnHoverEnabled = false;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(306, 227);
            this.btn_save.Name = "btn_save";
            this.btn_save.RippleColor = System.Drawing.Color.Black;
            this.btn_save.RoundingEnable = true;
            this.btn_save.Size = new System.Drawing.Size(271, 37);
            this.btn_save.TabIndex = 70;
            this.btn_save.Text = "Добавить/Изменить";
            this.btn_save.TextHover = null;
            this.btn_save.UseDownPressEffectOnClick = false;
            this.btn_save.UseRippleEffect = true;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.UseZoomEffectOnHover = false;
            // 
            // tb_nomer
            // 
            this.tb_nomer.BackColor = System.Drawing.Color.White;
            this.tb_nomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_nomer.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_nomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nomer.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_nomer.ForeColor = System.Drawing.Color.Black;
            this.tb_nomer.Location = new System.Drawing.Point(12, 157);
            this.tb_nomer.Name = "tb_nomer";
            this.tb_nomer.Size = new System.Drawing.Size(280, 50);
            this.tb_nomer.TabIndex = 68;
            this.tb_nomer.TextInput = "";
            this.tb_nomer.TextPreview = "Номер склада";
            this.tb_nomer.UseSystemPasswordChar = false;
            // 
            // btn_xraneniy
            // 
            this.btn_xraneniy.BackColor = System.Drawing.Color.White;
            this.btn_xraneniy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_xraneniy.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btn_xraneniy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_xraneniy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_xraneniy.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_xraneniy.ForeColor = System.Drawing.Color.Black;
            this.btn_xraneniy.Location = new System.Drawing.Point(12, 214);
            this.btn_xraneniy.Name = "btn_xraneniy";
            this.btn_xraneniy.Size = new System.Drawing.Size(280, 50);
            this.btn_xraneniy.TabIndex = 66;
            this.btn_xraneniy.TextInput = "";
            this.btn_xraneniy.TextPreview = "Особые условия хранения";
            this.btn_xraneniy.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(294, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Дата выдачи";
            // 
            // dtp_datavidachi
            // 
            this.dtp_datavidachi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtp_datavidachi.Location = new System.Drawing.Point(298, 181);
            this.dtp_datavidachi.Name = "dtp_datavidachi";
            this.dtp_datavidachi.Size = new System.Drawing.Size(280, 27);
            this.dtp_datavidachi.TabIndex = 49;
            // 
            // MaterialSklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 347);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MaterialSklad";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "MaterialSklad";
            this.Load += new System.EventHandler(this.MaterialSklad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sotrudniki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private yt_Button btn_save;
        private EgoldsGoogleTextBox tb_nomer;
        private EgoldsGoogleTextBox btn_xraneniy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_datavidachi;
        private System.Windows.Forms.DataGridView DGV_Sotrudniki;
    }
}