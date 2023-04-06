namespace Examen.Main
{
    partial class MaterialUSER
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sotrudniki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Sotrudniki
            // 
            this.DGV_Sotrudniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Sotrudniki.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Sotrudniki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Sotrudniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sotrudniki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Sotrudniki.Location = new System.Drawing.Point(20, 60);
            this.DGV_Sotrudniki.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Sotrudniki.Name = "DGV_Sotrudniki";
            this.DGV_Sotrudniki.RowHeadersWidth = 51;
            this.DGV_Sotrudniki.RowTemplate.Height = 24;
            this.DGV_Sotrudniki.Size = new System.Drawing.Size(933, 460);
            this.DGV_Sotrudniki.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examen.Properties.Resources._1286853;
            this.pictureBox1.Location = new System.Drawing.Point(174, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MaterialUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_Sotrudniki);
            this.Name = "MaterialUSER";
            this.Text = "MaterialUSER";
            this.Load += new System.EventHandler(this.MaterialUSER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sotrudniki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Sotrudniki;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}