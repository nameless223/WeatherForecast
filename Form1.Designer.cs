﻿namespace WForecast
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
            this.locEnter = new System.Windows.Forms.TextBox();
            this.getWeath = new System.Windows.Forms.Button();
            this.weathFOR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // locEnter
            // 
            this.locEnter.Location = new System.Drawing.Point(289, 38);
            this.locEnter.Multiline = true;
            this.locEnter.Name = "locEnter";
            this.locEnter.Size = new System.Drawing.Size(183, 60);
            this.locEnter.TabIndex = 0;
            // 
            // getWeath
            // 
            this.getWeath.Location = new System.Drawing.Point(289, 116);
            this.getWeath.Name = "getWeath";
            this.getWeath.Size = new System.Drawing.Size(96, 44);
            this.getWeath.TabIndex = 1;
            this.getWeath.Text = "button1";
            this.getWeath.UseVisualStyleBackColor = true;
            this.getWeath.Click += new System.EventHandler(this.getWeath_Click);
            // 
            // weathFOR
            // 
            this.weathFOR.Location = new System.Drawing.Point(290, 200);
            this.weathFOR.Multiline = true;
            this.weathFOR.Name = "weathFOR";
            this.weathFOR.Size = new System.Drawing.Size(181, 77);
            this.weathFOR.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weathFOR);
            this.Controls.Add(this.getWeath);
            this.Controls.Add(this.locEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locEnter;
        private System.Windows.Forms.Button getWeath;
        private System.Windows.Forms.TextBox weathFOR;
    }
}
