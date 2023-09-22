namespace COMReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbPorts = new ComboBox();
            cmbBaudrate = new ComboBox();
            cmbParity = new ComboBox();
            cmbStopbits = new ComboBox();
            nmDataBit = new NumericUpDown();
            btnOpen = new Button();
            btnClose = new Button();
            txtData = new RichTextBox();
            lblStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnClearReceived = new Button();
            txtRegexTemplate = new TextBox();
            chkUseRegex = new CheckBox();
            tabPage2 = new TabPage();
            btnClearSent = new Button();
            groupBox1 = new GroupBox();
            chkAddAfter = new CheckBox();
            txtTemplate = new TextBox();
            label8 = new Label();
            btnTestData = new Button();
            nmCount = new NumericUpDown();
            label7 = new Label();
            btnStop = new Button();
            nmSleep = new NumericUpDown();
            label6 = new Label();
            txtSentData = new RichTextBox();
            btnSend = new Button();
            txtMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nmDataBit).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmSleep).BeginInit();
            SuspendLayout();
            // 
            // cmbPorts
            // 
            cmbPorts.FormattingEnabled = true;
            cmbPorts.Location = new Point(9, 26);
            cmbPorts.Name = "cmbPorts";
            cmbPorts.Size = new Size(121, 23);
            cmbPorts.TabIndex = 0;
            // 
            // cmbBaudrate
            // 
            cmbBaudrate.FormattingEnabled = true;
            cmbBaudrate.Location = new Point(136, 26);
            cmbBaudrate.Name = "cmbBaudrate";
            cmbBaudrate.Size = new Size(121, 23);
            cmbBaudrate.TabIndex = 1;
            // 
            // cmbParity
            // 
            cmbParity.FormattingEnabled = true;
            cmbParity.Location = new Point(263, 26);
            cmbParity.Name = "cmbParity";
            cmbParity.Size = new Size(121, 23);
            cmbParity.TabIndex = 2;
            // 
            // cmbStopbits
            // 
            cmbStopbits.FormattingEnabled = true;
            cmbStopbits.Location = new Point(390, 26);
            cmbStopbits.Name = "cmbStopbits";
            cmbStopbits.Size = new Size(121, 23);
            cmbStopbits.TabIndex = 3;
            // 
            // nmDataBit
            // 
            nmDataBit.Location = new Point(517, 26);
            nmDataBit.Name = "nmDataBit";
            nmDataBit.Size = new Size(65, 23);
            nmDataBit.TabIndex = 4;
            nmDataBit.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(9, 65);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(192, 23);
            btnOpen.TabIndex = 5;
            btnOpen.Text = "Connect";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(390, 65);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(192, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Disconnect";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(3, 33);
            txtData.Name = "txtData";
            txtData.ReadOnly = true;
            txtData.Size = new Size(583, 212);
            txtData.TabIndex = 7;
            txtData.Text = "";
            txtData.TextChanged += txtData_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(263, 69);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Disconnected";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 8);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Baudrate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 8);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 11;
            label3.Text = "Parity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 8);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 12;
            label4.Text = "Stopbits";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(517, 8);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 13;
            label5.Text = "Databit";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 94);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(597, 276);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnClearReceived);
            tabPage1.Controls.Add(txtRegexTemplate);
            tabPage1.Controls.Add(chkUseRegex);
            tabPage1.Controls.Add(txtData);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(589, 248);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Receive";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClearReceived
            // 
            btnClearReceived.Location = new Point(511, 4);
            btnClearReceived.Name = "btnClearReceived";
            btnClearReceived.Size = new Size(75, 23);
            btnClearReceived.TabIndex = 10;
            btnClearReceived.Text = "Clear Box";
            btnClearReceived.UseVisualStyleBackColor = true;
            btnClearReceived.Click += btnClearReceived_Click;
            // 
            // txtRegexTemplate
            // 
            txtRegexTemplate.Location = new Point(91, 4);
            txtRegexTemplate.Name = "txtRegexTemplate";
            txtRegexTemplate.Size = new Size(397, 23);
            txtRegexTemplate.TabIndex = 9;
            txtRegexTemplate.Text = "(\\d+)\\s*kg";
            // 
            // chkUseRegex
            // 
            chkUseRegex.AutoSize = true;
            chkUseRegex.Location = new Point(8, 6);
            chkUseRegex.Name = "chkUseRegex";
            chkUseRegex.Size = new Size(86, 19);
            chkUseRegex.TabIndex = 8;
            chkUseRegex.Text = "Use Regex :";
            chkUseRegex.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnClearSent);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(txtSentData);
            tabPage2.Controls.Add(btnSend);
            tabPage2.Controls.Add(txtMessage);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(589, 248);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Send";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearSent
            // 
            btnClearSent.Location = new Point(311, 6);
            btnClearSent.Name = "btnClearSent";
            btnClearSent.Size = new Size(69, 23);
            btnClearSent.TabIndex = 15;
            btnClearSent.Text = "Clear";
            btnClearSent.UseVisualStyleBackColor = true;
            btnClearSent.Click += btnClearSent_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAddAfter);
            groupBox1.Controls.Add(txtTemplate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnTestData);
            groupBox1.Controls.Add(nmCount);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnStop);
            groupBox1.Controls.Add(nmSleep);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(386, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 234);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Send test data";
            // 
            // chkAddAfter
            // 
            chkAddAfter.AutoSize = true;
            chkAddAfter.Location = new Point(6, 151);
            chkAddAfter.Name = "chkAddAfter";
            chkAddAfter.Size = new Size(96, 19);
            chkAddAfter.TabIndex = 16;
            chkAddAfter.Text = "Use Template";
            chkAddAfter.UseVisualStyleBackColor = true;
            // 
            // txtTemplate
            // 
            txtTemplate.Location = new Point(3, 125);
            txtTemplate.Name = "txtTemplate";
            txtTemplate.Size = new Size(188, 23);
            txtTemplate.TabIndex = 15;
            txtTemplate.Text = "ST,GS,0?,     {number}  kg";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 107);
            label8.Name = "label8";
            label8.Size = new Size(149, 15);
            label8.TabIndex = 14;
            label8.Text = "Data Template ({number}) :";
            // 
            // btnTestData
            // 
            btnTestData.Location = new Point(6, 176);
            btnTestData.Name = "btnTestData";
            btnTestData.Size = new Size(185, 23);
            btnTestData.TabIndex = 8;
            btnTestData.Text = "Send with Loop (Test)";
            btnTestData.UseVisualStyleBackColor = true;
            btnTestData.Click += btnTestData_Click;
            // 
            // nmCount
            // 
            nmCount.Location = new Point(3, 81);
            nmCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmCount.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nmCount.Name = "nmCount";
            nmCount.Size = new Size(188, 23);
            nmCount.TabIndex = 13;
            nmCount.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 63);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 12;
            label7.Text = "Data Count :";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(6, 205);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(185, 23);
            btnStop.TabIndex = 11;
            btnStop.Text = "Stop Test";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // nmSleep
            // 
            nmSleep.Location = new Point(3, 37);
            nmSleep.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nmSleep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmSleep.Name = "nmSleep";
            nmSleep.Size = new Size(188, 23);
            nmSleep.TabIndex = 10;
            nmSleep.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 19);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 9;
            label6.Text = "Sleep (ms) :";
            // 
            // txtSentData
            // 
            txtSentData.DetectUrls = false;
            txtSentData.Location = new Point(8, 35);
            txtSentData.Name = "txtSentData";
            txtSentData.ReadOnly = true;
            txtSentData.Size = new Size(372, 205);
            txtSentData.TabIndex = 7;
            txtSentData.Text = "";
            txtSentData.TextChanged += txtSentData_TextChanged;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(236, 6);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(69, 23);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(8, 6);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(222, 23);
            txtMessage.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 370);
            Controls.Add(cmbStopbits);
            Controls.Add(tabControl1);
            Controls.Add(cmbBaudrate);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(nmDataBit);
            Controls.Add(cmbPorts);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(cmbParity);
            Controls.Add(btnOpen);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(613, 409);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COM Test";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmDataBit).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmSleep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPorts;
        private ComboBox cmbBaudrate;
        private ComboBox cmbParity;
        private ComboBox cmbStopbits;
        private NumericUpDown nmDataBit;
        private Button btnOpen;
        private Button btnClose;
        private RichTextBox txtData;
        private Label lblStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox txtSentData;
        private Button btnSend;
        private TextBox txtMessage;
        private Button btnTestData;
        private NumericUpDown nmSleep;
        private Label label6;
        private NumericUpDown nmCount;
        private Label label7;
        private Button btnStop;
        private GroupBox groupBox1;
        private CheckBox chkAddAfter;
        private TextBox txtTemplate;
        private Label label8;
        private TextBox txtRegexTemplate;
        private CheckBox chkUseRegex;
        private Button btnClearSent;
        private Button btnClearReceived;
    }
}