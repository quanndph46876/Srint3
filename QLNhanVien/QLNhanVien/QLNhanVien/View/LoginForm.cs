using Microsoft.Data.SqlClient;
using QLNhanVien.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanVien.View
{
    public partial class LoginForm : Form
    {
        Form1 Form1 = new Form1();
        LoginService _service = new LoginService();
        
        public LoginForm()
        {
            _service = new LoginService();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Equals(_service.GetAllAcc().Select(n => n.Tendangnhap).FirstOrDefault()) && txtPassword.Text.Equals(_service.GetAllAcc().Select(n => n.Matkhau).FirstOrDefault()))
            {
                MessageBox.Show("Dang nhap thanh cong");
                
                Form1 = new Form1();
                Form1.ShowDialog();
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
