using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Pay_form : Form
    {
        string Get_ID;

        public Pay_form(string ID)
        {
            InitializeComponent();
            Get_ID = ID;
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            confirm_form f1 = new confirm_form("Confirm this Pay");
            DialogResult result = f1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pay_bill();
                amount_TB.Text = Get_ID;
                
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void pay_bill()
        {
            string file_path = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\patient\\" + Get_ID + "\\List_bill.csv";
            List<contractor> data2;
            
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8, // File của ta dùng encoding UTF-8.
                Delimiter = "," // Ký tự phân cách giữa các trường là dấu phẩy.
            };
            using (var fs = File.Open(file_path, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                     data2 = csv.GetRecords<contractor>().ToList();
                }
                using (var writer = new StreamWriter(file_path))
                using (var csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    
                
                foreach (var a in data2)
                    {
                        try
                        {
                            if (ID_TB.Text == a.ID_bill && amount_TB.Text == a.amount)
                            {
                                a.paid = "complete";
                                csvWriter.WriteRecords(data2);
                                MessageBox.Show("Congratulations on a successful payment");
                                this.Close();
                                break;
                            }
                            else
                                continue;
                        }
                        catch  { MessageBox.Show("error. wait a munnite befor refesh"); }
                    }
                    

                }
                
            }
            
            
            
                
            



        }
        
               
            
    }
    public class contractor
    {
        
        public string ID_bill { get; set; }
        public string de { get; set; }
        public string amount { get; set; }
        public string paid { get; set; }
        public string date { get; set; }
    }
    }



