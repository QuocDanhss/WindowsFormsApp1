using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.patient_form;
using static System.Windows.Forms.Form;

namespace WindowsFormsApp1.Properties
{
    public class Patient_program
    { 
        
        public  string filepath;
        public void  find_file(string ID)
        {
            string link = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\patient\\";
            filepath = link + ID;
            
            
        }
        
    }
    public class Loadbill :Patient_program
    {
        public string ID_bill { get; set; }
        public string de { get; set; }
        public string amount { get; set; }
        public string paid { get; set; }
        public string date {  get; set; }

       
        public void  load_bill() 
        {   
            
            string b ="D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\patient\\00001\\List_Bill.csv";
            
            
            
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8, // File của ta dùng encoding UTF-8.
                Delimiter = "," // Ký tự phân cách giữa các trường là dấu phẩy.
            };
            using (var fs = File.Open(b, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    var data = csv.GetRecords<Loadbill>();

                    foreach (var loadbill in data)
                    {
                        MessageBox.Show(loadbill.ID_bill);
                       
                    }


                }
            }
            
        }
    }
}
