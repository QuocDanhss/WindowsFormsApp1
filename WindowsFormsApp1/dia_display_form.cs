using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class dia_form : Form
    {
        string get_id;
        public dia_form(string ID_dia)
        {
             get_id = ID_dia;
            InitializeComponent();
        }

        private void dia_form_Load(object sender, EventArgs e)
        {
            string filePath1 = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\dia\\";

            string name_file = get_id + ".txt"; // Thay đổi đường dẫn đến tệp văn bản của bạn
            string filePath= string.Concat(filePath1, name_file);
            try
            {
                // Đảm bảo tệp tồn tại trước khi đọc
                if (File.Exists(filePath))
                {
                    // Đọc nội dung của tệp văn bản
                    string fileContent = File.ReadAllText(filePath);

                    // Hiển thị nội dung trong TextBox (textBox1 trong ví dụ này)
                    textBox1.Text = fileContent;
                }
                else
                {
                    MessageBox.Show("Tệp văn bản không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        
    }

}
