using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QLYDETAI
{
    public partial class frmEachGV : Form
    {
        private string magv;
        public frmEachGV(string mgv)
        {
            this.magv = mgv;
            InitializeComponent();
        }
        public frmEachGV()
        {
            this.InitializeComponent();
        }

        private void frmEachGV_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(magv))
            {
                this.Text = "Update teacher";
                var r = new Database().Select("selectMAGV '" + magv + "'");
                txtMAGV.Text = r["MAGV"].ToString();
                txtHOTEN.Text = r["HOTEN"].ToString();
                txtLUONG.Text = r["LUONG"].ToString();
                mtbNgsinh.Text = r["Ngày sinh"].ToString();
                if (r["PHAI"].ToString() == "Nam")
                {
                    checkNam.Checked = true;
                }
                else
                {
                    checkNu.Checked = true;
                }
                txtAddr.Text = r["DIACHI"].ToString();
                txtGVQLCM.Text = r["GVQLCM"].ToString();
                txtMABM.Text = r["MABM"].ToString();
            }
            else
            {
                this.Text = "Add new Teacher";
                deleteBtn.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string sql = "";
            string HOTEN = txtHOTEN.Text;
            string luong = txtLUONG.Text;
            DateTime ngsinh;
            try
            {
                ngsinh = DateTime.ParseExact(mtbNgsinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbNgsinh.Select();
                return;
            }
            string gioitinh = checkNam.Checked ? "Nam" : "Nữ";
            string diachi = txtAddr.Text;
            string gvqlcm = txtGVQLCM.Text;
            string mabm = txtMABM.Text;
            string magv_add = txtMAGV.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(magv))
            {
                sql = "AddNewGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaGV",
                    value = magv_add
                });

            }
            else
            {
                sql = "UpdateGV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaGV",
                    value = magv
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@HoTen",
                value = HOTEN
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Luong",
                value = luong
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NgSinh",
                value = ngsinh.ToString()
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@GVQLCM",
                value = gvqlcm
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MABM",
                value = mabm
            });
            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(magv))
                {
                    MessageBox.Show("Thêm mới giáo viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật giáo viên thành công");
                }
                this.Dispose();
            }
            else if (rs == 0)
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            string sql = "deleteGV";
            lstPara.Add(new CustomParameter()
            {
                key = "@MaGV",
                value = magv
            });
            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                MessageBox.Show("Xóa dữ liệu thành công");
                this.Dispose(true);
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }
    }
}
