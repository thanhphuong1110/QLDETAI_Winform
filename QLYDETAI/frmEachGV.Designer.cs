namespace QLYDETAI
{
    partial class frmEachGV
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
            label1 = new Label();
            txtMAGV = new TextBox();
            label2 = new Label();
            txtHOTEN = new TextBox();
            label3 = new Label();
            txtLUONG = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtAddr = new TextBox();
            label6 = new Label();
            txtGVQLCM = new TextBox();
            label7 = new Label();
            checkNu = new CheckBox();
            checkNam = new CheckBox();
            txtMABM = new TextBox();
            label8 = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            mtbNgsinh = new MaskedTextBox();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã giáo viên";
            // 
            // txtMAGV
            // 
            txtMAGV.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMAGV.Location = new Point(113, 39);
            txtMAGV.Name = "txtMAGV";
            txtMAGV.Size = new Size(159, 27);
            txtMAGV.TabIndex = 1;
            txtMAGV.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày sinh";
            // 
            // txtHOTEN
            // 
            txtHOTEN.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtHOTEN.Location = new Point(113, 72);
            txtHOTEN.Name = "txtHOTEN";
            txtHOTEN.Size = new Size(159, 27);
            txtHOTEN.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Họ tên";
            // 
            // txtLUONG
            // 
            txtLUONG.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtLUONG.Location = new Point(113, 105);
            txtLUONG.Name = "txtLUONG";
            txtLUONG.Size = new Size(159, 27);
            txtLUONG.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 108);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "Lương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 141);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "Giới tính";
            // 
            // txtAddr
            // 
            txtAddr.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddr.Location = new Point(113, 204);
            txtAddr.Name = "txtAddr";
            txtAddr.Size = new Size(159, 27);
            txtAddr.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 207);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 10;
            label6.Text = "Địa chỉ";
            // 
            // txtGVQLCM
            // 
            txtGVQLCM.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtGVQLCM.Location = new Point(113, 237);
            txtGVQLCM.Name = "txtGVQLCM";
            txtGVQLCM.Size = new Size(159, 27);
            txtGVQLCM.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 240);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 12;
            label7.Text = "GVQLCM";
            // 
            // checkNu
            // 
            checkNu.AutoSize = true;
            checkNu.Location = new Point(113, 141);
            checkNu.Name = "checkNu";
            checkNu.Size = new Size(42, 19);
            checkNu.TabIndex = 4;
            checkNu.Text = "Nữ";
            checkNu.UseVisualStyleBackColor = true;
            // 
            // checkNam
            // 
            checkNam.AutoSize = true;
            checkNam.Location = new Point(202, 141);
            checkNam.Name = "checkNam";
            checkNam.Size = new Size(52, 19);
            checkNam.TabIndex = 5;
            checkNam.Text = "Nam";
            checkNam.UseVisualStyleBackColor = true;
            // 
            // txtMABM
            // 
            txtMABM.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMABM.Location = new Point(113, 270);
            txtMABM.Name = "txtMABM";
            txtMABM.Size = new Size(159, 27);
            txtMABM.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 273);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 16;
            label8.Text = "Mã bộ môn";
            // 
            // saveBtn
            // 
            saveBtn.AutoSize = true;
            saveBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Location = new Point(48, 321);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 30);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.AutoSize = true;
            cancelBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.Location = new Point(179, 321);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 30);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // mtbNgsinh
            // 
            mtbNgsinh.Location = new Point(113, 171);
            mtbNgsinh.Mask = "00/00/0000";
            mtbNgsinh.Name = "mtbNgsinh";
            mtbNgsinh.Size = new Size(141, 23);
            mtbNgsinh.TabIndex = 6;
            mtbNgsinh.ValidatingType = typeof(DateTime);
            // 
            // deleteBtn
            // 
            deleteBtn.AutoSize = true;
            deleteBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.Location = new Point(297, 321);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 30);
            deleteBtn.TabIndex = 17;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // frmEachGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 388);
            Controls.Add(deleteBtn);
            Controls.Add(mtbNgsinh);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(txtMABM);
            Controls.Add(label8);
            Controls.Add(checkNam);
            Controls.Add(checkNu);
            Controls.Add(txtGVQLCM);
            Controls.Add(label7);
            Controls.Add(txtAddr);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLUONG);
            Controls.Add(label4);
            Controls.Add(txtHOTEN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMAGV);
            Controls.Add(label1);
            Name = "frmEachGV";
            Load += frmEachGV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMAGV;
        private Label label2;
        private TextBox txtHOTEN;
        private Label label3;
        private TextBox txtLUONG;
        private Label label4;
        private Label label5;
        private TextBox txtAddr;
        private Label label6;
        private TextBox txtGVQLCM;
        private Label label7;
        private CheckBox checkNu;
        private CheckBox checkNam;
        private TextBox txtMABM;
        private Label label8;
        private Button saveBtn;
        private Button cancelBtn;
        private MaskedTextBox mtbNgsinh;
        private Button deleteBtn;
    }
}