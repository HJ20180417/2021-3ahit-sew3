namespace _20210311_logger
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMailInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rbFileLog = new System.Windows.Forms.RadioButton();
            this.rbWindowLog = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Text:";
            // 
            // txtMailInput
            // 
            this.txtMailInput.Location = new System.Drawing.Point(16, 30);
            this.txtMailInput.Name = "txtMailInput";
            this.txtMailInput.Size = new System.Drawing.Size(128, 20);
            this.txtMailInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(13, 57);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rbFileLog
            // 
            this.rbFileLog.AutoSize = true;
            this.rbFileLog.Location = new System.Drawing.Point(23, 32);
            this.rbFileLog.Name = "rbFileLog";
            this.rbFileLog.Size = new System.Drawing.Size(59, 17);
            this.rbFileLog.TabIndex = 3;
            this.rbFileLog.TabStop = true;
            this.rbFileLog.Text = "FileLog";
            this.rbFileLog.UseVisualStyleBackColor = true;
            // 
            // rbWindowLog
            // 
            this.rbWindowLog.AutoSize = true;
            this.rbWindowLog.Location = new System.Drawing.Point(23, 55);
            this.rbWindowLog.Name = "rbWindowLog";
            this.rbWindowLog.Size = new System.Drawing.Size(85, 17);
            this.rbWindowLog.TabIndex = 4;
            this.rbWindowLog.TabStop = true;
            this.rbWindowLog.Text = "Window Log";
            this.rbWindowLog.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFileLog);
            this.groupBox1.Controls.Add(this.rbWindowLog);
            this.groupBox1.Location = new System.Drawing.Point(174, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Window Log:";
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(13, 149);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(361, 173);
            this.logBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 334);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMailInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMailInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton rbFileLog;
        private System.Windows.Forms.RadioButton rbWindowLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox logBox;
    }
}

