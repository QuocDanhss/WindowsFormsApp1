namespace WindowsFormsApp1
{
    partial class cancel_apoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cancel_apoint));
            this.IDTB = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(34, 65);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(228, 20);
            this.IDTB.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(31, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(50, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID apoint";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(172, 136);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(109, 28);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm ";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 136);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(102, 28);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // cancel_apoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 235);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cancel_apoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancel Apoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button Cancel;
    }
}