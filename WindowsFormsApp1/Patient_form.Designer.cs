namespace WindowsFormsApp1
{
    partial class patient_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader ID_bill;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_form));
            this.Date_dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patient = new System.Windows.Forms.TabControl();
            this.list_bill = new System.Windows.Forms.TabPage();
            this.Pay_BT = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.de = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apoint = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ID_apoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.with_doctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_apoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time_apoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.room_apoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diagnostics_tab = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.detail_dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doctor_dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.History = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.detail_his = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.index_his = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ID_bill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patient.SuspendLayout();
            this.list_bill.SuspendLayout();
            this.Apoint.SuspendLayout();
            this.Diagnostics_tab.SuspendLayout();
            this.History.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_bill
            // 
            ID_bill.Tag = "";
            ID_bill.Text = "ID bill";
            ID_bill.Width = 100;
            // 
            // Date_dia
            // 
            this.Date_dia.Text = "Date";
            this.Date_dia.Width = 200;
            // 
            // patient
            // 
            this.patient.Controls.Add(this.list_bill);
            this.patient.Controls.Add(this.Apoint);
            this.patient.Controls.Add(this.Diagnostics_tab);
            this.patient.Controls.Add(this.History);
            this.patient.ImeMode = System.Windows.Forms.ImeMode.On;
            this.patient.Location = new System.Drawing.Point(-4, 30);
            this.patient.Name = "patient";
            this.patient.SelectedIndex = 0;
            this.patient.Size = new System.Drawing.Size(809, 457);
            this.patient.TabIndex = 0;
            this.patient.SelectedIndexChanged += new System.EventHandler(this.patient_SelectedIndexChanged);
            // 
            // list_bill
            // 
            this.list_bill.Controls.Add(this.Pay_BT);
            this.list_bill.Controls.Add(this.btn_load);
            this.list_bill.Controls.Add(this.listView1);
            this.list_bill.Location = new System.Drawing.Point(4, 22);
            this.list_bill.Name = "list_bill";
            this.list_bill.Padding = new System.Windows.Forms.Padding(3);
            this.list_bill.Size = new System.Drawing.Size(801, 431);
            this.list_bill.TabIndex = 0;
            this.list_bill.Tag = "";
            this.list_bill.Text = "List Bill";
            // 
            // Pay_BT
            // 
            this.Pay_BT.Location = new System.Drawing.Point(217, 323);
            this.Pay_BT.Name = "Pay_BT";
            this.Pay_BT.Size = new System.Drawing.Size(114, 32);
            this.Pay_BT.TabIndex = 2;
            this.Pay_BT.Text = "Pay bill";
            this.Pay_BT.UseVisualStyleBackColor = true;
            this.Pay_BT.Click += new System.EventHandler(this.Pay_BT_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(65, 323);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 32);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ID_bill,
            this.de,
            this.amount,
            this.paid,
            this.date});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(801, 319);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // de
            // 
            this.de.Text = "des";
            this.de.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.de.Width = 300;
            // 
            // amount
            // 
            this.amount.Tag = "";
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 120;
            // 
            // paid
            // 
            this.paid.Text = "Status paid";
            this.paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paid.Width = 140;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 200;
            // 
            // Apoint
            // 
            this.Apoint.Controls.Add(this.button2);
            this.Apoint.Controls.Add(this.button1);
            this.Apoint.Controls.Add(this.listView2);
            this.Apoint.Location = new System.Drawing.Point(4, 22);
            this.Apoint.Name = "Apoint";
            this.Apoint.Padding = new System.Windows.Forms.Padding(3);
            this.Apoint.Size = new System.Drawing.Size(801, 431);
            this.Apoint.TabIndex = 1;
            this.Apoint.Text = "Apointment";
            this.Apoint.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(279, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refesh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(60, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel Apoint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.AllowColumnReorder = true;
            this.listView2.AllowDrop = true;
            this.listView2.AutoArrange = false;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_apoint,
            this.with_doctor,
            this.date_apoint,
            this.Time_apoint,
            this.room_apoint});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-4, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(809, 343);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // ID_apoint
            // 
            this.ID_apoint.Text = "ID";
            this.ID_apoint.Width = 100;
            // 
            // with_doctor
            // 
            this.with_doctor.Text = "Doctor";
            this.with_doctor.Width = 120;
            // 
            // date_apoint
            // 
            this.date_apoint.Text = "Date";
            this.date_apoint.Width = 200;
            // 
            // Time_apoint
            // 
            this.Time_apoint.Text = "Time";
            // 
            // room_apoint
            // 
            this.room_apoint.Text = "Room";
            // 
            // Diagnostics_tab
            // 
            this.Diagnostics_tab.Controls.Add(this.listView3);
            this.Diagnostics_tab.Location = new System.Drawing.Point(4, 22);
            this.Diagnostics_tab.Name = "Diagnostics_tab";
            this.Diagnostics_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Diagnostics_tab.Size = new System.Drawing.Size(801, 431);
            this.Diagnostics_tab.TabIndex = 2;
            this.Diagnostics_tab.Text = "Diagnostics";
            this.Diagnostics_tab.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.AutoArrange = false;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.detail_dia,
            this.Doctor_dia,
            this.Date_dia,
            this.ID_dia});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(801, 337);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView3_MouseClick);
            // 
            // detail_dia
            // 
            this.detail_dia.DisplayIndex = 3;
            this.detail_dia.Text = "Detail";
            this.detail_dia.Width = 200;
            // 
            // Doctor_dia
            // 
            this.Doctor_dia.Text = "Doctor";
            this.Doctor_dia.Width = 120;
            // 
            // ID_dia
            // 
            this.ID_dia.DisplayIndex = 0;
            this.ID_dia.Text = "ID diagnostics";
            // 
            // History
            // 
            this.History.Controls.Add(this.listView4);
            this.History.Cursor = System.Windows.Forms.Cursors.Default;
            this.History.Location = new System.Drawing.Point(4, 22);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(801, 431);
            this.History.TabIndex = 3;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.detail_his,
            this.index_his,
            this.date_1});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(-2, 0);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(803, 317);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            this.listView4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView4_MouseClick);
            // 
            // detail_his
            // 
            this.detail_his.DisplayIndex = 2;
            this.detail_his.Text = "Detail ";
            // 
            // index_his
            // 
            this.index_his.DisplayIndex = 0;
            this.index_his.Text = "index";
            // 
            // date_1
            // 
            this.date_1.DisplayIndex = 1;
            this.date_1.Text = "Date";
            this.date_1.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 56);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patient_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.patient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "patient_form";
            this.Text = "Form2";
            this.patient.ResumeLayout(false);
            this.list_bill.ResumeLayout(false);
            this.Apoint.ResumeLayout(false);
            this.Diagnostics_tab.ResumeLayout(false);
            this.History.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl patient;
        private System.Windows.Forms.TabPage list_bill;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage Apoint;
        public System.Windows.Forms.ColumnHeader amount;
        public System.Windows.Forms.ColumnHeader paid;
        public System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ColumnHeader de;
        private System.Windows.Forms.TabPage Diagnostics_tab;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader with_doctor;
        private System.Windows.Forms.ColumnHeader date_apoint;
        private System.Windows.Forms.ColumnHeader Time_apoint;
        private System.Windows.Forms.ColumnHeader room_apoint;
        private System.Windows.Forms.ColumnHeader ID_apoint;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader Doctor_dia;
        private System.Windows.Forms.ColumnHeader Date_dia;
        private System.Windows.Forms.ColumnHeader detail_dia;
        private System.Windows.Forms.ColumnHeader ID_dia;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader detail_his;
        private System.Windows.Forms.ColumnHeader index_his;
        private System.Windows.Forms.ColumnHeader date_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Pay_BT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}