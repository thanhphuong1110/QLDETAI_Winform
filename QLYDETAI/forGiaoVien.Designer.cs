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
            dgvGiaoVien.Location = new Point(0, 85);
            dgvGiaoVien.MultiSelect = false;
            dgvGiaoVien.Name = "dgvGiaoVien";
            dgvGiaoVien.ReadOnly = true;
            dgvGiaoVien.RowTemplate.Height = 25;
            dgvGiaoVien.Size = new Size(1121, 564);
            dgvGiaoVien.TabIndex = 0;
            dgvGiaoVien.CellDoubleClick += dgvGiaoVien_CellDoubleClick;
            // 
            // keyText
            // 
            keyText.AutoSize = true;
            keyText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyText.Location = new Point(723, 39);
            keyText.Name = "keyText";
            keyText.Size = new Size(43, 21);
            keyText.TabIndex = 1;
            keyText.Text = "KEY:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(772, 39);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(159, 23);
            txtInput.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.AutoSize = true;
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(937, 34);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(67, 31);
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
            addButton.Location = new Point(1010, 34);
            addButton.Name = "addButton";
            addButton.Size = new Size(81, 31);
            addButton.TabIndex = 4;
            addButton.Text = "Add new";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font(".VnArial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(391, 45);
            label1.TabIndex = 5;
            label1.Text = "Teacher Management";
            label1.Click += label1_Click;
            // 
            // forGiaoVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 649);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(searchButton);
            Controls.Add(txtInput);
            Controls.Add(keyText);
            Controls.Add(dgvGiaoVien);
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
    }
}