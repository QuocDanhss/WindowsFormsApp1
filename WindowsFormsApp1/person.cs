using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public class Person
    {
        public string Username { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public bool login(string ID, string Pass)
        {


            // Đường dẫn tới tệp CSV
             
            string filePath = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\ID_password\\table_user.csv";
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8, // File của ta dùng encoding UTF-8.
                Delimiter = "," // Ký tự phân cách giữa các trường là dấu phẩy.
            };
            using (var fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    var data = csv.GetRecords<Person>();
                    
                    foreach (var person in data)
                    { if (ID == person.UserID && Pass == person.Password)
                                return true;
                            else
                                continue;
                    }
                        
                    
                }
            }
            return false;
            
        }
        public bool forgot(string ID,string email , string phone , string newpass, string npass_cf)
        {
            string filePath = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\ID_password\\table_user.csv";
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Encoding = Encoding.UTF8, // File của ta dùng encoding UTF-8.
                Delimiter = "," // Ký tự phân cách giữa các trường là dấu phẩy.
            };
            using (var fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    var data = csv.GetRecords<Person>();

                    foreach (var person in data)
                    {
                        if (ID == person.UserID && email== person.Email)
                        {
                            if (phone == person.Phone)
                            {

                            }
                                if (newpass == npass_cf)
                                {
                                using (var writer = new StreamWriter(filePath))
                                using (var h = new CsvWriter(writer, CultureInfo.InvariantCulture))
                                {
                                    h.WriteRecordsAsync(person.Password);
                                }
                                
                                    return true;
                                }
                               
                        }
                            
                        
                            
                        else
                            continue;
                    }


                }
            }
            return false;

        }
    }
}
