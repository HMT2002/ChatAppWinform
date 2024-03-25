using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            modeLogin();
        }
        public bool isLogin;
        public void modeRegister()
        {
            clear();
            txtRePassword.Visible = true;
            label3.Visible = true;

            isLogin = false;
            lblForm.Text = "Đăng ký";
            btnConfirm.Text = "Đăng ký";
        }
        public void modeLogin()
        {
            clear();
            txtRePassword.Visible = false;
            label3.Visible = false;
            isLogin = true;
            lblForm.Text = "Đăng nhập";
            btnConfirm.Text = "Đăng nhập";
        }

        public void clear()
        {
            txtPassword.Text = string.Empty;
            txtRePassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void checkRegisted_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRegisted.Checked)
            {
                modeRegister();
            }
            else
            {
                modeLogin();

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                LoginFunc(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                RegisterFunc(txtUsername.Text, txtPassword.Text, txtRePassword.Text);
            }
        }

        public void LoginFunc(string username, string password)
        {
            ChatUser user = ChatUser.GetAll().Where(usr => usr.Name.CompareTo(username) == 0).FirstOrDefault();
            if (user != null)
            {
                if (password.CompareTo(user.Password) == 0)
                {
                    this.Hide();
                    Form1 form = new Form1(user);
                    form.Show();
                    form.Closed += (s, args) => this.Close();
                    return;
                }

            }
            lblNoti.Text = "Không tìm thấy người dùng hoặc sai mật khẩu";

        }
        public void RegisterFunc(string username, string password, string repassword)
        {

        }
    }
}
