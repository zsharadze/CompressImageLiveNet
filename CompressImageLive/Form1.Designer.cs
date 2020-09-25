namespace CompressImageLive
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalImgPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxCompressed = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarPercent = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompressPercent = new System.Windows.Forms.TextBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnShowInExplorer = new System.Windows.Forms.Button();
            this.lblOriginalSize = new System.Windows.Forms.Label();
            this.lblCompressedSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image path:";
            // 
            // txtOriginalImgPath
            // 
            this.txtOriginalImgPath.Location = new System.Drawing.Point(15, 25);
            this.txtOriginalImgPath.Name = "txtOriginalImgPath";
            this.txtOriginalImgPath.Size = new System.Drawing.Size(731, 20);
            this.txtOriginalImgPath.TabIndex = 1;
            this.txtOriginalImgPath.TextChanged += new System.EventHandler(this.txtOriginalImgPath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(752, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 20);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(29, 82);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(427, 341);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 3;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxCompressed
            // 
            this.pictureBoxCompressed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCompressed.Location = new System.Drawing.Point(486, 82);
            this.pictureBoxCompressed.Name = "pictureBoxCompressed";
            this.pictureBoxCompressed.Size = new System.Drawing.Size(427, 341);
            this.pictureBoxCompressed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCompressed.TabIndex = 4;
            this.pictureBoxCompressed.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Compressed";
            // 
            // trackBarPercent
            // 
            this.trackBarPercent.Location = new System.Drawing.Point(29, 452);
            this.trackBarPercent.Maximum = 100;
            this.trackBarPercent.Name = "trackBarPercent";
            this.trackBarPercent.Size = new System.Drawing.Size(356, 45);
            this.trackBarPercent.TabIndex = 7;
            this.trackBarPercent.Value = 70;
            this.trackBarPercent.Scroll += new System.EventHandler(this.trackBarPercent_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Compress Percent (Low = Lower Quality)";
            // 
            // txtCompressPercent
            // 
            this.txtCompressPercent.Location = new System.Drawing.Point(391, 461);
            this.txtCompressPercent.Name = "txtCompressPercent";
            this.txtCompressPercent.Size = new System.Drawing.Size(52, 20);
            this.txtCompressPercent.TabIndex = 9;
            this.txtCompressPercent.Text = "70";
            this.txtCompressPercent.TextChanged += new System.EventHandler(this.txtCompressPercent_TextChanged);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(486, 436);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(149, 45);
            this.btnCompress.TabIndex = 10;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnShowInExplorer
            // 
            this.btnShowInExplorer.Location = new System.Drawing.Point(764, 436);
            this.btnShowInExplorer.Name = "btnShowInExplorer";
            this.btnShowInExplorer.Size = new System.Drawing.Size(149, 45);
            this.btnShowInExplorer.TabIndex = 11;
            this.btnShowInExplorer.Text = "Show Compressed Image In Explorer";
            this.btnShowInExplorer.UseVisualStyleBackColor = true;
            this.btnShowInExplorer.Click += new System.EventHandler(this.btnShowInExplorer_Click);
            // 
            // lblOriginalSize
            // 
            this.lblOriginalSize.AutoSize = true;
            this.lblOriginalSize.Location = new System.Drawing.Point(408, 66);
            this.lblOriginalSize.Name = "lblOriginalSize";
            this.lblOriginalSize.Size = new System.Drawing.Size(0, 13);
            this.lblOriginalSize.TabIndex = 12;
            // 
            // lblCompressedSize
            // 
            this.lblCompressedSize.AutoSize = true;
            this.lblCompressedSize.Location = new System.Drawing.Point(869, 66);
            this.lblCompressedSize.Name = "lblCompressedSize";
            this.lblCompressedSize.Size = new System.Drawing.Size(0, 13);
            this.lblCompressedSize.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 509);
            this.Controls.Add(this.lblCompressedSize);
            this.Controls.Add(this.lblOriginalSize);
            this.Controls.Add(this.btnShowInExplorer);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.txtCompressPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxCompressed);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtOriginalImgPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compress Image Live .Net";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalImgPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxCompressed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompressPercent;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnShowInExplorer;
        private System.Windows.Forms.Label lblOriginalSize;
        private System.Windows.Forms.Label lblCompressedSize;
    }
}

