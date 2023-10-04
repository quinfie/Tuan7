using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_Email.Text, s;
                if (txt_Name.Text != "" && txt_Email.Text != "" )
                {
                    if (IsValidEmail(email) == false)
                    {
                        MessageBox.Show("Email không hợp lệ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else
                    //{
                    //    if (txt_Password.Text != txt_rePassword.Text)
                    //    {
                    //        MessageBox.Show("Password không hợp lệ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //    else
                    //    {

                    //        MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                    //    }
                    //}

                }
                else
                {
                    MessageBox.Show("Vui lòng không được để trống!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
    }
}
