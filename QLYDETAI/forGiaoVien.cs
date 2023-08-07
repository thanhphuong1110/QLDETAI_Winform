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
        private bool bomonClicked = false;
        private bool giaovienClicked = false;
        private bool khoaClicked = false;
        private bool detaiClicked = false;
        private void forGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDSGV();
            giaovienClicked = true;
            giaovienBtn.Enabled = false;
        }
        private void LoadDSGV_after()
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
            dgvGiaoVien.Columns["GVQLCM"].HeaderText = "GVQLCM";
            dgvGiaoVien.Columns["MABM"].HeaderText = "Mã bộ môn";
            dgvGiaoVien.Columns["MAGV"].DisplayIndex = 0;
            dgvGiaoVien.Columns["HOTEN"].DisplayIndex = 1;
            dgvGiaoVien.Columns["LUONG"].DisplayIndex = 2;
            dgvGiaoVien.Columns["PHAI"].DisplayIndex = 3;
            dgvGiaoVien.Columns["Ngày sinh"].DisplayIndex = 4;
            dgvGiaoVien.Columns["DIACHI"].DisplayIndex = 5;
            dgvGiaoVien.Columns["GVQLCM"].DisplayIndex = 6;
            dgvGiaoVien.Columns["MABM"].DisplayIndex = 7;
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
            dgvGiaoVien.Columns["GVQLCM"].HeaderText = "GVQLCM";
            dgvGiaoVien.Columns["MABM"].HeaderText = "Mã bộ môn";
        }
        private void dgvGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bomonClicked == false && khoaClicked == false && detaiClicked == false && giaovienClicked == true) {
                if (e.RowIndex >= 0)
                {
                    var mgv = dgvGiaoVien.Rows[e.RowIndex].Cells["MAGV"].Value.ToString();
                    new frmEachGV(mgv).ShowDialog();
                    LoadDSGV();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            key = txtInput.Text;
            if (bomonClicked == true)
                LoadBM();
            else if (giaovienClicked == true) LoadDSGV();
        }

        private void searchButton_Enter(object sender, EventArgs e)
        {
            key = txtInput.Text;
            if (bomonClicked == true)
            {
                LoadBM();
            }
            else if (giaovienClicked == true)
            {
                LoadDSGV();
                
            }
            else if (khoaClicked == true)
            {
                LoadKhoa();
                
            } else if (detaiClicked == true)
            {
                LoadDeTai();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new frmEachGV().ShowDialog();
            LoadDSGV();
        }
        private void LoadBM()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@key",
                value = key
            });
            dgvGiaoVien.DataSource = new Database().SelectData("SelectAllBomon", lstPara);
            dgvGiaoVien.Columns["MABM"].HeaderText = "Mã bộ môn";
            dgvGiaoVien.Columns["TENBM"].HeaderText = "Tên bộ môn";
            dgvGiaoVien.Columns["PHONG"].HeaderText = "Phòng";
            dgvGiaoVien.Columns["DIENTHOAI"].HeaderText = "Điện thoại";
            dgvGiaoVien.Columns["TRUONGBM"].HeaderText = "Trưởng bộ môn";
            dgvGiaoVien.Columns["MAKHOA"].HeaderText = "Mã khoa";
            dgvGiaoVien.Columns["MABM"].DisplayIndex = 0;
            dgvGiaoVien.Columns["TENBM"].DisplayIndex = 1;
            dgvGiaoVien.Columns["PHONG"].DisplayIndex = 2;
            dgvGiaoVien.Columns["DIENTHOAI"].DisplayIndex = 3;
            dgvGiaoVien.Columns["TRUONGBM"].DisplayIndex = 4;
            dgvGiaoVien.Columns["MAKHOA"].DisplayIndex = 5;
            dgvGiaoVien.Columns["Ngày nhận chức"].DisplayIndex = 6;
        }
        private void LoadKhoa()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@key",
                value = key
            });
            dgvGiaoVien.DataSource = new Database().SelectData("SelectAllKhoa", lstPara);
            dgvGiaoVien.Columns["MAKHOA"].HeaderText = "Mã khoa";
            dgvGiaoVien.Columns["TENKHOA"].HeaderText = "Tên khoa";
            dgvGiaoVien.Columns["NAMTL"].HeaderText = "Năm TL";
            dgvGiaoVien.Columns["PHONG"].HeaderText = "Phòng";
            dgvGiaoVien.Columns["DIENTHOAI"].HeaderText = "Điện thoại";
            dgvGiaoVien.Columns["TRUONGKHOA"].HeaderText = "Trưởng khoa";
        }
        private void LoadDeTai()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@key",
                value = key
            });
            dgvGiaoVien.DataSource = new Database().SelectData("SelectAllDeTai", lstPara);
            dgvGiaoVien.Columns["MADT"].HeaderText = "Mã đề tài";
            dgvGiaoVien.Columns["TENDT"].HeaderText = "Tên đề tài";
            dgvGiaoVien.Columns["KINHPHI"].HeaderText = "Kinh phí";
            dgvGiaoVien.Columns["MACD"].HeaderText = "Mã chủ đề";
            dgvGiaoVien.Columns["GVCNDT"].HeaderText = "Giáo viên chủ nhiệm đề tài";
        }
        private void bomonBtn_Click(object sender, EventArgs e)
        {
            LoadBM();
            bomonClicked = true;
            bomonBtn.Enabled = false;
            giaovienBtn.Enabled = true;
            khoaBtn.Enabled = true;
            giaovienClicked = false;
            khoaClicked = false;
            detaiClicked = false;
        }

        private void giaovienBtn_Click(object sender, EventArgs e)
        {
            LoadDSGV_after();
            giaovienClicked = true;
            giaovienBtn.Enabled = false;
            bomonBtn.Enabled = true;
            khoaBtn.Enabled = true;
            bomonClicked = false;
            khoaClicked = false;
            detaiClicked = false;
        }

        private void khoaBtn_Click(object sender, EventArgs e)
        {
            LoadKhoa();
            khoaClicked = true;
            giaovienBtn.Enabled = true;
            bomonBtn.Enabled = true;
            khoaBtn.Enabled = false;
            detaiBtn.Enabled = true;
            bomonClicked = false;
            giaovienClicked = false;
            detaiClicked = false;
        }

        private void detaiBtn_Click(object sender, EventArgs e)
        {
            LoadDeTai();
            detaiClicked = true;
            giaovienBtn.Enabled = true;
            bomonBtn.Enabled = true;
            khoaBtn.Enabled = true;
            detaiBtn.Enabled = false;
            bomonClicked = false;
            giaovienClicked = false;
            khoaClicked = false;
        }
    }
}
