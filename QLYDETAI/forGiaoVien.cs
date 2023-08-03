using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYDETAI
{
    public partial class forGiaoVien : Form
    {
        public forGiaoVien()
        {
            InitializeComponent();
        }
        private string key = "";
        private void forGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDSGV();
        }
        private void LoadDSGV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@key",
                value = key
            });
            dgvGiaoVien.DataSource = new Database().SelectData("SelectAllGiaoVien", lstPara);
            dgvGiaoVien.Columns["MAGV"].HeaderText = "Mã giáo viên";
            dgvGiaoVien.Columns["HOTEN"].HeaderText = "Họ và tên";
            dgvGiaoVien.Columns["LUONG"].HeaderText = "Lương";
            dgvGiaoVien.Columns["PHAI"].HeaderText = "Giới tính";
            dgvGiaoVien.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgvGiaoVien.Columns["MABM"].HeaderText = "Mã bộ môn";
        }
        private void dgvGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvGiaoVien.Rows[e.RowIndex].Cells["MAGV"].Value.ToString();
                new frmEachGV(mgv).ShowDialog();
                LoadDSGV();
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            key = txtInput.Text;
            LoadDSGV();
        }

        private void searchButton_Enter(object sender, EventArgs e)
        {
            key = txtInput.Text;
            LoadDSGV();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new frmEachGV().ShowDialog();
            LoadDSGV();
        }
    }
}
