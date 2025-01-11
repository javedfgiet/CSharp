namespace MultiThreadApplication
{
    partial class Form1
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
            this.btnTimeConsumingWork = new System.Windows.Forms.Button();
            this.btnPrintNumbers = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTimeConsumingWork
            // 
            this.btnTimeConsumingWork.Location = new System.Drawing.Point(31, 33);
            this.btnTimeConsumingWork.Name = "btnTimeConsumingWork";
            this.btnTimeConsumingWork.Size = new System.Drawing.Size(208, 50);
            this.btnTimeConsumingWork.TabIndex = 0;
            this.btnTimeConsumingWork.Text = "DoTimeConsumingWork";
            this.btnTimeConsumingWork.UseVisualStyleBackColor = true;
            this.btnTimeConsumingWork.Click += new System.EventHandler(this.btnTimeConsumingWork_Click);
            // 
            // btnPrintNumbers
            // 
            this.btnPrintNumbers.Location = new System.Drawing.Point(292, 38);
            this.btnPrintNumbers.Name = "btnPrintNumbers";
            this.btnPrintNumbers.Size = new System.Drawing.Size(208, 45);
            this.btnPrintNumbers.TabIndex = 1;
            this.btnPrintNumbers.Text = "PrintNumbers";
            this.btnPrintNumbers.UseVisualStyleBackColor = true;
            this.btnPrintNumbers.Click += new System.EventHandler(this.btnPrintNumbers_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 20;
            this.lstNumbers.Location = new System.Drawing.Point(120, 118);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(259, 344);
            this.lstNumbers.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 703);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnPrintNumbers);
            this.Controls.Add(this.btnTimeConsumingWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimeConsumingWork;
        private System.Windows.Forms.Button btnPrintNumbers;
        private System.Windows.Forms.ListBox lstNumbers;
    }
}

