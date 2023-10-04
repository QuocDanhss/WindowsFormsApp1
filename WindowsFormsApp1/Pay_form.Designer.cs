namespace WindowsFormsApp1
{
    partial class Pay_form
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
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancel = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.amount_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_TB
            // 
            this.ID_TB.Location = new System.Drawing.Point(76, 58);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.Size = new System.Drawing.Size(244, 20);
            this.ID_TB.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(46, 250);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(86, 29);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Pay
            // 
            this.Pay.Location = new System.Drawing.Point(205, 250);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(97, 29);
            this.Pay.TabIndex = 3;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // amount_TB
            // 
            this.amount_TB.Location = new System.Drawing.Point(76, 151);
            this.amount_TB.Name = "amount_TB";
            this.amount_TB.Size = new System.Drawing.Size(244, 20);
            this.amount_TB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // Pay_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amount_TB);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ID_TB);
            this.Name = "Pay_form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.TextBox amount_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}