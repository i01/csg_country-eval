namespace Country_Eval
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecutix360Dir = new System.Windows.Forms.TextBox();
            this.btnSecutix360Dir = new System.Windows.Forms.Button();
            this.txtSecutixOneDir = new System.Windows.Forms.TextBox();
            this.btnSecutixOneDir = new System.Windows.Forms.Button();
            this.txtHotmaxPath = new System.Windows.Forms.TextBox();
            this.txtEKSDir = new System.Windows.Forms.TextBox();
            this.btnEKSDir = new System.Windows.Forms.Button();
            this.lstSeasons = new System.Windows.Forms.ListBox();
            this.chkExhibitor = new System.Windows.Forms.CheckBox();
            this.chkTrade = new System.Windows.Forms.CheckBox();
            this.chkPress = new System.Windows.Forms.CheckBox();
            this.chkPrivate = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkDistinctBarcode = new System.Windows.Forms.CheckBox();
            this.chkShowMap = new System.Windows.Forms.CheckBox();
            this.chkExcludeDE = new System.Windows.Forms.CheckBox();
            this.chkIE9 = new System.Windows.Forms.CheckBox();
            this.txtCSVOut = new System.Windows.Forms.TextBox();
            this.btnCSVOut = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SecuTix 360 Exports:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EKS Exports:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "HotMax Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seasons (please select):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Output file:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "SecuTix One Exports:";
            // 
            // txtSecutix360Dir
            // 
            this.txtSecutix360Dir.Location = new System.Drawing.Point(12, 25);
            this.txtSecutix360Dir.Name = "txtSecutix360Dir";
            this.txtSecutix360Dir.ReadOnly = true;
            this.txtSecutix360Dir.Size = new System.Drawing.Size(230, 20);
            this.txtSecutix360Dir.TabIndex = 1;
            // 
            // btnSecutix360Dir
            // 
            this.btnSecutix360Dir.Location = new System.Drawing.Point(248, 23);
            this.btnSecutix360Dir.Name = "btnSecutix360Dir";
            this.btnSecutix360Dir.Size = new System.Drawing.Size(24, 23);
            this.btnSecutix360Dir.TabIndex = 2;
            this.btnSecutix360Dir.Text = "...";
            this.btnSecutix360Dir.UseVisualStyleBackColor = true;
            this.btnSecutix360Dir.Click += new System.EventHandler(this.btnSecutix360Dir_Click);
            // 
            // txtSecutixOneDir
            // 
            this.txtSecutixOneDir.Location = new System.Drawing.Point(12, 65);
            this.txtSecutixOneDir.Name = "txtSecutixOneDir";
            this.txtSecutixOneDir.ReadOnly = true;
            this.txtSecutixOneDir.Size = new System.Drawing.Size(229, 20);
            this.txtSecutixOneDir.TabIndex = 3;
            // 
            // btnSecutixOneDir
            // 
            this.btnSecutixOneDir.Location = new System.Drawing.Point(248, 63);
            this.btnSecutixOneDir.Name = "btnSecutixOneDir";
            this.btnSecutixOneDir.Size = new System.Drawing.Size(24, 23);
            this.btnSecutixOneDir.TabIndex = 4;
            this.btnSecutixOneDir.Text = "...";
            this.btnSecutixOneDir.UseVisualStyleBackColor = true;
            this.btnSecutixOneDir.Click += new System.EventHandler(this.btnSecutixOneDir_Click);
            // 
            // txtHotmaxPath
            // 
            this.txtHotmaxPath.Location = new System.Drawing.Point(12, 143);
            this.txtHotmaxPath.Name = "txtHotmaxPath";
            this.txtHotmaxPath.Size = new System.Drawing.Size(260, 20);
            this.txtHotmaxPath.TabIndex = 7;
            // 
            // txtEKSDir
            // 
            this.txtEKSDir.Location = new System.Drawing.Point(12, 104);
            this.txtEKSDir.Name = "txtEKSDir";
            this.txtEKSDir.ReadOnly = true;
            this.txtEKSDir.Size = new System.Drawing.Size(230, 20);
            this.txtEKSDir.TabIndex = 5;
            // 
            // btnEKSDir
            // 
            this.btnEKSDir.Location = new System.Drawing.Point(248, 102);
            this.btnEKSDir.Name = "btnEKSDir";
            this.btnEKSDir.Size = new System.Drawing.Size(24, 23);
            this.btnEKSDir.TabIndex = 6;
            this.btnEKSDir.Text = "...";
            this.btnEKSDir.UseVisualStyleBackColor = true;
            this.btnEKSDir.Click += new System.EventHandler(this.btnEKSDir_Click);
            // 
            // lstSeasons
            // 
            this.lstSeasons.FormattingEnabled = true;
            this.lstSeasons.Location = new System.Drawing.Point(12, 182);
            this.lstSeasons.Name = "lstSeasons";
            this.lstSeasons.Size = new System.Drawing.Size(165, 108);
            this.lstSeasons.TabIndex = 8;
            this.lstSeasons.SelectedIndexChanged += new System.EventHandler(this.lstSaisons_SelectedIndexChanged);
            // 
            // chkExhibitor
            // 
            this.chkExhibitor.AutoSize = true;
            this.chkExhibitor.Checked = true;
            this.chkExhibitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExhibitor.Location = new System.Drawing.Point(183, 182);
            this.chkExhibitor.Name = "chkExhibitor";
            this.chkExhibitor.Size = new System.Drawing.Size(66, 17);
            this.chkExhibitor.TabIndex = 9;
            this.chkExhibitor.Text = "Exhibitor";
            this.chkExhibitor.UseVisualStyleBackColor = true;
            // 
            // chkTrade
            // 
            this.chkTrade.AutoSize = true;
            this.chkTrade.Checked = true;
            this.chkTrade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrade.Location = new System.Drawing.Point(183, 205);
            this.chkTrade.Name = "chkTrade";
            this.chkTrade.Size = new System.Drawing.Size(84, 17);
            this.chkTrade.TabIndex = 10;
            this.chkTrade.Text = "Trade visitor";
            this.chkTrade.UseVisualStyleBackColor = true;
            // 
            // chkPress
            // 
            this.chkPress.AutoSize = true;
            this.chkPress.Checked = true;
            this.chkPress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPress.Location = new System.Drawing.Point(183, 228);
            this.chkPress.Name = "chkPress";
            this.chkPress.Size = new System.Drawing.Size(85, 17);
            this.chkPress.TabIndex = 11;
            this.chkPress.Text = "Press/media";
            this.chkPress.UseVisualStyleBackColor = true;
            // 
            // chkPrivate
            // 
            this.chkPrivate.AutoSize = true;
            this.chkPrivate.Checked = true;
            this.chkPrivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrivate.Location = new System.Drawing.Point(183, 251);
            this.chkPrivate.Name = "chkPrivate";
            this.chkPrivate.Size = new System.Drawing.Size(89, 17);
            this.chkPrivate.TabIndex = 12;
            this.chkPrivate.Text = "Private visitor";
            this.chkPrivate.UseVisualStyleBackColor = true;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Checked = true;
            this.chkOther.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOther.Location = new System.Drawing.Point(183, 274);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(52, 17);
            this.chkOther.TabIndex = 13;
            this.chkOther.Text = "Other";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // chkDistinctBarcode
            // 
            this.chkDistinctBarcode.AutoSize = true;
            this.chkDistinctBarcode.Location = new System.Drawing.Point(12, 342);
            this.chkDistinctBarcode.Name = "chkDistinctBarcode";
            this.chkDistinctBarcode.Size = new System.Drawing.Size(168, 17);
            this.chkDistinctBarcode.TabIndex = 17;
            this.chkDistinctBarcode.Text = "count each barcode just once";
            this.chkDistinctBarcode.UseVisualStyleBackColor = true;
            // 
            // chkShowMap
            // 
            this.chkShowMap.AutoSize = true;
            this.chkShowMap.Location = new System.Drawing.Point(12, 296);
            this.chkShowMap.Name = "chkShowMap";
            this.chkShowMap.Size = new System.Drawing.Size(148, 17);
            this.chkShowMap.TabIndex = 14;
            this.chkShowMap.Text = "show map in web browser";
            this.chkShowMap.UseVisualStyleBackColor = true;
            this.chkShowMap.CheckedChanged += new System.EventHandler(this.chkShowMap_CheckedChanged);
            // 
            // chkExcludeDE
            // 
            this.chkExcludeDE.AutoSize = true;
            this.chkExcludeDE.Enabled = false;
            this.chkExcludeDE.Location = new System.Drawing.Point(12, 319);
            this.chkExcludeDE.Name = "chkExcludeDE";
            this.chkExcludeDE.Size = new System.Drawing.Size(154, 17);
            this.chkExcludeDE.TabIndex = 15;
            this.chkExcludeDE.Text = "exclude Germany from map";
            this.chkExcludeDE.UseVisualStyleBackColor = true;
            // 
            // chkIE9
            // 
            this.chkIE9.AutoSize = true;
            this.chkIE9.Enabled = false;
            this.chkIE9.Location = new System.Drawing.Point(183, 319);
            this.chkIE9.Name = "chkIE9";
            this.chkIE9.Size = new System.Drawing.Size(78, 17);
            this.chkIE9.TabIndex = 16;
            this.chkIE9.Text = "opt. for IE9";
            this.chkIE9.UseVisualStyleBackColor = true;
            // 
            // txtCSVOut
            // 
            this.txtCSVOut.Location = new System.Drawing.Point(12, 378);
            this.txtCSVOut.Name = "txtCSVOut";
            this.txtCSVOut.ReadOnly = true;
            this.txtCSVOut.Size = new System.Drawing.Size(230, 20);
            this.txtCSVOut.TabIndex = 18;
            // 
            // btnCSVOut
            // 
            this.btnCSVOut.Location = new System.Drawing.Point(248, 376);
            this.btnCSVOut.Name = "btnCSVOut";
            this.btnCSVOut.Size = new System.Drawing.Size(24, 23);
            this.btnCSVOut.TabIndex = 19;
            this.btnCSVOut.Text = "...";
            this.btnCSVOut.UseVisualStyleBackColor = true;
            this.btnCSVOut.Click += new System.EventHandler(this.btnCSVOut_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 419);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "[Status]";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(197, 414);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSecutix360Dir);
            this.Controls.Add(this.btnSecutix360Dir);
            this.Controls.Add(this.txtSecutixOneDir);
            this.Controls.Add(this.btnSecutixOneDir);
            this.Controls.Add(this.txtHotmaxPath);
            this.Controls.Add(this.txtEKSDir);
            this.Controls.Add(this.btnEKSDir);
            this.Controls.Add(this.lstSeasons);
            this.Controls.Add(this.chkExhibitor);
            this.Controls.Add(this.chkTrade);
            this.Controls.Add(this.chkPress);
            this.Controls.Add(this.chkPrivate);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkDistinctBarcode);
            this.Controls.Add(this.chkShowMap);
            this.Controls.Add(this.chkExcludeDE);
            this.Controls.Add(this.chkIE9);
            this.Controls.Add(this.txtCSVOut);
            this.Controls.Add(this.btnCSVOut);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 480);
            this.MinimumSize = new System.Drawing.Size(300, 480);
            this.Name = "Form1";
            this.Text = "Country_Eval    v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSecutix360Dir;
        private System.Windows.Forms.Button btnSecutix360Dir;
        private System.Windows.Forms.TextBox txtSecutixOneDir;
        private System.Windows.Forms.Button btnSecutixOneDir;
        private System.Windows.Forms.TextBox txtHotmaxPath;
        private System.Windows.Forms.TextBox txtEKSDir;
        private System.Windows.Forms.Button btnEKSDir;
        private System.Windows.Forms.ListBox lstSeasons;
        private System.Windows.Forms.CheckBox chkExhibitor;
        private System.Windows.Forms.CheckBox chkTrade;
        private System.Windows.Forms.CheckBox chkPress;
        private System.Windows.Forms.CheckBox chkPrivate;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkDistinctBarcode;
        private System.Windows.Forms.CheckBox chkShowMap;
        private System.Windows.Forms.CheckBox chkExcludeDE;
        private System.Windows.Forms.CheckBox chkIE9;
        private System.Windows.Forms.TextBox txtCSVOut;
        private System.Windows.Forms.Button btnCSVOut;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;
    }
}

