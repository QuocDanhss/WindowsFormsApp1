namespace WindowsFormsApp1
{
    partial class only_CB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.onlyCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // onlyCb
            // 
            this.onlyCb.AutoSize = true;
            this.onlyCb.Location = new System.Drawing.Point(0, 0);
            this.onlyCb.Name = "onlyCb";
            this.onlyCb.Size = new System.Drawing.Size(15, 14);
            this.onlyCb.TabIndex = 0;
            this.onlyCb.UseVisualStyleBackColor = true;
            // 
            // only_CB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.onlyCb);
            this.Name = "only_CB";
            this.Size = new System.Drawing.Size(13, 12);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onlyCb;
    }
}
