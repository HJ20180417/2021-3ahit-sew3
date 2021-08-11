
namespace _20201118_fahrzeugVererbung
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
            this.rbtFerrari = new System.Windows.Forms.RadioButton();
            this.rbtYacht = new System.Windows.Forms.RadioButton();
            this.rbtPrivatjet = new System.Windows.Forms.RadioButton();
            this.grbFortbewegungsmittel = new System.Windows.Forms.GroupBox();
            this.btnMotorAn = new System.Windows.Forms.Button();
            this.btnMotorAus = new System.Windows.Forms.Button();
            this.btnBeschleunigeUm = new System.Windows.Forms.Button();
            this.txtSpeedUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.grbFortbewegungsmittel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtFerrari
            // 
            this.rbtFerrari.AutoSize = true;
            this.rbtFerrari.Location = new System.Drawing.Point(38, 104);
            this.rbtFerrari.Name = "rbtFerrari";
            this.rbtFerrari.Size = new System.Drawing.Size(106, 29);
            this.rbtFerrari.TabIndex = 0;
            this.rbtFerrari.TabStop = true;
            this.rbtFerrari.Text = "Ferrari";
            this.rbtFerrari.UseVisualStyleBackColor = true;
            // 
            // rbtYacht
            // 
            this.rbtYacht.AutoSize = true;
            this.rbtYacht.Location = new System.Drawing.Point(38, 58);
            this.rbtYacht.Name = "rbtYacht";
            this.rbtYacht.Size = new System.Drawing.Size(99, 29);
            this.rbtYacht.TabIndex = 1;
            this.rbtYacht.TabStop = true;
            this.rbtYacht.Text = "Yacht";
            this.rbtYacht.UseVisualStyleBackColor = true;
            // 
            // rbtPrivatjet
            // 
            this.rbtPrivatjet.AutoSize = true;
            this.rbtPrivatjet.Location = new System.Drawing.Point(38, 153);
            this.rbtPrivatjet.Name = "rbtPrivatjet";
            this.rbtPrivatjet.Size = new System.Drawing.Size(121, 29);
            this.rbtPrivatjet.TabIndex = 2;
            this.rbtPrivatjet.TabStop = true;
            this.rbtPrivatjet.Text = "Privatjet";
            this.rbtPrivatjet.UseVisualStyleBackColor = true;
            // 
            // grbFortbewegungsmittel
            // 
            this.grbFortbewegungsmittel.Controls.Add(this.rbtPrivatjet);
            this.grbFortbewegungsmittel.Controls.Add(this.rbtFerrari);
            this.grbFortbewegungsmittel.Controls.Add(this.rbtYacht);
            this.grbFortbewegungsmittel.Location = new System.Drawing.Point(12, 12);
            this.grbFortbewegungsmittel.Name = "grbFortbewegungsmittel";
            this.grbFortbewegungsmittel.Size = new System.Drawing.Size(228, 204);
            this.grbFortbewegungsmittel.TabIndex = 3;
            this.grbFortbewegungsmittel.TabStop = false;
            this.grbFortbewegungsmittel.Text = "Fortbewegunsmittel";
            // 
            // btnMotorAn
            // 
            this.btnMotorAn.Location = new System.Drawing.Point(13, 237);
            this.btnMotorAn.Name = "btnMotorAn";
            this.btnMotorAn.Size = new System.Drawing.Size(227, 50);
            this.btnMotorAn.TabIndex = 4;
            this.btnMotorAn.Text = "Motor an";
            this.btnMotorAn.UseVisualStyleBackColor = true;
            this.btnMotorAn.Click += new System.EventHandler(this.btnMotorAn_Click);
            // 
            // btnMotorAus
            // 
            this.btnMotorAus.Location = new System.Drawing.Point(13, 305);
            this.btnMotorAus.Name = "btnMotorAus";
            this.btnMotorAus.Size = new System.Drawing.Size(227, 50);
            this.btnMotorAus.TabIndex = 5;
            this.btnMotorAus.Text = "Motor aus";
            this.btnMotorAus.UseVisualStyleBackColor = true;
            this.btnMotorAus.Click += new System.EventHandler(this.btnMotorAus_Click);
            // 
            // btnBeschleunigeUm
            // 
            this.btnBeschleunigeUm.Location = new System.Drawing.Point(13, 425);
            this.btnBeschleunigeUm.Name = "btnBeschleunigeUm";
            this.btnBeschleunigeUm.Size = new System.Drawing.Size(227, 59);
            this.btnBeschleunigeUm.TabIndex = 7;
            this.btnBeschleunigeUm.Text = "Beschleunige um:";
            this.btnBeschleunigeUm.UseVisualStyleBackColor = true;
            this.btnBeschleunigeUm.Click += new System.EventHandler(this.btnBeschleunigeUm_Click);
            // 
            // txtSpeedUp
            // 
            this.txtSpeedUp.Location = new System.Drawing.Point(246, 425);
            this.txtSpeedUp.Name = "txtSpeedUp";
            this.txtSpeedUp.Size = new System.Drawing.Size(176, 31);
            this.txtSpeedUp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aktuelle Geschwindigkeit:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(278, 487);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(76, 25);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "0 km/h";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(228, 36);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(270, 237);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(125, 25);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Motorstatus";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(275, 305);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 25);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "aus";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 362);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(228, 57);
            this.btnInfo.TabIndex = 14;
            this.btnInfo.Text = "Fahrzeuginfo";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 614);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpeedUp);
            this.Controls.Add(this.btnBeschleunigeUm);
            this.Controls.Add(this.btnMotorAus);
            this.Controls.Add(this.btnMotorAn);
            this.Controls.Add(this.grbFortbewegungsmittel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbFortbewegungsmittel.ResumeLayout(false);
            this.grbFortbewegungsmittel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtFerrari;
        private System.Windows.Forms.RadioButton rbtYacht;
        private System.Windows.Forms.RadioButton rbtPrivatjet;
        private System.Windows.Forms.GroupBox grbFortbewegungsmittel;
        private System.Windows.Forms.Button btnMotorAn;
        private System.Windows.Forms.Button btnMotorAus;
        private System.Windows.Forms.Button btnBeschleunigeUm;
        private System.Windows.Forms.TextBox txtSpeedUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnInfo;
    }
}

