using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connection_student
{
    public partial class Study_Materials : Form
    {
        public Study_Materials()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Chose_type form2 = new Chose_type();
            form2.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Cấu hình ListView
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Thêm các cột
            listView1.Columns.Add("Name", 200);       // Tên sách
            listView1.Columns.Add("Book Genre", 150);// Loại sách
            listView1.Columns.Add("Level", 100);     // Mức độ
            listView1.Columns.Add("URL", 300);       // Link URL

            // Thêm dữ liệu mẫu
            AddSampleData();
        }
        private void AddSampleData()
        {
            ListViewItem item1 = new ListViewItem("English Grammar in Use");
            item1.SubItems.Add("Grammar");
            item1.SubItems.Add("Intermediate");
            item1.SubItems.Add("https://www.cambridge.org/grammarinuse");
            listView1.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Vocabulary in Use");
            item2.SubItems.Add("Vocabulary");
            item2.SubItems.Add("All Levels");
            item2.SubItems.Add("https://www.cambridge.org/vocabularyinuse");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Speak English Like an American");
            item3.SubItems.Add("Speaking");
            item3.SubItems.Add("Intermediate");
            item3.SubItems.Add("https://www.speaklikeamerican.com");
            listView1.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Active Listening");
            item4.SubItems.Add("Listening");
            item4.SubItems.Add("Beginner");
            item4.SubItems.Add("https://www.active-listening.com");
            listView1.Items.Add(item4);

            ListViewItem item5 = new ListViewItem("Cambridge IELTS Practice Tests");
            item5.SubItems.Add("Exam Preparation");
            item5.SubItems.Add("Advanced");
            item5.SubItems.Add("https://www.cambridge.org/ielts");
            listView1.Items.Add(item5);

            ListViewItem item6 = new ListViewItem("Essential TOEIC");
            item6.SubItems.Add("Exam Preparation");
            item6.SubItems.Add("Beginner");
            item6.SubItems.Add("https://www.essentialtoeic.com");
            listView1.Items.Add(item6);

            ListViewItem item7 = new ListViewItem("English Idioms in Use");
            item7.SubItems.Add("Vocabulary");
            item7.SubItems.Add("Advanced");
            item7.SubItems.Add("https://www.cambridge.org/idiomsinuse");
            listView1.Items.Add(item7);

            ListViewItem item11 = new ListViewItem("Oxford English Grammar Course");
            item11.SubItems.Add("Grammar");
            item11.SubItems.Add("All Levels");
            item11.SubItems.Add("https://www.oxfordlearnersdictionaries.com");
            listView1.Items.Add(item11);

            ListViewItem item12 = new ListViewItem("4000 Essential English Words");
            item12.SubItems.Add("Vocabulary");
            item12.SubItems.Add("All Levels");
            item12.SubItems.Add("https://www.4000words.com");
            listView1.Items.Add(item12);

            ListViewItem item13 = new ListViewItem("English Collocations in Use");
            item13.SubItems.Add("Vocabulary");
            item13.SubItems.Add("Intermediate");
            item13.SubItems.Add("https://www.cambridge.org/collocations");
            listView1.Items.Add(item13);

            ListViewItem item14 = new ListViewItem("American Accent Training");
            item14.SubItems.Add("Speaking");
            item14.SubItems.Add("All Levels");
            item14.SubItems.Add("https://www.amazon.com/american-accent");
            listView1.Items.Add(item14);

            ListViewItem item15 = new ListViewItem("English for Everyone");
            item15.SubItems.Add("General Learning");
            item15.SubItems.Add("Beginner");
            item15.SubItems.Add("https://www.dk.com/englishforeveryone");
            listView1.Items.Add(item15);

            ListViewItem item16 = new ListViewItem("Practical English Usage");
            item16.SubItems.Add("Grammar");
            item16.SubItems.Add("Intermediate");
            item16.SubItems.Add("https://www.oup.com/practicalenglishusage");
            listView1.Items.Add(item16);

            ListViewItem item17 = new ListViewItem("Cambridge English Pronunciation");
            item17.SubItems.Add("Pronunciation");
            item17.SubItems.Add("All Levels");
            item17.SubItems.Add("https://www.cambridge.org/pronunciation");
            listView1.Items.Add(item17);

            ListViewItem item8 = new ListViewItem("The Elements of Style");
            item8.SubItems.Add("Writing");
            item8.SubItems.Add("Advanced");
            item8.SubItems.Add("https://www.elementsofstyle.com");
            listView1.Items.Add(item8);

            ListViewItem item9 = new ListViewItem("Barron's TOEFL iBT");
            item9.SubItems.Add("Exam Preparation");
            item9.SubItems.Add("Advanced");
            item9.SubItems.Add("https://www.barronseduc.com/toefl");
            listView1.Items.Add(item9);

            ListViewItem item10 = new ListViewItem("Longman Academic Writing Series");
            item10.SubItems.Add("Writing");
            item10.SubItems.Add("Intermediate");
            item10.SubItems.Add("https://www.longmanwriting.com");
            listView1.Items.Add(item10);
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (listView1.SelectedItems.Count > 0)
            {
                // Lấy URL từ cột thứ 4
                string url = listView1.SelectedItems[0].SubItems[3].Text;

                // Kiểm tra nếu URL không rỗng
                if (!string.IsNullOrEmpty(url))
                {
                    try
                    {
                        // Mở liên kết trong trình duyệt mặc định
                        System.Diagnostics.Process.Start(new ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true // Đảm bảo sử dụng trình duyệt mặc định
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở liên kết: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("URL không hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để mở liên kết!");

            }
        }
    }
}
