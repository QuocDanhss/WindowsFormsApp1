using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class confirm_form : Form
    {
        string content2;
        public confirm_form(string content)
        {
            content2 = content;
            InitializeComponent();
        }
        
        
        
        private void cofirm_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void confirm_form_Load(object sender, EventArgs e)
        {
            nofication.Text= content2;
        }
    }
}
