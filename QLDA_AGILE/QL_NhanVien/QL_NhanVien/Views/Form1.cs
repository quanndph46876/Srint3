using QL_NhanVien.Controllers;
using QL_NhanVien.Views;

namespace QL_NhanVien
{
    public partial class Form1 : Form
    {
        MainPage mainP = new MainPage();
        LoginService _service = new LoginService();
        public Form1()
        {
            _service = new LoginService();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Equals(_service.GetAllAcc().Select(n => n.Tendangnhap).FirstOrDefault()) && txtPassword.Text.Equals(_service.GetAllAcc().Select(n => n.Matkhau).FirstOrDefault()))
            {
                MessageBox.Show("Dang nhap thanh cong");

                mainP = new MainPage();
                mainP.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
                txtAccount.Text = "";
                txtPassword.Text = "";
                txtAccount.Focus();
            }
        }
    }
}