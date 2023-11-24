using QLNhanVien.Controller;

namespace QLNhanVien
{
    public partial class Form1 : Form
    {
        NhanVienService _service = new NhanVienService();
        int selectedID = -1;
        public Form1()
        {
            _service = new NhanVienService();
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData(_service.GetAllNhanVien());
        }

        public void LoadData(dynamic data)
        {
            dtgNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int stt = 1;
            dtgNhanVien.ColumnCount = 8;
            dtgNhanVien.Columns[0].Name = "STT";
            dtgNhanVien.Columns[0].HeaderText = "STT";
            dtgNhanVien.Columns[1].Name = "name";
            dtgNhanVien.Columns[1].HeaderText = "Ho Ten";
            dtgNhanVien.Columns[2].Name = "namSinh";
            dtgNhanVien.Columns[2].HeaderText = "Nam Sinh";
            dtgNhanVien.Columns[3].Name = "gender";
            dtgNhanVien.Columns[3].HeaderText = "Gioi Tinh";
            dtgNhanVien.Columns[4].Name = "email";
            dtgNhanVien.Columns[4].HeaderText = "Email";
            dtgNhanVien.Columns[5].Name = "sdt";
            dtgNhanVien.Columns[5].HeaderText = "So Dien Thoai";
            dtgNhanVien.Columns[6].Name = "role";
            dtgNhanVien.Columns[6].HeaderText = "Chuc Vu";
            dtgNhanVien.Columns[7].Name = "ID";
            dtgNhanVien.Columns[7].Visible = false;

            dtgNhanVien.Rows.Clear();

            foreach (var item in data)
            {
                dtgNhanVien.Rows.Add(stt++, item.Hoten, item.Namsinh, item.Gioitinh? "Nu" : "Nam", item.Email, item.Sdt, item.Chucvu, item.IdnhanVien);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(_service.GetNhanVienByName(txtSearch.Text));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(_service.GetNhanVienByName(txtSearch.Text));
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectedObj = dtgNhanVien.Rows[index];
            txtName.Text = selectedObj.Cells[1].Value.ToString();
            txtEmail.Text = selectedObj.Cells[4].Value.ToString();
            txtYear.Text = selectedObj.Cells[2].Value.ToString();
            txtSDT.Text = selectedObj.Cells[5].Value.ToString();
            txtRole.Text = selectedObj.Cells[6].Value.ToString();
            string gender = selectedObj.Cells[3].Value.ToString();
            if (gender.Equals("Nam"))
            {
                cbNam.Checked = true;
                cbNu.Checked = false;
            }
            else
            {
                cbNam.Checked = false;
                cbNu.Checked = true;
            }
            selectedID = Convert.ToInt32(selectedObj.Cells[7].Value);

        }

        private void dtgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectedObj = dtgNhanVien.Rows[index];
            txtName.Text = selectedObj.Cells[1].Value.ToString();
            txtEmail.Text = selectedObj.Cells[4].Value.ToString();
            txtYear.Text = selectedObj.Cells[2].Value.ToString();
            txtSDT.Text = selectedObj.Cells[5].Value.ToString();
            txtRole.Text = selectedObj.Cells[6].Value.ToString();
            string gender = selectedObj.Cells[3].Value.ToString();
            if (gender.Equals("Nam"))
            {
                cbNam.Checked = true;
                cbNu.Checked = false;
            }
            else
            {
                cbNam.Checked = false;
                cbNu.Checked = true;
            }
            selectedID = Convert.ToInt32(selectedObj.Cells[7].Value);
        }

    }
}