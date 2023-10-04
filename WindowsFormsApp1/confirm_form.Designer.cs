using System;

namespace WindowsFormsApp1
{
    partial class confirm_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirm_form));
            this.cofirm_button = new System.Windows.Forms.Button();
            this.nofication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cofirm_button
            // 
            this.cofirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofirm_button.ForeColor = System.Drawing.Color.IndianRed;
            this.cofirm_button.Image = ((System.Drawing.Image)(resources.GetObject("cofirm_button.Image")));
            this.cofirm_button.Location = new System.Drawing.Point(187, 80);
            this.cofirm_button.Name = "cofirm_button";
            this.cofirm_button.Size = new System.Drawing.Size(75, 23);
            this.cofirm_button.TabIndex = 0;
            this.cofirm_button.Text = "Confirm";
            this.cofirm_button.UseVisualStyleBackColor = true;
            this.cofirm_button.Click += new System.EventHandler(this.cofirm_button_Click);
            // 
            // nofication
            // 
            this.nofication.AutoSize = true;
            this.nofication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nofication.Location = new System.Drawing.Point(54, 35);
            this.nofication.Name = "nofication";
            this.nofication.Size = new System.Drawing.Size(0, 23);
            this.nofication.TabIndex = 1;
            this.nofication.UseCompatibleTextRendering = true;
            // 
            // confirm_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 105);
            this.Controls.Add(this.nofication);
            this.Controls.Add(this.cofirm_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "confirm_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.confirm_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cofirm_button;
        private System.Windows.Forms.Label nofication;
    }
}