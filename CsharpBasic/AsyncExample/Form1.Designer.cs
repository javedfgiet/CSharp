﻿namespace AsyncExample
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
            this.lblCount = new System.Windows.Forms.Label();
            this.btnProcessFIle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(358, 136);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(50, 20);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "teddd";
            // 
            // btnProcessFIle
            // 
            this.btnProcessFIle.Location = new System.Drawing.Point(333, 60);
            this.btnProcessFIle.Name = "btnProcessFIle";
            this.btnProcessFIle.Size = new System.Drawing.Size(222, 38);
            this.btnProcessFIle.TabIndex = 2;
            this.btnProcessFIle.Text = "Process File";
            this.btnProcessFIle.UseVisualStyleBackColor = true;
            this.btnProcessFIle.Click += new System.EventHandler(this.btnProcessFIle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcessFIle);
            this.Controls.Add(this.lblCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnProcessFIle;
    }
}

