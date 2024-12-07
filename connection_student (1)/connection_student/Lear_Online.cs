using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connection_student
{
    public partial class Lear_Online : Form
    {
        public Lear_Online()
        {
            InitializeComponent();
        }


        private void btStop_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Do you want to stop calling?",
                "Error",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Hiển thị form khác
                Chose_type form = new Chose_type();
                form.Show();
                this.Hide();
            }
            else
            {
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            // Lấy nội dung tin nhắn từ txtInput
            string message = tbsend.Text.Trim();

            // Kiểm tra nếu tin nhắn không trống
            if (!string.IsNullOrEmpty(message))
            {
                // Hiển thị tin nhắn trong txtMessages
                tbchat.AppendText($"You: {message}{Environment.NewLine}");
                // Xóa nội dung trong txtInput
                tbsend.Clear();
            }
            else
            {
                // Hiển thị thông báo nếu không có nội dung
                MessageBox.Show("Please enter message content!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btRaisehands_Click(object sender, EventArgs e)
        {
            // Đảo trạng thái Visible của PictureBox
            hand.Visible = !hand.Visible;

            // Cập nhật text cho nút dựa trên trạng thái
            btRaisehands.Text = btRaisehands.Visible ? "Lower Hands" : "Raise Hands";
        }

    }
}
