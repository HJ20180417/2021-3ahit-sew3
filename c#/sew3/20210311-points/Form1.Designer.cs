namespace _20210311_points
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYref = new System.Windows.Forms.TextBox();
            this.txtXref = new System.Windows.Forms.TextBox();
            this.cmdSort = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonBin = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.lboxcoords = new System.Windows.Forms.ListBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txt_Index = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdReadCoords = new System.Windows.Forms.Button();
            this.cmdWriteCoords = new System.Windows.Forms.Button();
            this.cmdClearLbox = new System.Windows.Forms.Button();
            this.cmdAusgabe = new System.Windows.Forms.Button();
            this.cmdSaveCoords = new System.Windows.Forms.Button();
            this.txtYcoords = new System.Windows.Forms.TextBox();
            this.txtXcoords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Y ref";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "X ref";
            // 
            // txtYref
            // 
            this.txtYref.Location = new System.Drawing.Point(94, 329);
            this.txtYref.Name = "txtYref";
            this.txtYref.Size = new System.Drawing.Size(37, 20);
            this.txtYref.TabIndex = 38;
            this.txtYref.Text = "0";
            // 
            // txtXref
            // 
            this.txtXref.Location = new System.Drawing.Point(21, 331);
            this.txtXref.Name = "txtXref";
            this.txtXref.Size = new System.Drawing.Size(35, 20);
            this.txtXref.TabIndex = 37;
            this.txtXref.Text = "0";
            // 
            // cmdSort
            // 
            this.cmdSort.Location = new System.Drawing.Point(168, 326);
            this.cmdSort.Name = "cmdSort";
            this.cmdSort.Size = new System.Drawing.Size(106, 25);
            this.cmdSort.TabIndex = 36;
            this.cmdSort.Text = "Ausgabe sortieren";
            this.cmdSort.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonBin);
            this.panel1.Controls.Add(this.radioButtonText);
            this.panel1.Location = new System.Drawing.Point(201, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 51);
            this.panel1.TabIndex = 35;
            // 
            // radioButtonBin
            // 
            this.radioButtonBin.AutoSize = true;
            this.radioButtonBin.Location = new System.Drawing.Point(4, 29);
            this.radioButtonBin.Name = "radioButtonBin";
            this.radioButtonBin.Size = new System.Drawing.Size(49, 17);
            this.radioButtonBin.TabIndex = 1;
            this.radioButtonBin.TabStop = true;
            this.radioButtonBin.Text = "Binär";
            this.radioButtonBin.UseVisualStyleBackColor = true;
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Checked = true;
            this.radioButtonText.Location = new System.Drawing.Point(4, 6);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(46, 17);
            this.radioButtonText.TabIndex = 0;
            this.radioButtonText.TabStop = true;
            this.radioButtonText.Text = "Text";
            this.radioButtonText.UseVisualStyleBackColor = true;
            // 
            // lboxcoords
            // 
            this.lboxcoords.FormattingEnabled = true;
            this.lboxcoords.Location = new System.Drawing.Point(12, 45);
            this.lboxcoords.Name = "lboxcoords";
            this.lboxcoords.Size = new System.Drawing.Size(128, 173);
            this.lboxcoords.TabIndex = 34;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(56, 262);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 33;
            this.cmdSearch.Text = "Suchen...";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // txt_Index
            // 
            this.txt_Index.Location = new System.Drawing.Point(21, 264);
            this.txt_Index.Name = "txt_Index";
            this.txt_Index.Size = new System.Drawing.Size(29, 20);
            this.txt_Index.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nullbasierter Index der Koordinate";
            // 
            // cmdReadCoords
            // 
            this.cmdReadCoords.Location = new System.Drawing.Point(146, 181);
            this.cmdReadCoords.Name = "cmdReadCoords";
            this.cmdReadCoords.Size = new System.Drawing.Size(128, 37);
            this.cmdReadCoords.TabIndex = 30;
            this.cmdReadCoords.Text = "Koordinaten aus Datei lesen";
            this.cmdReadCoords.UseVisualStyleBackColor = true;
            // 
            // cmdWriteCoords
            // 
            this.cmdWriteCoords.Location = new System.Drawing.Point(146, 131);
            this.cmdWriteCoords.Name = "cmdWriteCoords";
            this.cmdWriteCoords.Size = new System.Drawing.Size(128, 41);
            this.cmdWriteCoords.TabIndex = 29;
            this.cmdWriteCoords.Text = "Koordinaten in Datei schreiben";
            this.cmdWriteCoords.UseVisualStyleBackColor = true;
            // 
            // cmdClearLbox
            // 
            this.cmdClearLbox.Location = new System.Drawing.Point(146, 88);
            this.cmdClearLbox.Name = "cmdClearLbox";
            this.cmdClearLbox.Size = new System.Drawing.Size(128, 37);
            this.cmdClearLbox.TabIndex = 28;
            this.cmdClearLbox.Text = "Koordinaten aus Listbox löschen";
            this.cmdClearLbox.UseVisualStyleBackColor = true;
            // 
            // cmdAusgabe
            // 
            this.cmdAusgabe.Location = new System.Drawing.Point(146, 45);
            this.cmdAusgabe.Name = "cmdAusgabe";
            this.cmdAusgabe.Size = new System.Drawing.Size(128, 37);
            this.cmdAusgabe.TabIndex = 27;
            this.cmdAusgabe.Text = "Koordinaten ausgeben";
            this.cmdAusgabe.UseVisualStyleBackColor = true;
            // 
            // cmdSaveCoords
            // 
            this.cmdSaveCoords.Location = new System.Drawing.Point(146, 5);
            this.cmdSaveCoords.Name = "cmdSaveCoords";
            this.cmdSaveCoords.Size = new System.Drawing.Size(128, 23);
            this.cmdSaveCoords.TabIndex = 26;
            this.cmdSaveCoords.Text = "Koordinaten speichern";
            this.cmdSaveCoords.UseVisualStyleBackColor = true;
            // 
            // txtYcoords
            // 
            this.txtYcoords.Location = new System.Drawing.Point(105, 8);
            this.txtYcoords.Name = "txtYcoords";
            this.txtYcoords.Size = new System.Drawing.Size(35, 20);
            this.txtYcoords.TabIndex = 25;
            // 
            // txtXcoords
            // 
            this.txtXcoords.Location = new System.Drawing.Point(32, 8);
            this.txtXcoords.Name = "txtXcoords";
            this.txtXcoords.Size = new System.Drawing.Size(32, 20);
            this.txtXcoords.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYref);
            this.Controls.Add(this.txtXref);
            this.Controls.Add(this.cmdSort);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxcoords);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txt_Index);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdReadCoords);
            this.Controls.Add(this.cmdWriteCoords);
            this.Controls.Add(this.cmdClearLbox);
            this.Controls.Add(this.cmdAusgabe);
            this.Controls.Add(this.cmdSaveCoords);
            this.Controls.Add(this.txtYcoords);
            this.Controls.Add(this.txtXcoords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYref;
        private System.Windows.Forms.TextBox txtXref;
        private System.Windows.Forms.Button cmdSort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonBin;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.ListBox lboxcoords;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txt_Index;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdReadCoords;
        private System.Windows.Forms.Button cmdWriteCoords;
        private System.Windows.Forms.Button cmdClearLbox;
        private System.Windows.Forms.Button cmdAusgabe;
        private System.Windows.Forms.Button cmdSaveCoords;
        private System.Windows.Forms.TextBox txtYcoords;
        private System.Windows.Forms.TextBox txtXcoords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

