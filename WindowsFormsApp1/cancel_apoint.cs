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
using System.Windows.Forms.VisualStyles;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using WindowsFormsApp1.Properties;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.LinkLabel;


namespace WindowsFormsApp1
{

    public partial class cancel_apoint : Form
    {   string Get_ID;
        string get_name;
        public cancel_apoint(string ID2)
        {
            Get_ID = ID2;
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            confirm_form customMessageBox = new confirm_form("You want cancel apoint");
            DialogResult result = customMessageBox.ShowDialog();

            get_name = IDTB.Text;
            if (result == DialogResult.OK )
            {
                delete();
                del_in_list();
                
                this.Close();
            }
        }
        public void delete()
        {
            
            string filePath = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\apoint\\" + get_name + ".txt";
            
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("complete");
                }
                else
                {
                    MessageBox.Show("not find apoint, Pls import ID apoint after one minute");
                }
            }
            catch
            {
                MessageBox.Show("Error. please wait some minute befor try agian");
            }

        }
        

        public void del_in_list()
        {
            
            string list_path = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\patient\\" + Get_ID + "\\Apoint.csv";

            string[] lines = File.ReadAllLines(list_path);

             

            List<string> linesToWrite = new List<string>();
            
            
            foreach (string s in lines)
            {
                // GHI LÊN CHUỖI KHÁC 
                linesToWrite.Add(s);
                String[] split = s.Split(',');// CHỖ NÀY HƠI CHUỐI VÌ TÁCH THEO KÍ TỰ ĐẦU
                foreach (String line in split)// CHO CHẠY TRONG MẢNG PHỤ THOI 
                {
                    
                    
                    if (line.Contains(get_name)) // TRÙNG THÌ CÚT NÈ
                    {
                        linesToWrite.Remove(s);
                       
                        break;
                    }
                }
            }
            File.WriteAllLines(list_path, linesToWrite);







        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
   }
