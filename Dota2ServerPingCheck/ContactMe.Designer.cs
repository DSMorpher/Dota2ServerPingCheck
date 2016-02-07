namespace Dota2ServerPingCheck
{
    partial class ContactMe
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
            this.main1 = new System.Windows.Forms.Label();
            this.lnkMail = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFeedback = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.main2 = new System.Windows.Forms.Label();
            this.main3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // main1
            // 
            this.main1.AutoSize = true;
            this.main1.Location = new System.Drawing.Point(12, 9);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(260, 13);
            this.main1.TabIndex = 0;
            this.main1.Text = "You can contact me for any bug/issue you might face";
            // 
            // lnkMail
            // 
            this.lnkMail.AutoSize = true;
            this.lnkMail.Location = new System.Drawing.Point(64, 58);
            this.lnkMail.Name = "lnkMail";
            this.lnkMail.Size = new System.Drawing.Size(148, 13);
            this.lnkMail.TabIndex = 1;
            this.lnkMail.TabStop = true;
            this.lnkMail.Text = "umer.javaid.ceme@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type your Feedback in the following box and Send.";
            // 
            // tbFeedback
            // 
            this.tbFeedback.Location = new System.Drawing.Point(12, 102);
            this.tbFeedback.Multiline = true;
            this.tbFeedback.Name = "tbFeedback";
            this.tbFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFeedback.Size = new System.Drawing.Size(260, 118);
            this.tbFeedback.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(197, 226);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // main2
            // 
            this.main2.AutoSize = true;
            this.main2.Location = new System.Drawing.Point(12, 35);
            this.main2.Name = "main2";
            this.main2.Size = new System.Drawing.Size(228, 13);
            this.main2.TabIndex = 8;
            this.main2.Text = " using the textbox below or your email account.";
            // 
            // main3
            // 
            this.main3.AutoSize = true;
            this.main3.Location = new System.Drawing.Point(12, 22);
            this.main3.Name = "main3";
            this.main3.Size = new System.Drawing.Size(266, 13);
            this.main3.TabIndex = 9;
            this.main3.Text = " or any suggestions/improvments. It can be done either";
            // 
            // ContactMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.main3);
            this.Controls.Add(this.main2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbFeedback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkMail);
            this.Controls.Add(this.main1);
            this.Name = "ContactMe";
            this.Text = "ContactMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main1;
        private System.Windows.Forms.LinkLabel lnkMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFeedback;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label main2;
        private System.Windows.Forms.Label main3;
    }
}