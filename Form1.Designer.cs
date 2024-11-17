namespace WForecast
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
            this.rtbGPT = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // locEnter
            // 
            this.locEnter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.locEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locEnter.Location = new System.Drawing.Point(284, 49);
            this.locEnter.Multiline = true;
            this.locEnter.Name = "locEnter";
            this.locEnter.Size = new System.Drawing.Size(183, 60);
            this.locEnter.TabIndex = 0;
            // 
            // getWeath
            // 
            this.getWeath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.getWeath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getWeath.Location = new System.Drawing.Point(284, 115);
            this.getWeath.Name = "getWeath";
            this.getWeath.Size = new System.Drawing.Size(96, 44);
            this.getWeath.TabIndex = 1;
            this.getWeath.Text = "Get response";
            this.getWeath.UseVisualStyleBackColor = false;
            this.getWeath.Click += new System.EventHandler(this.getWeath_Click);
            // 
            // weathFOR
            // 
            this.weathFOR.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.weathFOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weathFOR.Location = new System.Drawing.Point(284, 165);
            this.weathFOR.Multiline = true;
            this.weathFOR.Name = "weathFOR";
            this.weathFOR.Size = new System.Drawing.Size(183, 60);
            this.weathFOR.TabIndex = 2;
            // 
            // rtbGPT
            // 
            this.rtbGPT.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rtbGPT.Location = new System.Drawing.Point(152, 317);
            this.rtbGPT.Name = "rtbGPT";
            this.rtbGPT.Size = new System.Drawing.Size(460, 96);
            this.rtbGPT.TabIndex = 3;
            this.rtbGPT.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbGPT);
            this.Controls.Add(this.weathFOR);
            this.Controls.Add(this.getWeath);
            this.Controls.Add(this.locEnter);
            this.Name = "Form1";
            this.Text = "API test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locEnter;
        private System.Windows.Forms.Button getWeath;
        private System.Windows.Forms.TextBox weathFOR;
        private System.Windows.Forms.RichTextBox rtbGPT;
    }
}

