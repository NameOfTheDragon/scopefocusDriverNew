namespace ASCOM.scopefocus6
{
    partial class SetupDialogForm
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picASCOM = new System.Windows.Forms.PictureBox();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkSetPos = new System.Windows.Forms.CheckBox();
            this.textPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxPos = new System.Windows.Forms.TextBox();
            this.reverseCheckBox1 = new System.Windows.Forms.CheckBox();
            this.contHoldCheckBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(281, 143);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(59, 24);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(281, 173);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(59, 25);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select COM port and position (optional)";
            // 
            // picASCOM
            // 
            this.picASCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picASCOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picASCOM.Image = global::ASCOM.scopefocus6.Properties.Resources.ASCOM;
            this.picASCOM.Location = new System.Drawing.Point(292, 9);
            this.picASCOM.Name = "picASCOM";
            this.picASCOM.Size = new System.Drawing.Size(48, 56);
            this.picASCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picASCOM.TabIndex = 3;
            this.picASCOM.TabStop = false;
            this.picASCOM.Click += new System.EventHandler(this.BrowseToAscom);
            this.picASCOM.DoubleClick += new System.EventHandler(this.BrowseToAscom);
            // 
            // chkTrace
            // 
            this.chkTrace.AutoSize = true;
            this.chkTrace.Location = new System.Drawing.Point(23, 43);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(69, 17);
            this.chkTrace.TabIndex = 6;
            this.chkTrace.Text = "Trace on";
            this.chkTrace.UseVisualStyleBackColor = true;
            this.chkTrace.CheckedChanged += new System.EventHandler(this.chkTrace_CheckedChanged);
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(112, 72);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 21);
            this.cbComPort.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comm Port";
            // 
            // checkSetPos
            // 
            this.checkSetPos.AutoSize = true;
            this.checkSetPos.Location = new System.Drawing.Point(45, 101);
            this.checkSetPos.Name = "checkSetPos";
            this.checkSetPos.Size = new System.Drawing.Size(82, 17);
            this.checkSetPos.TabIndex = 9;
            this.checkSetPos.Text = "Set Position";
            this.checkSetPos.UseVisualStyleBackColor = true;
            this.checkSetPos.CheckedChanged += new System.EventHandler(this.checkSetPos_CheckedChanged);
            // 
            // textPos
            // 
            this.textPos.Location = new System.Drawing.Point(133, 99);
            this.textPos.Name = "textPos";
            this.textPos.Size = new System.Drawing.Size(100, 20);
            this.textPos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "MaxPos";
            // 
            // tbMaxPos
            // 
            this.tbMaxPos.Location = new System.Drawing.Point(134, 125);
            this.tbMaxPos.Name = "tbMaxPos";
            this.tbMaxPos.Size = new System.Drawing.Size(100, 20);
            this.tbMaxPos.TabIndex = 12;
            // 
            // reverseCheckBox1
            // 
            this.reverseCheckBox1.AutoSize = true;
            this.reverseCheckBox1.Location = new System.Drawing.Point(133, 159);
            this.reverseCheckBox1.Name = "reverseCheckBox1";
            this.reverseCheckBox1.Size = new System.Drawing.Size(111, 17);
            this.reverseCheckBox1.TabIndex = 13;
            this.reverseCheckBox1.Text = "Reverse Direction";
            this.reverseCheckBox1.UseVisualStyleBackColor = true;
            // 
            // contHoldCheckBox2
            // 
            this.contHoldCheckBox2.AutoSize = true;
            this.contHoldCheckBox2.Location = new System.Drawing.Point(133, 182);
            this.contHoldCheckBox2.Name = "contHoldCheckBox2";
            this.contHoldCheckBox2.Size = new System.Drawing.Size(104, 17);
            this.contHoldCheckBox2.TabIndex = 14;
            this.contHoldCheckBox2.Text = "Continuous Hold";
            this.contHoldCheckBox2.UseVisualStyleBackColor = true;
            // 
            // SetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 206);
            this.Controls.Add(this.contHoldCheckBox2);
            this.Controls.Add(this.reverseCheckBox1);
            this.Controls.Add(this.tbMaxPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPos);
            this.Controls.Add(this.checkSetPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbComPort);
            this.Controls.Add(this.chkTrace);
            this.Controls.Add(this.picASCOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "scopefocus6 Setup";
            this.Load += new System.EventHandler(this.SetupDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picASCOM;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkSetPos;
        private System.Windows.Forms.TextBox textPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaxPos;
        private System.Windows.Forms.CheckBox reverseCheckBox1;
        private System.Windows.Forms.CheckBox contHoldCheckBox2;
    }
}