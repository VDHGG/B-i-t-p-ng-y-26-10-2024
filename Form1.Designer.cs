namespace QuanLyDanhSachSvWithCode
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.ThemButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MsvText = new System.Windows.Forms.TextBox();
            this.LopSvText = new System.Windows.Forms.TextBox();
            this.TenSvText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InputTimKiem = new System.Windows.Forms.TextBox();
            this.OutputTSV = new System.Windows.Forms.TextBox();
            this.OutputLop = new System.Windows.Forms.TextBox();
            this.OutputMSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TraCuuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(73, 49);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(428, 159);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // ThemButton
            // 
            this.ThemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemButton.Location = new System.Drawing.Point(73, 405);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(96, 32);
            this.ThemButton.TabIndex = 1;
            this.ThemButton.Text = "THÊM";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(405, 405);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(96, 32);
            this.XoaButton.TabIndex = 3;
            this.XoaButton.Text = "XÓA";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // SuaButton
            // 
            this.SuaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaButton.Location = new System.Drawing.Point(245, 405);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(96, 32);
            this.SuaButton.TabIndex = 4;
            this.SuaButton.Text = "SỬA";
            this.SuaButton.UseVisualStyleBackColor = true;
            this.SuaButton.Click += new System.EventHandler(this.SuaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "NHẬP MSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "NHẬP TÊN SV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "NHẬP LỚP SV:";
            // 
            // MsvText
            // 
            this.MsvText.Location = new System.Drawing.Point(197, 244);
            this.MsvText.Name = "MsvText";
            this.MsvText.Size = new System.Drawing.Size(326, 22);
            this.MsvText.TabIndex = 8;
            // 
            // LopSvText
            // 
            this.LopSvText.Location = new System.Drawing.Point(197, 341);
            this.LopSvText.Name = "LopSvText";
            this.LopSvText.Size = new System.Drawing.Size(326, 22);
            this.LopSvText.TabIndex = 9;
            // 
            // TenSvText
            // 
            this.TenSvText.Location = new System.Drawing.Point(197, 290);
            this.TenSvText.Name = "TenSvText";
            this.TenSvText.Size = new System.Drawing.Size(326, 22);
            this.TenSvText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(854, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "TRA CỨU SINH VIÊN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "NHẬP MÃ SINH VIÊN CẦN TÌM:";
            // 
            // InputTimKiem
            // 
            this.InputTimKiem.Location = new System.Drawing.Point(833, 125);
            this.InputTimKiem.Name = "InputTimKiem";
            this.InputTimKiem.Size = new System.Drawing.Size(421, 22);
            this.InputTimKiem.TabIndex = 13;
            // 
            // OutputTSV
            // 
            this.OutputTSV.Location = new System.Drawing.Point(833, 342);
            this.OutputTSV.Name = "OutputTSV";
            this.OutputTSV.Size = new System.Drawing.Size(326, 22);
            this.OutputTSV.TabIndex = 19;
            // 
            // OutputLop
            // 
            this.OutputLop.Location = new System.Drawing.Point(833, 393);
            this.OutputLop.Name = "OutputLop";
            this.OutputLop.Size = new System.Drawing.Size(326, 22);
            this.OutputLop.TabIndex = 18;
            // 
            // OutputMSV
            // 
            this.OutputMSV.Location = new System.Drawing.Point(833, 296);
            this.OutputMSV.Name = "OutputMSV";
            this.OutputMSV.Size = new System.Drawing.Size(326, 22);
            this.OutputMSV.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "LỚP SV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "TÊN SV:";
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Location = new System.Drawing.Point(709, 303);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(39, 16);
            this.textbox.TabIndex = 14;
            this.textbox.Text = "MSV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(847, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "THÔNG TIN SINH VIÊN CẦN TÌM";
            // 
            // TraCuuButton
            // 
            this.TraCuuButton.Location = new System.Drawing.Point(887, 447);
            this.TraCuuButton.Name = "TraCuuButton";
            this.TraCuuButton.Size = new System.Drawing.Size(168, 26);
            this.TraCuuButton.TabIndex = 21;
            this.TraCuuButton.Text = "TRA CỨU";
            this.TraCuuButton.UseVisualStyleBackColor = true;
            this.TraCuuButton.Click += new System.EventHandler(this.TraCuuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 485);
            this.Controls.Add(this.TraCuuButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OutputTSV);
            this.Controls.Add(this.OutputLop);
            this.Controls.Add(this.OutputMSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.InputTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TenSvText);
            this.Controls.Add(this.LopSvText);
            this.Controls.Add(this.MsvText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuaButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.ThemButton);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MsvText;
        private System.Windows.Forms.TextBox LopSvText;
        private System.Windows.Forms.TextBox TenSvText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputTimKiem;
        private System.Windows.Forms.TextBox OutputTSV;
        private System.Windows.Forms.TextBox OutputLop;
        private System.Windows.Forms.TextBox OutputMSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TraCuuButton;
    }
}

