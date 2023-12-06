using QL_NhanVien.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhanVien.Views
{
    public partial class MainPage : Form
    {
        NhanVienService _service = new NhanVienService();
        int selectedID = -1;
        public MainPage()
        {
            _service = new NhanVienService();
            InitializeComponent();
        }

        public void LoadData(dynamic data)
        {
            dtgNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int stt = 1;
            dtgNhanVien.ColumnCount = 7;
            dtgNhanVien.Columns[0].Name = "STT";
            dtgNhanVien.Columns[0].HeaderText = "STT";
            dtgNhanVien.Columns[1].Name = "name";
            dtgNhanVien.Columns[1].HeaderText = "Họ Tên";
            dtgNhanVien.Columns[2].Name = "address";
            dtgNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dtgNhanVien.Columns[3].Name = "email";
            dtgNhanVien.Columns[3].HeaderText = "Email";
            dtgNhanVien.Columns[4].Name = "sdt";
            dtgNhanVien.Columns[4].HeaderText = "Số Điện Thoại";
            dtgNhanVien.Columns[5].Name = "role";
            dtgNhanVien.Columns[5].HeaderText = "Chức Vụ";
            dtgNhanVien.Columns[6].Name = "ID";
            dtgNhanVien.Columns[6].Visible = false;

            dtgNhanVien.Rows.Clear();

            foreach (var item in data)
            {
                dtgNhanVien.Rows.Add(stt++, item.Ten, item.Diachi, item.Sodienthoai, item.Email, item.Chucvu, item.Id);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon them khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string name = txtName.Text;
                string address = txtAddress.Text;
                string sdt = txtSDT.Text;
                string email = txtEmail.Text;
                string chucVu = txtChucVu.Text;
                bool add = _service.AddNhanVien(name, address, sdt, email, chucVu);
                if (add)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
                LoadData(_service.GetAllNhanVien());
            }
            else
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(_service.GetNhanVienByName(txtSearch.Text));
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData(_service.GetAllNhanVien());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(_service.GetNhanVienByName(txtSearch.Text));
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectedObj = dtgNhanVien.Rows[index];
            txtName.Text = selectedObj.Cells[1].Value.ToString();
            txtAddress.Text = selectedObj.Cells[2].Value.ToString();
            txtEmail.Text = selectedObj.Cells[4].Value.ToString();
            txtSDT.Text = selectedObj.Cells[3].Value.ToString();
            txtChucVu.Text = selectedObj.Cells[5].Value.ToString();
            selectedID = Convert.ToInt32(selectedObj.Cells[6].Value);
        }

        private void dtgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectedObj = dtgNhanVien.Rows[index];
            txtName.Text = selectedObj.Cells[1].Value.ToString();
            txtAddress.Text = selectedObj.Cells[2].Value.ToString();
            txtEmail.Text = selectedObj.Cells[4].Value.ToString();
            txtSDT.Text = selectedObj.Cells[3].Value.ToString();
            txtChucVu.Text = selectedObj.Cells[5].Value.ToString();
            selectedID = Convert.ToInt32(selectedObj.Cells[6].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon sua thong tin ko?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string name = txtName.Text;
                string address = txtAddress.Text;
                string sdt = txtSDT.Text;
                string email = txtEmail.Text;
                string chucVu = txtChucVu.Text;
                bool update = _service.UpdateNhanVien(selectedID, name, address, sdt, email, chucVu);
                if (update)
                {
                    MessageBox.Show("Sua thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua that bai");
                }
                LoadData(_service.GetAllNhanVien());
            }
            else
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var deleteResult = _service.DeleteNhanVien(selectedID);
                if (deleteResult)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                }
                LoadData(_service.GetAllNhanVien());
            }
            else
            {
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtChucVu.Text = "";
        }
    }
}
