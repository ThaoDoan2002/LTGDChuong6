namespace StringProcess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            txtS1 = new TextBox();
            txtS2 = new TextBox();
            label4 = new Label();
            txtS3 = new TextBox();
            groupBox1 = new GroupBox();
            btnChen = new Button();
            label5 = new Label();
            txtIndex = new TextBox();
            btnReplaceS2S3 = new Button();
            btnXoaS2TrongS1 = new Button();
            btnDaoS1 = new Button();
            btnChuanHoaChuoi = new Button();
            timerTitle = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.BackColor = SystemColors.ActiveCaption;
            lbTitle.Dock = DockStyle.Top;
            lbTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = SystemColors.Highlight;
            lbTitle.Location = new Point(0, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(518, 52);
            lbTitle.TabIndex = 0;
            lbTitle.Text = " CHUONG TRINH MINH HOA XU LY CHUOI";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Chuoi s1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "Chuoi s2:";
            // 
            // txtS1
            // 
            txtS1.Location = new Point(74, 74);
            txtS1.Name = "txtS1";
            txtS1.Size = new Size(431, 23);
            txtS1.TabIndex = 2;
            // 
            // txtS2
            // 
            txtS2.Location = new Point(74, 114);
            txtS2.Name = "txtS2";
            txtS2.Size = new Size(174, 23);
            txtS2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 117);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 1;
            label4.Text = "Chuoi s3:";
            // 
            // txtS3
            // 
            txtS3.Location = new Point(331, 114);
            txtS3.Name = "txtS3";
            txtS3.Size = new Size(174, 23);
            txtS3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtIndex);
            groupBox1.Location = new Point(25, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 58);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chen chuoi s2 vao s1";
            // 
            // btnChen
            // 
            btnChen.FlatStyle = FlatStyle.Popup;
            btnChen.Location = new Point(101, 19);
            btnChen.Name = "btnChen";
            btnChen.Size = new Size(75, 23);
            btnChen.TabIndex = 3;
            btnChen.Text = "Chen";
            btnChen.UseVisualStyleBackColor = true;
            btnChen.Click += btnChen_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 1;
            label5.Text = "Vi tri:";
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(46, 19);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(49, 23);
            txtIndex.TabIndex = 2;
            // 
            // btnReplaceS2S3
            // 
            btnReplaceS2S3.FlatStyle = FlatStyle.Popup;
            btnReplaceS2S3.Location = new Point(221, 169);
            btnReplaceS2S3.Name = "btnReplaceS2S3";
            btnReplaceS2S3.Size = new Size(133, 23);
            btnReplaceS2S3.TabIndex = 3;
            btnReplaceS2S3.Text = "Thay the s2 bang s3";
            btnReplaceS2S3.UseVisualStyleBackColor = true;
            btnReplaceS2S3.Click += btnReplaceS2S3_Click;
            // 
            // btnXoaS2TrongS1
            // 
            btnXoaS2TrongS1.FlatStyle = FlatStyle.Popup;
            btnXoaS2TrongS1.Location = new Point(221, 198);
            btnXoaS2TrongS1.Name = "btnXoaS2TrongS1";
            btnXoaS2TrongS1.Size = new Size(133, 23);
            btnXoaS2TrongS1.TabIndex = 3;
            btnXoaS2TrongS1.Text = "Xoa s2 trong s1";
            btnXoaS2TrongS1.UseVisualStyleBackColor = true;
            btnXoaS2TrongS1.Click += btnXoaS2TrongS1_Click;
            // 
            // btnDaoS1
            // 
            btnDaoS1.FlatStyle = FlatStyle.Popup;
            btnDaoS1.Location = new Point(374, 169);
            btnDaoS1.Name = "btnDaoS1";
            btnDaoS1.Size = new Size(133, 23);
            btnDaoS1.TabIndex = 3;
            btnDaoS1.Text = "Dao tu trong s1";
            btnDaoS1.UseVisualStyleBackColor = true;
            btnDaoS1.Click += btnDaoS1_Click;
            // 
            // btnChuanHoaChuoi
            // 
            btnChuanHoaChuoi.FlatStyle = FlatStyle.Popup;
            btnChuanHoaChuoi.Location = new Point(374, 198);
            btnChuanHoaChuoi.Name = "btnChuanHoaChuoi";
            btnChuanHoaChuoi.Size = new Size(133, 23);
            btnChuanHoaChuoi.TabIndex = 3;
            btnChuanHoaChuoi.Text = "Chuan hoa chuoi";
            btnChuanHoaChuoi.UseVisualStyleBackColor = true;
            btnChuanHoaChuoi.Click += btnChuanHoaChuoi_Click;
            // 
            // timerTitle
            // 
            timerTitle.Tick += timerTitle_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 241);
            Controls.Add(btnChuanHoaChuoi);
            Controls.Add(btnXoaS2TrongS1);
            Controls.Add(btnDaoS1);
            Controls.Add(btnReplaceS2S3);
            Controls.Add(groupBox1);
            Controls.Add(txtS3);
            Controls.Add(txtS2);
            Controls.Add(txtS1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label2;
        private Label label3;
        private TextBox txtS1;
        private TextBox txtS2;
        private Label label4;
        private TextBox txtS3;
        private GroupBox groupBox1;
        private Button btnChen;
        private Label label5;
        private TextBox txtIndex;
        private Button btnReplaceS2S3;
        private Button btnXoaS2TrongS1;
        private Button btnDaoS1;
        private Button btnChuanHoaChuoi;
        private System.Windows.Forms.Timer timerTitle;
    }
}