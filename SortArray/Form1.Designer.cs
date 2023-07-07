namespace SortArray
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
            label1 = new Label();
            txtSoPhanTu = new TextBox();
            btnTaoMangNgauNhien = new Button();
            btnSapXep = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMangBanDau = new TextBox();
            txtMangTang = new TextBox();
            txtMangGiam = new TextBox();
            txtMangDao = new TextBox();
            txtChanTangLeGiam = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "So phan tu: ";
            // 
            // txtSoPhanTu
            // 
            txtSoPhanTu.Location = new Point(88, 16);
            txtSoPhanTu.Name = "txtSoPhanTu";
            txtSoPhanTu.Size = new Size(56, 23);
            txtSoPhanTu.TabIndex = 1;
            // 
            // btnTaoMangNgauNhien
            // 
            btnTaoMangNgauNhien.Location = new Point(194, 11);
            btnTaoMangNgauNhien.Name = "btnTaoMangNgauNhien";
            btnTaoMangNgauNhien.Size = new Size(169, 30);
            btnTaoMangNgauNhien.TabIndex = 2;
            btnTaoMangNgauNhien.Text = "Tao mang ngau nhien";
            btnTaoMangNgauNhien.UseVisualStyleBackColor = true;
            btnTaoMangNgauNhien.Click += btnTaoMangNgauNhien_Click;
            // 
            // btnSapXep
            // 
            btnSapXep.Location = new Point(369, 12);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(102, 30);
            btnSapXep.TabIndex = 3;
            btnSapXep.Text = "Sap xep";
            btnSapXep.UseVisualStyleBackColor = true;
            btnSapXep.Click += btnSapXep_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 4;
            label2.Text = "Mang ban dau:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Mang tang:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 4;
            label4.Text = "Mang giam:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Mang dao:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 226);
            label6.Name = "label6";
            label6.Size = new Size(176, 15);
            label6.TabIndex = 4;
            label6.Text = "Mang chan tang, mang le giam:";
            // 
            // txtMangBanDau
            // 
            txtMangBanDau.BackColor = Color.LemonChiffon;
            txtMangBanDau.Location = new Point(194, 63);
            txtMangBanDau.Name = "txtMangBanDau";
            txtMangBanDau.Size = new Size(277, 23);
            txtMangBanDau.TabIndex = 5;
            // 
            // txtMangTang
            // 
            txtMangTang.Location = new Point(194, 105);
            txtMangTang.Name = "txtMangTang";
            txtMangTang.Size = new Size(277, 23);
            txtMangTang.TabIndex = 5;
            // 
            // txtMangGiam
            // 
            txtMangGiam.Location = new Point(194, 146);
            txtMangGiam.Name = "txtMangGiam";
            txtMangGiam.Size = new Size(277, 23);
            txtMangGiam.TabIndex = 5;
            // 
            // txtMangDao
            // 
            txtMangDao.Location = new Point(194, 185);
            txtMangDao.Name = "txtMangDao";
            txtMangDao.Size = new Size(277, 23);
            txtMangDao.TabIndex = 5;
            // 
            // txtChanTangLeGiam
            // 
            txtChanTangLeGiam.Location = new Point(194, 223);
            txtChanTangLeGiam.Name = "txtChanTangLeGiam";
            txtChanTangLeGiam.Size = new Size(277, 23);
            txtChanTangLeGiam.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 263);
            Controls.Add(txtChanTangLeGiam);
            Controls.Add(txtMangDao);
            Controls.Add(txtMangGiam);
            Controls.Add(txtMangTang);
            Controls.Add(txtMangBanDau);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSapXep);
            Controls.Add(btnTaoMangNgauNhien);
            Controls.Add(txtSoPhanTu);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoPhanTu;
        private Button btnTaoMangNgauNhien;
        private Button btnSapXep;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMangBanDau;
        private TextBox txtMangTang;
        private TextBox txtMangGiam;
        private TextBox txtMangDao;
        private TextBox txtChanTangLeGiam;
    }
}