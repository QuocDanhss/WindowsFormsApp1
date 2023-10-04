using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Properties.Patient_program;
using CsvHelper.Configuration;
using CsvHelper;
using WindowsFormsApp1.Properties;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class patient_form : Form
    {
        string Get_ID;
        public patient_form(string ID)
        {
            Get_ID = ID;
            InitializeComponent();
        }

        // cần thuật toán lấy data bằng ID => dữ liệu bệnh nhân phải đi theo ID

        private void patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;

            // Kiểm tra tab nào đang được chọn
            if (tabControl.SelectedTab == list_bill)
            {
                // Load cột và hàng cho tab 1
                load_data1(Get_ID);
            }
            else if (tabControl.SelectedTab == Apoint)
            {
                // Load cột và hàng cho tab 2
                load_data2(Get_ID);
            }
            else if (tabControl.SelectedTab == Diagnostics_tab)
            {
                load_data3(Get_ID);
            }
            else if (tabControl.SelectedTab == History)
            {
                load_data4(Get_ID);
            }

        }
        //load_data();

        public void load_data2(string ID)
        {
            // Tạo cột và đặt tiêu đề cho cột


            // Assume you have already defined your ListView with columns.
            listView2.Items.Clear();
            listView2.View = View.Details;
            // Define the path to your CSV file.
            string csvFilePath = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\patient\\" + ID + "\\Apoint.csv";

            // Read data from CSV and add it to ListView.
            using (StreamReader reader = new StreamReader(csvFilePath))
            {

                string[] headers = reader.ReadLine().Split(',');
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    ListViewItem item = new ListViewItem(data[0]); // Assuming the first column


                    item.SubItems.Add(data[1]);
                    item.SubItems.Add(data[2]);
                    item.SubItems.Add(data[3]);
                    item.SubItems.Add(data[4]);



                    listView2.Items.Add(item);
                }
            }









        }
        public void load_data1(string ID)
        {
            // Assume you have already defined your ListView with columns.
            listView1.Items.Clear();
            listView1.View = View.Details;
            // Define the path to your CSV file.
            string csvFilePath = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\patient\\" + ID + "\\List_Bill.csv";

            // Read data from CSV and add it to ListView.
            using (StreamReader reader = new StreamReader(csvFilePath))
            {

                string[] headers = reader.ReadLine().Split(',');
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    ListViewItem item = new ListViewItem(data[0]); // Assuming the first column

                    item.SubItems.Add(data[1]);
                    item.SubItems.Add(data[2]);
                    item.SubItems.Add(data[3]);
                    item.SubItems.Add(data[4]);
                    listView1.Items.Add(item);
                }
            }






        }
        public void load_data3(string ID)
        {



            //listView3.Items.Clear();
            listView3.View = View.Details;
            // Define the path to your CSV file.
            string csvFilePath = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\patient\\" + ID + "\\List_Bill.csv";

            // Read data from CSV and add it to ListView.
            using (StreamReader reader = new StreamReader(csvFilePath))
            {

                string[] headers = reader.ReadLine().Split(',');
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    ListViewItem item = new ListViewItem("press to view detail"); // Assuming the first column


                    item.SubItems.Add(data[0]);
                    item.SubItems.Add(data[1]);
                    item.SubItems.Add(data[2]);

                    listView3.Items.Add(item);
                }
            }


        }
        public void btn_load_Click(object sender, EventArgs e)
        {
            load_data1(Get_ID);
        }



        private void listView3_MouseClick(object sender, MouseEventArgs e)
        {

            ListView listView = (ListView)sender;
            Point mousePoint = e.Location;


            // Xác định item và subitem bằng phương thức GetItemAt

            ListViewItem clickedItem = listView.GetItemAt(mousePoint.X, mousePoint.Y);

            if (clickedItem != null)
            {

                Rectangle itemBounds = clickedItem.GetBounds(ItemBoundsPortion.Entire);
                Point itemLocation = new Point(itemBounds.Left, itemBounds.Top);
                int position = (itemLocation.Y - 24) / 17;
                ListViewItem temp_item = listView3.Items[position];
                MessageBox.Show($"Tọa độ của mục được nhấp: X={itemLocation.X}, Y={itemLocation.Y}");
                // Lấy tọa độ của mục được nhấp
                dia_form form3 = new dia_form(temp_item.SubItems[1].Text);
                form3.ShowDialog();
            }



        }

                private void load_data4(string ID)
        {
            listView4.Items.Clear();
            listView4.View = View.Details;
            // Define the path to your CSV file.
            string csvFilePath = "D:\\workspace\\OOP\\source\\recor\\WindowsFormsApp1\\Data\\patient\\" + ID + "\\history.csv";

            // Read data from CSV and add it to ListView.
            using (StreamReader reader = new StreamReader(csvFilePath))
            {

                string[] headers = reader.ReadLine().Split(',');
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split(',');
                    ListViewItem item = new ListViewItem(data[0]); // Assuming the first column


                    item.SubItems.Add(data[1]);
                    item.SubItems.Add(data[2]);



                    listView4.Items.Add(item);
                }
            }

        }




        private void listView4_MouseClick(object sender, MouseEventArgs e)
        {

            ListView listView = (ListView)sender;
            Point mousePoint = e.Location;


            // Xác định item và subitem bằng phương thức GetItemAt

            ListViewItem clickedItem = listView.GetItemAt(mousePoint.X, mousePoint.Y);

            if (clickedItem != null)
            {

                Rectangle itemBounds = clickedItem.GetBounds(ItemBoundsPortion.Entire);
                Point itemLocation = new Point(itemBounds.Left, itemBounds.Top);
                int position = (itemLocation.Y - 24) / 17;
                ListViewItem temp_item = listView4.Items[position];
                MessageBox.Show($"Tọa độ của mục được nhấp: X={itemLocation.X}, Y={itemLocation.Y}");
                // Lấy tọa độ của mục được nhấp
                History_form form3 = new History_form(temp_item.SubItems[1].Text);
                MessageBox.Show(temp_item.SubItems[1].Text);
                form3.ShowDialog();
            }



        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            cancel_apoint form = new cancel_apoint(Get_ID);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_data2(Get_ID);
        }

        private void Pay_BT_Click(object sender, EventArgs e)
        {
            Pay_form f3 =new Pay_form(Get_ID);
            f3.ShowDialog();

        }
    }
}


