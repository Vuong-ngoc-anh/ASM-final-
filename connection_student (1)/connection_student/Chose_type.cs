using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connection_student
{
    public partial class Chose_type : Form
    {
        public Chose_type()
        {
            InitializeComponent();
        }

        private async void btFindquickly_Click(object sender, EventArgs e)
        {
            // Hiển thị spinner
            pictureS.Visible = true;

            // Giả lập quá trình tìm kiếm (2 giây)
            await Task.Run(() => Thread.Sleep(2000));
            pictureS.Visible = false;

            pictureS.Visible = false;
            Lear_Online form1 = new Lear_Online();
            form1.Show();
            this.Hide();
        }

        private async void btFind_doc_Click(object sender, EventArgs e)
        {
            // Hiển thị spinner
            pictureS.Visible = true;

            // Giả lập quá trình tìm kiếm (2 giây)
            await Task.Run(() => Thread.Sleep(2000));
            pictureS.Visible = false;
            Study_Materials form = new Study_Materials();
            form.Show();
            this.Hide();
        }
    }
}
