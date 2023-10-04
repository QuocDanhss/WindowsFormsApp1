namespace WindowsFormsApp1
{
    partial class Forgotform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgotform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Textb_ID = new System.Windows.Forms.TextBox();
            this.TextB_email = new System.Windows.Forms.TextBox();
            this.TextB_phone = new System.Windows.Forms.TextBox();
            this.TextB_npass = new System.Windows.Forms.TextBox();
            this.TextB_confim = new System.Windows.Forms.TextBox();
            this.cofirmbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(159, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(159, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(158, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(159, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(159, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm pass word:";
            // 
            // Textb_ID
            // 
            this.Textb_ID.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textb_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Textb_ID.Location = new System.Drawing.Point(352, 58);
            this.Textb_ID.Name = "Textb_ID";
            this.Textb_ID.Size = new System.Drawing.Size(173, 22);
            this.Textb_ID.TabIndex = 12;
            this.Textb_ID.Text = "import your ID";
            this.Textb_ID.Enter += new System.EventHandler(this.Textb_ID_Enter);
            // 
            // TextB_email
            // 
            this.TextB_email.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextB_email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextB_email.Location = new System.Drawing.Point(352, 86);
            this.TextB_email.Name = "TextB_email";
            this.TextB_email.Size = new System.Drawing.Size(173, 22);
            this.TextB_email.TabIndex = 13;
            this.TextB_email.Text = "import your Email";
            this.TextB_email.Enter += new System.EventHandler(this.TextB_email_Enter);
            // 
            // TextB_phone
            // 
            this.TextB_phone.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextB_phone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextB_phone.Location = new System.Drawing.Point(352, 119);
            this.TextB_phone.Name = "TextB_phone";
            this.TextB_phone.Size = new System.Drawing.Size(173, 22);
            this.TextB_phone.TabIndex = 14;
            this.TextB_phone.Text = "import your number phone";
            this.TextB_phone.Enter += new System.EventHandler(this.TextB_phone_Enter);
            // 
            // TextB_npass
            // 
            this.TextB_npass.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextB_npass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextB_npass.Location = new System.Drawing.Point(352, 163);
            this.TextB_npass.Name = "TextB_npass";
            this.TextB_npass.Size = new System.Drawing.Size(173, 22);
            this.TextB_npass.TabIndex = 15;
            this.TextB_npass.Text = "import your new password";
            this.TextB_npass.Enter += new System.EventHandler(this.TextB_npass_Enter);
            // 
            // TextB_confim
            // 
            this.TextB_confim.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextB_confim.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextB_confim.Location = new System.Drawing.Point(352, 205);
            this.TextB_confim.Name = "TextB_confim";
            this.TextB_confim.Size = new System.Drawing.Size(173, 22);
            this.TextB_confim.TabIndex = 16;
            this.TextB_confim.Text = "import your new password";
            this.TextB_confim.Enter += new System.EventHandler(this.TextB_confim_Enter);
            // 
            // cofirmbtn
            // 
            this.cofirmbtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.cofirmbtn.Location = new System.Drawing.Point(450, 261);
            this.cofirmbtn.Name = "cofirmbtn";
            this.cofirmbtn.Size = new System.Drawing.Size(75, 23);
            this.cofirmbtn.TabIndex = 17;
            this.cofirmbtn.Text = "CONFIRM";
            this.cofirmbtn.UseVisualStyleBackColor = true;
            this.cofirmbtn.Click += new System.EventHandler(this.Cofirmbtn_Click);
            // 
            // Forgotform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cofirmbtn);
            this.Controls.Add(this.TextB_confim);
            this.Controls.Add(this.TextB_npass);
            this.Controls.Add(this.TextB_phone);
            this.Controls.Add(this.TextB_email);
            this.Controls.Add(this.Textb_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forgotform";
            this.Text = "Forgot password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Textb_ID;
        private System.Windows.Forms.TextBox TextB_email;
        private System.Windows.Forms.TextBox TextB_phone;
        private System.Windows.Forms.TextBox TextB_npass;
        private System.Windows.Forms.TextBox TextB_confim;
        private System.Windows.Forms.Button cofirmbtn;
    }
}