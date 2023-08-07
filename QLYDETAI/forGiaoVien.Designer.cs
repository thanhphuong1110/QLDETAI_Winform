namespace QLYDETAI
{
    partial class forGiaoVien
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
            dgvGiaoVien = new DataGridView();
            keyText = new Label();
            txtInput = new TextBox();
            searchButton = new Button();
            addButton = new Button();
            label1 = new Label();
            bomonBtn = new Button();
            khoaBtn = new Button();
            detaiBtn = new Button();
            giaovienBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).BeginInit();
            SuspendLayout();
            // 
            // dgvGiaoVien
            // 
            dgvGiaoVien.AllowUserToAddRows = false;
            dgvGiaoVien.AllowUserToDeleteRows = false;
            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoVien.Dock = DockStyle.Bottom;
            dgvGiaoVien.Location = new Point(0, 113);
            dgvGiaoVien.Margin = new Padding(3, 4, 3, 4);
            dgvGiaoVien.MultiSelect = false;
            dgvGiaoVien.Name = "dgvGiaoVien";
            dgvGiaoVien.ReadOnly = true;
            dgvGiaoVien.RowHeadersWidth = 51;
            dgvGiaoVien.RowTemplate.Height = 25;
            dgvGiaoVien.Size = new Size(1281, 752);
            dgvGiaoVien.TabIndex = 0;
            dgvGiaoVien.CellDoubleClick += dgvGiaoVien_CellDoubleClick;
            // 
            // keyText
            // 
            keyText.AutoSize = true;
            keyText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyText.Location = new Point(826, 52);
            keyText.Name = "keyText";
            keyText.Size = new Size(53, 28);
            keyText.TabIndex = 1;
            keyText.Text = "KEY:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(882, 52);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(181, 27);
            txtInput.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.AutoSize = true;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(1071, 45);
            searchButton.Margin = new Padding(3, 4, 3, 4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(80, 41);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            searchButton.Enter += searchButton_Enter;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(1154, 45);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(99, 41);
            addButton.TabIndex = 4;
            addButton.Text = "Add new";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font(".VnArial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(447, 60);
            label1.TabIndex = 5;
            label1.Text = "Teacher Management";
            label1.Click += label1_Click;
            // 
            // bomonBtn
            // 
            bomonBtn.Location = new Point(94, 86);
            bomonBtn.Name = "bomonBtn";
            bomonBtn.Size = new Size(94, 29);
            bomonBtn.TabIndex = 6;
            bomonBtn.Text = "Bộ môn";
            bomonBtn.UseVisualStyleBackColor = true;
            bomonBtn.Click += bomonBtn_Click;
            // 
            // khoaBtn
            // 
            khoaBtn.Location = new Point(188, 86);
            khoaBtn.Name = "khoaBtn";
            khoaBtn.Size = new Size(94, 29);
            khoaBtn.TabIndex = 7;
            khoaBtn.Text = "Khoa";
            khoaBtn.UseVisualStyleBackColor = true;
            khoaBtn.Click += khoaBtn_Click;
            // 
            // detaiBtn
            // 
            detaiBtn.Location = new Point(282, 86);
            detaiBtn.Name = "detaiBtn";
            detaiBtn.Size = new Size(94, 29);
            detaiBtn.TabIndex = 8;
            detaiBtn.Text = "Đề tài";
            detaiBtn.UseVisualStyleBackColor = true;
            detaiBtn.Click += detaiBtn_Click;
            // 
            // giaovienBtn
            // 
            giaovienBtn.Location = new Point(0, 86);
            giaovienBtn.Name = "giaovienBtn";
            giaovienBtn.Size = new Size(94, 29);
            giaovienBtn.TabIndex = 9;
            giaovienBtn.Text = "Giáo viên";
            giaovienBtn.UseVisualStyleBackColor = true;
            giaovienBtn.Click += giaovienBtn_Click;
            // 
            // forGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 865);
            Controls.Add(giaovienBtn);
            Controls.Add(detaiBtn);
            Controls.Add(khoaBtn);
            Controls.Add(bomonBtn);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(searchButton);
            Controls.Add(txtInput);
            Controls.Add(keyText);
            Controls.Add(dgvGiaoVien);
            Margin = new Padding(3, 4, 3, 4);
            Name = "forGiaoVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách giáo viên";
            Load += forGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGiaoVien;
        private Label keyText;
        private TextBox txtInput;
        private Button searchButton;
        private Button addButton;
        private Label label1;
        private Button bomonBtn;
        private Button khoaBtn;
        private Button detaiBtn;
        private Button giaovienBtn;
    }
}