
namespace _20210506_delegates
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.callMethod = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ckbConnect = new System.Windows.Forms.CheckBox();
            this.ckbMuttertag = new System.Windows.Forms.CheckBox();
            this.lblGeburtstag = new System.Windows.Forms.Label();
            this.lblMuttertag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // callMethod
            // 
            this.callMethod.Location = new System.Drawing.Point(12, 85);
            this.callMethod.Name = "callMethod";
            this.callMethod.Size = new System.Drawing.Size(360, 74);
            this.callMethod.TabIndex = 0;
            this.callMethod.Text = "Call Method";
            this.callMethod.UseVisualStyleBackColor = true;
            this.callMethod.Click += new System.EventHandler(this.callMethod_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 54);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(208, 25);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Push to call Method:";
            // 
            // ckbConnect
            // 
            this.ckbConnect.AutoSize = true;
            this.ckbConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.ckbConnect.Location = new System.Drawing.Point(12, 166);
            this.ckbConnect.Name = "ckbConnect";
            this.ckbConnect.Size = new System.Drawing.Size(350, 27);
            this.ckbConnect.TabIndex = 2;
            this.ckbConnect.Text = " check to connect/disconnect with delegator";
            this.ckbConnect.UseVisualStyleBackColor = true;
            this.ckbConnect.CheckedChanged += new System.EventHandler(this.ckbConnect_CheckedChanged);
            // 
            // ckbMuttertag
            // 
            this.ckbMuttertag.AutoSize = true;
            this.ckbMuttertag.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.ckbMuttertag.Location = new System.Drawing.Point(12, 200);
            this.ckbMuttertag.Name = "ckbMuttertag";
            this.ckbMuttertag.Size = new System.Drawing.Size(334, 27);
            this.ckbMuttertag.TabIndex = 3;
            this.ckbMuttertag.Text = "check to connect/disconnect to muttertag";
            this.ckbMuttertag.UseVisualStyleBackColor = true;
            this.ckbMuttertag.CheckedChanged += new System.EventHandler(this.ckbMuttertag_CheckedChanged);
            // 
            // lblGeburtstag
            // 
            this.lblGeburtstag.AutoSize = true;
            this.lblGeburtstag.Location = new System.Drawing.Point(402, 22);
            this.lblGeburtstag.Name = "lblGeburtstag";
            this.lblGeburtstag.Size = new System.Drawing.Size(19, 25);
            this.lblGeburtstag.TabIndex = 4;
            this.lblGeburtstag.Text = "-";
            // 
            // lblMuttertag
            // 
            this.lblMuttertag.AutoSize = true;
            this.lblMuttertag.Location = new System.Drawing.Point(398, 73);
            this.lblMuttertag.Name = "lblMuttertag";
            this.lblMuttertag.Size = new System.Drawing.Size(19, 25);
            this.lblMuttertag.TabIndex = 5;
            this.lblMuttertag.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 272);
            this.Controls.Add(this.lblMuttertag);
            this.Controls.Add(this.lblGeburtstag);
            this.Controls.Add(this.ckbMuttertag);
            this.Controls.Add(this.ckbConnect);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.callMethod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button callMethod;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox ckbConnect;
        private System.Windows.Forms.CheckBox ckbMuttertag;
        private System.Windows.Forms.Label lblGeburtstag;
        private System.Windows.Forms.Label lblMuttertag;
    }
}

