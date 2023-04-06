namespace Examen.Main
{
    partial class Doljnost
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
            this.btn_save = new Examen.yt_Button();
            this.tb_adress = new Examen.EgoldsGoogleTextBox();
            this.tb_vidacha = new Examen.EgoldsGoogleTextBox();
            this.MasTb_pas = new Examen.EgoldsGoogleTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_dataregistracii = new System.Windows.Forms.DateTimePicker();
            this.dtp_datavidachi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.tb_adress);
            this.groupBox1.Controls.Add(this.tb_vidacha);
            this.groupBox1.Controls.Add(this.MasTb_pas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_dataregistracii);
            this.groupBox1.Controls.Add(this.dtp_datavidachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 324);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
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
            this.btn_save.Location = new System.Drawing.Point(606, 77);
            this.btn_save.Name = "btn_save";
            this.btn_save.RippleColor = System.Drawing.Color.Black;
            this.btn_save.RoundingEnable = true;
            this.btn_save.Size = new System.Drawing.Size(99, 88);
            this.btn_save.TabIndex = 70;
            this.btn_save.Text = "Добавить/Изменить";
            this.btn_save.TextHover = null;
            this.btn_save.UseDownPressEffectOnClick = false;
            this.btn_save.UseRippleEffect = true;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.UseZoomEffectOnHover = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_adress
            // 
            this.tb_adress.BackColor = System.Drawing.Color.White;
            this.tb_adress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_adress.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_adress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_adress.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_adress.ForeColor = System.Drawing.Color.Black;
            this.tb_adress.Location = new System.Drawing.Point(12, 157);
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(280, 50);
            this.tb_adress.TabIndex = 68;
            this.tb_adress.TextInput = "";
            this.tb_adress.TextPreview = "Ответсвенный за повышение";
            this.tb_adress.UseSystemPasswordChar = false;
            // 
            // tb_vidacha
            // 
            this.tb_vidacha.BackColor = System.Drawing.Color.White;
            this.tb_vidacha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_vidacha.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_vidacha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_vidacha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_vidacha.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_vidacha.ForeColor = System.Drawing.Color.Black;
            this.tb_vidacha.Location = new System.Drawing.Point(306, 36);
            this.tb_vidacha.Name = "tb_vidacha";
            this.tb_vidacha.Size = new System.Drawing.Size(280, 50);
            this.tb_vidacha.TabIndex = 67;
            this.tb_vidacha.TextInput = "";
            this.tb_vidacha.TextPreview = "Колличество повышений";
            this.tb_vidacha.UseSystemPasswordChar = false;
            // 
            // MasTb_pas
            // 
            this.MasTb_pas.BackColor = System.Drawing.Color.White;
            this.MasTb_pas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.MasTb_pas.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.MasTb_pas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MasTb_pas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasTb_pas.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasTb_pas.ForeColor = System.Drawing.Color.Black;
            this.MasTb_pas.Location = new System.Drawing.Point(12, 36);
            this.MasTb_pas.Name = "MasTb_pas";
            this.MasTb_pas.Size = new System.Drawing.Size(280, 50);
            this.MasTb_pas.TabIndex = 66;
            this.MasTb_pas.TextInput = "";
            this.MasTb_pas.TextPreview = "Наименование должности";
            this.MasTb_pas.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Дата повышения";
            // 
            // dtp_dataregistracii
            // 
            this.dtp_dataregistracii.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtp_dataregistracii.Location = new System.Drawing.Point(306, 108);
            this.dtp_dataregistracii.Name = "dtp_dataregistracii";
            this.dtp_dataregistracii.Size = new System.Drawing.Size(280, 27);
            this.dtp_dataregistracii.TabIndex = 50;
            // 
            // dtp_datavidachi
            // 
            this.dtp_datavidachi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtp_datavidachi.Location = new System.Drawing.Point(12, 108);
            this.dtp_datavidachi.Name = "dtp_datavidachi";
            this.dtp_datavidachi.Size = new System.Drawing.Size(280, 27);
            this.dtp_datavidachi.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(306, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "По какое";
            // 
            // Doljnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Doljnost";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Должность работника";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private yt_Button btn_save;
        private EgoldsGoogleTextBox tb_adress;
        private EgoldsGoogleTextBox tb_vidacha;
        private EgoldsGoogleTextBox MasTb_pas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_dataregistracii;
        private System.Windows.Forms.DateTimePicker dtp_datavidachi;
        private System.Windows.Forms.Label label5;
    }
}