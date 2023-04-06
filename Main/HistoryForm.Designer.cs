
namespace Examen.Main
{
    partial class HistoryForm
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
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_createObyav = new System.Windows.Forms.Button();
            this.btn_myObyav = new System.Windows.Forms.Button();
            this.btn_allObyav = new System.Windows.Forms.Button();
            this.dgv_histori = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_histori)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_setting);
            this.groupBox1.Controls.Add(this.btn_history);
            this.groupBox1.Controls.Add(this.btn_createObyav);
            this.groupBox1.Controls.Add(this.btn_myObyav);
            this.groupBox1.Controls.Add(this.btn_allObyav);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Доска объявлений";
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(12, 217);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(165, 39);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Text = "Настройки пользователя";
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(12, 172);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(165, 39);
            this.btn_history.TabIndex = 3;
            this.btn_history.Text = "История платежей";
            this.btn_history.UseVisualStyleBackColor = true;
            // 
            // btn_createObyav
            // 
            this.btn_createObyav.Location = new System.Drawing.Point(12, 127);
            this.btn_createObyav.Name = "btn_createObyav";
            this.btn_createObyav.Size = new System.Drawing.Size(165, 39);
            this.btn_createObyav.TabIndex = 2;
            this.btn_createObyav.Text = "Подать объявление";
            this.btn_createObyav.UseVisualStyleBackColor = true;
            // 
            // btn_myObyav
            // 
            this.btn_myObyav.Location = new System.Drawing.Point(12, 82);
            this.btn_myObyav.Name = "btn_myObyav";
            this.btn_myObyav.Size = new System.Drawing.Size(165, 39);
            this.btn_myObyav.TabIndex = 1;
            this.btn_myObyav.Text = "Мои объявления";
            this.btn_myObyav.UseVisualStyleBackColor = true;
            // 
            // btn_allObyav
            // 
            this.btn_allObyav.Location = new System.Drawing.Point(12, 37);
            this.btn_allObyav.Name = "btn_allObyav";
            this.btn_allObyav.Size = new System.Drawing.Size(165, 39);
            this.btn_allObyav.TabIndex = 0;
            this.btn_allObyav.Text = "Все объявления";
            this.btn_allObyav.UseVisualStyleBackColor = true;
            // 
            // dgv_histori
            // 
            this.dgv_histori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_histori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_histori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_histori.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_histori.Location = new System.Drawing.Point(206, 0);
            this.dgv_histori.Name = "dgv_histori";
            this.dgv_histori.Size = new System.Drawing.Size(594, 450);
            this.dgv_histori.TabIndex = 17;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_histori);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "HistoryForm";
            this.Text = "История платежей";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_histori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_createObyav;
        private System.Windows.Forms.Button btn_myObyav;
        private System.Windows.Forms.Button btn_allObyav;
        private System.Windows.Forms.DataGridView dgv_histori;
    }
}