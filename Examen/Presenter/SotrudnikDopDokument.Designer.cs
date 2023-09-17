namespace Examen.Main
{
    partial class SotrudnikDopDokument
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
            this.btn_save = new Examen.yt_Button();
            this.tb_KPP = new Examen.EgoldsGoogleTextBox();
            this.tb_MED = new Examen.EgoldsGoogleTextBox();
            this.tb_POLIS = new Examen.EgoldsGoogleTextBox();
            this.tb_SNILS = new Examen.EgoldsGoogleTextBox();
            this.tb_INN = new Examen.EgoldsGoogleTextBox();
            this.tb_TRUD = new Examen.EgoldsGoogleTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_save.Location = new System.Drawing.Point(608, 72);
            this.btn_save.Name = "btn_save";
            this.btn_save.RippleColor = System.Drawing.Color.Black;
            this.btn_save.RoundingEnable = true;
            this.btn_save.Size = new System.Drawing.Size(99, 88);
            this.btn_save.TabIndex = 79;
            this.btn_save.Text = "Добавить/Изменить";
            this.btn_save.TextHover = null;
            this.btn_save.UseDownPressEffectOnClick = false;
            this.btn_save.UseRippleEffect = true;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.UseZoomEffectOnHover = false;
            // 
            // tb_KPP
            // 
            this.tb_KPP.BackColor = System.Drawing.Color.White;
            this.tb_KPP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_KPP.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_KPP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_KPP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_KPP.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_KPP.ForeColor = System.Drawing.Color.Black;
            this.tb_KPP.Location = new System.Drawing.Point(308, 87);
            this.tb_KPP.Name = "tb_KPP";
            this.tb_KPP.Size = new System.Drawing.Size(280, 50);
            this.tb_KPP.TabIndex = 78;
            this.tb_KPP.TextInput = "";
            this.tb_KPP.TextPreview = "Введите КПП";
            this.tb_KPP.UseSystemPasswordChar = false;
            // 
            // tb_MED
            // 
            this.tb_MED.BackColor = System.Drawing.Color.White;
            this.tb_MED.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_MED.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_MED.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_MED.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_MED.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_MED.ForeColor = System.Drawing.Color.Black;
            this.tb_MED.Location = new System.Drawing.Point(14, 143);
            this.tb_MED.Name = "tb_MED";
            this.tb_MED.Size = new System.Drawing.Size(280, 50);
            this.tb_MED.TabIndex = 77;
            this.tb_MED.TextInput = "";
            this.tb_MED.TextPreview = "Номер медецинской книжки";
            this.tb_MED.UseSystemPasswordChar = false;
            // 
            // tb_POLIS
            // 
            this.tb_POLIS.BackColor = System.Drawing.Color.White;
            this.tb_POLIS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_POLIS.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_POLIS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_POLIS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_POLIS.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_POLIS.ForeColor = System.Drawing.Color.Black;
            this.tb_POLIS.Location = new System.Drawing.Point(308, 31);
            this.tb_POLIS.Name = "tb_POLIS";
            this.tb_POLIS.Size = new System.Drawing.Size(280, 50);
            this.tb_POLIS.TabIndex = 76;
            this.tb_POLIS.TextInput = "";
            this.tb_POLIS.TextPreview = "Введите ПОЛИС";
            this.tb_POLIS.UseSystemPasswordChar = false;
            // 
            // tb_SNILS
            // 
            this.tb_SNILS.BackColor = System.Drawing.Color.White;
            this.tb_SNILS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_SNILS.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_SNILS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SNILS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_SNILS.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_SNILS.ForeColor = System.Drawing.Color.Black;
            this.tb_SNILS.Location = new System.Drawing.Point(14, 31);
            this.tb_SNILS.Name = "tb_SNILS";
            this.tb_SNILS.Size = new System.Drawing.Size(280, 50);
            this.tb_SNILS.TabIndex = 75;
            this.tb_SNILS.TextInput = "";
            this.tb_SNILS.TextPreview = "Введите номер СНИЛС";
            this.tb_SNILS.UseSystemPasswordChar = false;
            // 
            // tb_INN
            // 
            this.tb_INN.BackColor = System.Drawing.Color.White;
            this.tb_INN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_INN.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_INN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_INN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_INN.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_INN.ForeColor = System.Drawing.Color.Black;
            this.tb_INN.Location = new System.Drawing.Point(14, 87);
            this.tb_INN.Name = "tb_INN";
            this.tb_INN.Size = new System.Drawing.Size(280, 50);
            this.tb_INN.TabIndex = 80;
            this.tb_INN.TextInput = "";
            this.tb_INN.TextPreview = "Введите ИНН";
            this.tb_INN.UseSystemPasswordChar = false;
            // 
            // tb_TRUD
            // 
            this.tb_TRUD.BackColor = System.Drawing.Color.White;
            this.tb_TRUD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tb_TRUD.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.tb_TRUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_TRUD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_TRUD.FontTextPreview = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_TRUD.ForeColor = System.Drawing.Color.Black;
            this.tb_TRUD.Location = new System.Drawing.Point(308, 143);
            this.tb_TRUD.Name = "tb_TRUD";
            this.tb_TRUD.Size = new System.Drawing.Size(280, 50);
            this.tb_TRUD.TabIndex = 81;
            this.tb_TRUD.TextInput = "";
            this.tb_TRUD.TextPreview = "Номер трудовой книжки";
            this.tb_TRUD.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_TRUD);
            this.groupBox1.Controls.Add(this.tb_SNILS);
            this.groupBox1.Controls.Add(this.tb_INN);
            this.groupBox1.Controls.Add(this.tb_POLIS);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.tb_MED);
            this.groupBox1.Controls.Add(this.tb_KPP);
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 256);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // SotrudnikDopDokument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 457);
            this.Controls.Add(this.groupBox1);
            this.Name = "SotrudnikDopDokument";
            this.Text = "Дополнительные документы";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private yt_Button btn_save;
        private EgoldsGoogleTextBox tb_KPP;
        private EgoldsGoogleTextBox tb_MED;
        private EgoldsGoogleTextBox tb_POLIS;
        private EgoldsGoogleTextBox tb_SNILS;
        private EgoldsGoogleTextBox tb_INN;
        private EgoldsGoogleTextBox tb_TRUD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}