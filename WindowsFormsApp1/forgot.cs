using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Person;

namespace WindowsFormsApp1
{
    public partial class Forgotform : Form
    {
        public Forgotform()
        {
            InitializeComponent();
        }
        
        private void Cofirmbtn_Click(object sender, EventArgs e)
        {
            string Get_ID = Textb_ID.Text;
            string Get_email = TextB_email.Text;
            string Get_phone = TextB_phone.Text;
            string Get_newpass =  TextB_npass.Text;
            string Get_cofirm= TextB_confim.Text;
            if(Get_cofirm != Get_newpass)
            {
                MessageBox.Show("newpass not same confirm pass");
            }
            Person a = new Person();
            if (a.forgot(Get_ID, Get_email, Get_phone, Get_newpass, Get_cofirm))
            {
                MessageBox.Show("cc");

            }
            else
                MessageBox.Show("ddsa");
                
        }
        public bool search_ID(int ID)
        {
            return true;
        }
        public bool check_email(string email)
        {
            return true;
        }
        public bool check_phone(string phone)
        {
            return true;
        }

        private void TextB_npass_Enter(object sender, EventArgs e)
        {
            if (TextB_npass.Text== "import your new password")
            {
                TextB_npass.Text = "";
            }
        }

        private void TextB_confim_Enter(object sender, EventArgs e)
        {
            if (TextB_confim.Text == "import your new password")
            {
                TextB_confim.Text = "";
                TextB_confim.PasswordChar= '*'; 
            }
                
                
        }

        private void Textb_ID_Enter(object sender, EventArgs e)
        {
            if (Textb_ID.Text == "import your ID")
            {
                Textb_ID.Text = "";
                
            }
        }

        private void TextB_phone_Enter(object sender, EventArgs e)
        {   
            if(TextB_phone.Text=="import your number phone")
            TextB_phone.Text = "";
        }

        private void TextB_email_Enter(object sender, EventArgs e)
        {
            if (TextB_email.Text == "import your Email")
                TextB_email.Text = "";
        }
    }

}
