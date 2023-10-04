using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static WindowsFormsApp1.Forgotform;
using static WindowsFormsApp1.Person;

namespace WindowsFormsApp1
{
    
    
    public partial class Form1 : Form
        
    {

        public Form1()
        {
            InitializeComponent();
        }
               
        private void loginbtn_Click(object sender, EventArgs e)
        {
            Person a = new Person();
            string ID = Textb_ID.Text;
            
            if (ID== "import your ID"|| ID=="")
            {
                MessageBox.Show("Import your ID again pls!!!");
            }
            
            string password = textBox2.Text;
            if (a.login(ID, password))
            {

                
                char lastchar = ID[4];
                loaddata(lastchar,ID);
            }
            else
                MessageBox.Show("ID or password fall");
          }

        private void forgot_Click(object sender, EventArgs e)
        {   
            
            string ID = Textb_ID.Text;
            
            if (ID == "import your ID" || ID=="")
            {
                MessageBox.Show("Import your ID again pl!!!");
            }
            else
            {

                Forgotform Form2 = new Forgotform();
                this.Hide();

                Form2.ShowDialog();
                this.Close();
                
            }
           
            //patient_form Form3= new patient_form();
            //Form3.ShowDialog();


        }
       public void loaddata(char lastID,string ID)
        {
            if (lastID == '5')
            

                doctor(ID);

            
            else if (lastID == '0')
                manager(ID);
            else
                paitent(ID);
        }
        public void doctor(string ID)
        {
            MessageBox.Show("Cc");
        }
        public void paitent(string ID)
        {
            /*Patient_program patientProgram = new Patient_program();
            string filePath = patientProgram.find_file(ID); // Lấy đường dẫn từ lớp cha */

            //Loadbill loadbill = new Loadbill(); // Truyền đường dẫn vào lớp con
            //loadbill.load_bill();


            
            
            patient_form a= new patient_form(ID);
            this.Hide();
            a.load_data1(ID);
            a.ShowDialog();
        }
        public void manager(string ID)
        {
            
        }

        private void Textb_ID_Enter(object sender, EventArgs e)
        {
            if(Textb_ID.Text == "import your ID")
            Textb_ID.Text = "";

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (Textb_ID.Text == "import your password")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
        }

        private void Textb_ID_Leave(object sender, EventArgs e)
        {
            if (Textb_ID.Text == "")
                Textb_ID.Text = "import your ID";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = "import your password";
        }
    }

    
}
    

