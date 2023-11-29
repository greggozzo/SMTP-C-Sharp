
namespace SMTP_C_Sharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblRegion = new System.Windows.Forms.Label();
            this.LblFrom = new System.Windows.Forms.Label();
            this.LblTo = new System.Windows.Forms.Label();
            this.LblSubject = new System.Windows.Forms.Label();
            this.LblBody = new System.Windows.Forms.Label();
            this.lblAtach = new System.Windows.Forms.Label();
            this.LblAccessKey = new System.Windows.Forms.Label();
            this.LblSecretKey = new System.Windows.Forms.Label();
            this.CbRegion = new System.Windows.Forms.ComboBox();
            this.TxtFrom = new System.Windows.Forms.TextBox();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtBody = new System.Windows.Forms.TextBox();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.TxtKey = new System.Windows.Forms.TextBox();
            this.TxtSecret = new System.Windows.Forms.TextBox();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.CheckDelegate = new System.Windows.Forms.CheckBox();
            this.TxtDelegate = new System.Windows.Forms.TextBox();
            this.ButtonSearchFile = new System.Windows.Forms.Button();
            this.textReply = new System.Windows.Forms.TextBox();
            this.checkReplyTo = new System.Windows.Forms.CheckBox();
            this.checkBcc = new System.Windows.Forms.CheckBox();
            this.textReference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkLoop = new System.Windows.Forms.CheckBox();
            this.textLoop = new System.Windows.Forms.TextBox();
            this.textBcc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblRegion
            // 
            this.LblRegion.AutoSize = true;
            this.LblRegion.Location = new System.Drawing.Point(26, 41);
            this.LblRegion.Name = "LblRegion";
            this.LblRegion.Size = new System.Drawing.Size(44, 13);
            this.LblRegion.TabIndex = 0;
            this.LblRegion.Text = "Region:";
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Location = new System.Drawing.Point(26, 107);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(33, 13);
            this.LblFrom.TabIndex = 1;
            this.LblFrom.Text = "From:";
            // 
            // LblTo
            // 
            this.LblTo.AutoSize = true;
            this.LblTo.Location = new System.Drawing.Point(26, 167);
            this.LblTo.Name = "LblTo";
            this.LblTo.Size = new System.Drawing.Size(23, 13);
            this.LblTo.TabIndex = 2;
            this.LblTo.Text = "To:";
            // 
            // LblSubject
            // 
            this.LblSubject.AutoSize = true;
            this.LblSubject.Location = new System.Drawing.Point(26, 264);
            this.LblSubject.Name = "LblSubject";
            this.LblSubject.Size = new System.Drawing.Size(46, 13);
            this.LblSubject.TabIndex = 3;
            this.LblSubject.Text = "Subject:";
            // 
            // LblBody
            // 
            this.LblBody.AutoSize = true;
            this.LblBody.Location = new System.Drawing.Point(26, 311);
            this.LblBody.Name = "LblBody";
            this.LblBody.Size = new System.Drawing.Size(34, 13);
            this.LblBody.TabIndex = 4;
            this.LblBody.Text = "Body:";
            // 
            // lblAtach
            // 
            this.lblAtach.AutoSize = true;
            this.lblAtach.Location = new System.Drawing.Point(26, 357);
            this.lblAtach.Name = "lblAtach";
            this.lblAtach.Size = new System.Drawing.Size(64, 13);
            this.lblAtach.TabIndex = 5;
            this.lblAtach.Text = "Attachment:";
            // 
            // LblAccessKey
            // 
            this.LblAccessKey.AutoSize = true;
            this.LblAccessKey.Location = new System.Drawing.Point(302, 41);
            this.LblAccessKey.Name = "LblAccessKey";
            this.LblAccessKey.Size = new System.Drawing.Size(74, 13);
            this.LblAccessKey.TabIndex = 6;
            this.LblAccessKey.Text = "AccessKeyID:";
            // 
            // LblSecretKey
            // 
            this.LblSecretKey.AutoSize = true;
            this.LblSecretKey.Location = new System.Drawing.Point(302, 107);
            this.LblSecretKey.Name = "LblSecretKey";
            this.LblSecretKey.Size = new System.Drawing.Size(94, 13);
            this.LblSecretKey.TabIndex = 7;
            this.LblSecretKey.Text = "AccessSecretKey:";
            // 
            // CbRegion
            // 
            this.CbRegion.FormattingEnabled = true;
            this.CbRegion.Location = new System.Drawing.Point(29, 57);
            this.CbRegion.Name = "CbRegion";
            this.CbRegion.Size = new System.Drawing.Size(204, 21);
            this.CbRegion.TabIndex = 8;
            // 
            // TxtFrom
            // 
            this.TxtFrom.Location = new System.Drawing.Point(29, 125);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.Size = new System.Drawing.Size(204, 20);
            this.TxtFrom.TabIndex = 9;
            // 
            // TxtTo
            // 
            this.TxtTo.Location = new System.Drawing.Point(29, 183);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(204, 20);
            this.TxtTo.TabIndex = 10;
            // 
            // TxtSubject
            // 
            this.TxtSubject.Location = new System.Drawing.Point(29, 280);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(204, 20);
            this.TxtSubject.TabIndex = 11;
            // 
            // TxtBody
            // 
            this.TxtBody.Location = new System.Drawing.Point(29, 327);
            this.TxtBody.Name = "TxtBody";
            this.TxtBody.Size = new System.Drawing.Size(204, 20);
            this.TxtBody.TabIndex = 12;
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(29, 402);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(204, 20);
            this.txtAttachment.TabIndex = 13;
            // 
            // TxtKey
            // 
            this.TxtKey.Location = new System.Drawing.Point(305, 58);
            this.TxtKey.Name = "TxtKey";
            this.TxtKey.Size = new System.Drawing.Size(204, 20);
            this.TxtKey.TabIndex = 14;
            // 
            // TxtSecret
            // 
            this.TxtSecret.Location = new System.Drawing.Point(305, 125);
            this.TxtSecret.Name = "TxtSecret";
            this.TxtSecret.PasswordChar = '*';
            this.TxtSecret.Size = new System.Drawing.Size(204, 20);
            this.TxtSecret.TabIndex = 15;
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(305, 229);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(201, 20);
            this.TxtFilePath.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(305, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Check To Get Access Key From .csv";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(29, 437);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 27);
            this.ButtonSend.TabIndex = 18;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(305, 200);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(204, 23);
            this.ButtonSearch.TabIndex = 19;
            this.ButtonSearch.Text = "Search For CSV File";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CheckDelegate
            // 
            this.CheckDelegate.AutoSize = true;
            this.CheckDelegate.Location = new System.Drawing.Point(305, 260);
            this.CheckDelegate.Name = "CheckDelegate";
            this.CheckDelegate.Size = new System.Drawing.Size(128, 17);
            this.CheckDelegate.TabIndex = 20;
            this.CheckDelegate.Text = "Use Delegate Sender";
            this.CheckDelegate.UseVisualStyleBackColor = true;
            // 
            // TxtDelegate
            // 
            this.TxtDelegate.Location = new System.Drawing.Point(305, 283);
            this.TxtDelegate.Name = "TxtDelegate";
            this.TxtDelegate.Size = new System.Drawing.Size(201, 20);
            this.TxtDelegate.TabIndex = 21;
            this.TxtDelegate.Text = "Identity ARN";
            this.TxtDelegate.Enter += new System.EventHandler(this.TxtDelegate_Enter);
            // 
            // ButtonSearchFile
            // 
            this.ButtonSearchFile.Location = new System.Drawing.Point(29, 373);
            this.ButtonSearchFile.Name = "ButtonSearchFile";
            this.ButtonSearchFile.Size = new System.Drawing.Size(201, 23);
            this.ButtonSearchFile.TabIndex = 22;
            this.ButtonSearchFile.Text = "Search For Attachment";
            this.ButtonSearchFile.UseVisualStyleBackColor = true;
            this.ButtonSearchFile.Click += new System.EventHandler(this.ButtonSearchFile_Click);
            // 
            // textReply
            // 
            this.textReply.Location = new System.Drawing.Point(302, 334);
            this.textReply.Name = "textReply";
            this.textReply.ReadOnly = true;
            this.textReply.Size = new System.Drawing.Size(204, 20);
            this.textReply.TabIndex = 23;
            // 
            // checkReplyTo
            // 
            this.checkReplyTo.AutoSize = true;
            this.checkReplyTo.Location = new System.Drawing.Point(305, 311);
            this.checkReplyTo.Name = "checkReplyTo";
            this.checkReplyTo.Size = new System.Drawing.Size(81, 17);
            this.checkReplyTo.TabIndex = 24;
            this.checkReplyTo.Text = "In-Reply-To";
            this.checkReplyTo.UseVisualStyleBackColor = true;
            this.checkReplyTo.CheckedChanged += new System.EventHandler(this.checkReplyTo_CheckedChanged);
            // 
            // checkBcc
            // 
            this.checkBcc.AutoSize = true;
            this.checkBcc.Location = new System.Drawing.Point(29, 209);
            this.checkBcc.Name = "checkBcc";
            this.checkBcc.Size = new System.Drawing.Size(67, 17);
            this.checkBcc.TabIndex = 25;
            this.checkBcc.Text = "Use Bcc";
            this.checkBcc.UseVisualStyleBackColor = true;
            this.checkBcc.CheckedChanged += new System.EventHandler(this.checkBcc_CheckedChanged);
            // 
            // textReference
            // 
            this.textReference.Location = new System.Drawing.Point(302, 373);
            this.textReference.Name = "textReference";
            this.textReference.ReadOnly = true;
            this.textReference.Size = new System.Drawing.Size(204, 20);
            this.textReference.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Reference";
            // 
            // checkLoop
            // 
            this.checkLoop.AutoSize = true;
            this.checkLoop.Location = new System.Drawing.Point(302, 413);
            this.checkLoop.Name = "checkLoop";
            this.checkLoop.Size = new System.Drawing.Size(124, 17);
            this.checkLoop.TabIndex = 28;
            this.checkLoop.Text = "Loop Emails # Times";
            this.checkLoop.UseVisualStyleBackColor = true;
            this.checkLoop.CheckedChanged += new System.EventHandler(this.checkLoop_CheckedChanged);
            // 
            // textLoop
            // 
            this.textLoop.Location = new System.Drawing.Point(432, 410);
            this.textLoop.Name = "textLoop";
            this.textLoop.ReadOnly = true;
            this.textLoop.Size = new System.Drawing.Size(74, 20);
            this.textLoop.TabIndex = 29;
            // 
            // textBcc
            // 
            this.textBcc.Location = new System.Drawing.Point(29, 232);
            this.textBcc.Name = "textBcc";
            this.textBcc.ReadOnly = true;
            this.textBcc.Size = new System.Drawing.Size(204, 20);
            this.textBcc.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 470);
            this.Controls.Add(this.textBcc);
            this.Controls.Add(this.textLoop);
            this.Controls.Add(this.checkLoop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textReference);
            this.Controls.Add(this.checkBcc);
            this.Controls.Add(this.checkReplyTo);
            this.Controls.Add(this.textReply);
            this.Controls.Add(this.ButtonSearchFile);
            this.Controls.Add(this.TxtDelegate);
            this.Controls.Add(this.CheckDelegate);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.TxtSecret);
            this.Controls.Add(this.TxtKey);
            this.Controls.Add(this.txtAttachment);
            this.Controls.Add(this.TxtBody);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.TxtFrom);
            this.Controls.Add(this.CbRegion);
            this.Controls.Add(this.LblSecretKey);
            this.Controls.Add(this.LblAccessKey);
            this.Controls.Add(this.lblAtach);
            this.Controls.Add(this.LblBody);
            this.Controls.Add(this.LblSubject);
            this.Controls.Add(this.LblTo);
            this.Controls.Add(this.LblFrom);
            this.Controls.Add(this.LblRegion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWS SMTP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegion;
        private System.Windows.Forms.Label LblFrom;
        private System.Windows.Forms.Label LblTo;
        private System.Windows.Forms.Label LblSubject;
        private System.Windows.Forms.Label LblBody;
        private System.Windows.Forms.Label lblAtach;
        private System.Windows.Forms.Label LblAccessKey;
        private System.Windows.Forms.Label LblSecretKey;
        private System.Windows.Forms.ComboBox CbRegion;
        private System.Windows.Forms.TextBox TxtFrom;
        private System.Windows.Forms.TextBox TxtTo;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.TextBox TxtBody;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.TextBox TxtKey;
        private System.Windows.Forms.TextBox TxtSecret;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox CheckDelegate;
        private System.Windows.Forms.TextBox TxtDelegate;
        private System.Windows.Forms.Button ButtonSearchFile;
        private System.Windows.Forms.TextBox textReply;
        private System.Windows.Forms.CheckBox checkReplyTo;
        private System.Windows.Forms.CheckBox checkBcc;
        private System.Windows.Forms.TextBox textReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkLoop;
        private System.Windows.Forms.TextBox textLoop;
        private System.Windows.Forms.TextBox textBcc;
    }
}

